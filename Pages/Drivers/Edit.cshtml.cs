using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Pages.Drivers
{
    public class EditModel : PageModel
    {
        private readonly FinalProject.Models.AppDbContext _context;

        public EditModel(FinalProject.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Driver Driver { get; set; } = default!;

        public List<Truck> Trucks {get; set;} = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var driver =  await _context.Drivers.Include(s => s.TruckDrivers!).ThenInclude(sc => sc.Truck).FirstOrDefaultAsync(m => m.DriverID == id);
            Trucks = _context.Trucks.ToList();
            if (driver == null)
            {
                return NotFound();
            }
            Driver = driver;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int[] selectedTrucks)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

           

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DriverExists(Driver.DriverID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DriverExists(int id)
        {
            return _context.Drivers.Any(e => e.DriverID == id);
        }
    }
}
