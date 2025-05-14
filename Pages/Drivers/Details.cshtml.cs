using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;
using NuGet.ProjectModel;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Pages.Drivers
{
    public class DetailsModel : PageModel
    {
        private readonly FinalProject.Models.AppDbContext _context;
        private readonly ILogger<DetailsModel> _logger;

        public DetailsModel(ILogger<DetailsModel> logger, FinalProject.Models.AppDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public Driver Driver { get; set; } = default!;

        [BindProperty]
        [Display(Name = "Add Reefer")]
        [Required(ErrorMessage = "Invalid Reefer")]
        public int ReeferIDToAdd {get; set;}

        public SelectList ReefersDropDown{get; set;} =default!;

        [BindProperty]
        public int ReeferIDToDelete {get; set;}

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var driver = await _context.Drivers.Include(d => d.TruckDrivers!).ThenInclude(td => td.Truck).Include(d => d.Reefer).FirstOrDefaultAsync(s => s.DriverID == id);

            if (driver is not null)
            {
                Driver = driver;
                ReefersDropDown = new SelectList(_context.Reefers.ToList(),"ReeferID", "Description");

                return Page();
            }

            return NotFound();
        }

                    public IActionResult OnPostAddReefer(int? id)
                    {
            _logger.LogWarning($"Add Reefer: DriverId {id}, ADD Reefer {ReeferIDToAdd}");

            if (id == null)
            {
                return NotFound();
            }

            var driver = _context.Drivers.Include(d => d.TruckDrivers!).ThenInclude(td => td.Truck).Include(d => d.Reefer).FirstOrDefault(m => m.DriverID == id);

            if (driver == null)
            {
                return NotFound();
            }
                Driver = driver;
                ReefersDropDown = new SelectList(_context.Reefers.ToList(), "ReeferID", "Description");

            if (!ModelState.IsValid)
            {
                _logger.LogWarning($"Model State is INVALID");
                return Page();
            }


            bool ReeferUse = _context.Drivers.Any(s => s.ReeferID == ReeferIDToAdd && s.DriverID !=id);

                if(!ReeferUse)
                {
                driver.ReeferID = ReeferIDToAdd;
                _context.Update(driver);
                _context.SaveChanges();
                
            } else
            {

                _logger.LogWarning("Driver already assigned to reefer");
            }
            
            return Page();
         }
         public IActionResult OnPostDropReefer(int? id)
{
    _logger.LogWarning($"Drop Reefer: DriverId {id}, DROP Reefer {ReeferIDToDelete}");

    if (id == null)
    {
        return NotFound();
    }

    var driver = _context.Drivers.Include(s => s.TruckDrivers!).ThenInclude(td => td.Truck).Include(d => d.Reefer).FirstOrDefault(m => m.DriverID == id);

    if (driver == null)
    {
        return NotFound();
    }
  
        Driver = driver;

    ReefersDropDown = new SelectList(_context.Trucks.ToList(), "TruckID", "Description");

    var ReeferToDrop = _context.TruckDrivers.Find(ReeferIDToDelete, id);
    if(driver.ReeferID == ReeferIDToDelete)
    {
        driver.ReeferID = null;
        _context.Update(driver);
        _context.SaveChanges();
    }
    else 
    {
        _logger.LogWarning("Reefer NOT assigned to Driver");
    }

    // Use RedirectToPage instead of Page to reload the same page
    // But RedirectToPage resets the ModelState so no errors are present
    // Otherwise, our other form to add a course would show an invalid course error
    return RedirectToPage(new {id = id});
}
    }
}


