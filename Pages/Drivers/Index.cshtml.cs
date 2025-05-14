using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Pages.Drivers
{
    public class IndexModel : PageModel
    {
        private readonly FinalProject.Models.AppDbContext _context;

        public IndexModel(FinalProject.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Driver> Driver { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;
        public int TotalPages {get; set;}

        [BindProperty(SupportsGet = true)]
        public string CurrentSort{get; set;} = string.Empty;

        [BindProperty(SupportsGet = true)]
        public string CurrentSearch {get; set;} = string.Empty;
    

        public async Task OnGetAsync()

        {
    var query = _context.Drivers.Include(s => s.TruckDrivers!).ThenInclude(sc => sc.Truck).Select(s => s);

    if (!string.IsNullOrEmpty(CurrentSearch))
{
    query = query.Where(s => s.FirstName.ToUpper().Contains(CurrentSearch.ToUpper()) || s.LastName.ToUpper().Contains(CurrentSearch.ToUpper()));
}






    switch (CurrentSort)
    {
        case "first_asc":
            query = query.OrderBy(s => s.FirstName);
            break;
        case "first_desc":
            query = query.OrderByDescending(s => s.FirstName);
            break;
    }

    TotalPages = (int)Math.Ceiling(query.Count() / (double)PageSize);

    Driver = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
    

            //Driver = await _context.Drivers.Include(s => s.TruckDrivers!).ThenInclude(sc => sc.Truck).ToListAsync();
        }
    }
}
