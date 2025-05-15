using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalProject.Pages;

public class StaffModel : PageModel
{
    private readonly ILogger<StaffModel> _logger;

    public StaffModel(ILogger<StaffModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

