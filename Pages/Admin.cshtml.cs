using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalProject.Pages;

public class AdminModel : PageModel
{
    private readonly ILogger<AdminModel> _logger;

    [BindProperty]
    public string Username {get; set;} = string.Empty;

    [BindProperty]
    public string Password {get; set;} = string.Empty;

    public AdminModel(ILogger<AdminModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

    public IActionResult OnPost()
    {
        _logger.LogWarning($"OnPost() called. Username = {Username} Password = {Password}");

        string AdminUser = "Yellow";
        string AdminPass = "Trucking123";

        if (Username == AdminUser && Password == AdminPass)
        {
            //Redirecting to index for now until i start adding my data in 
            return RedirectToPage("/Index");
        }
        else
        {
            Console.WriteLine("Incorrect ");
            return Page();
        }
    }
}


