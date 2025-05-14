using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models;

public class Driver
{
    public int DriverID {get; set;} // Primary Key

    [Display(Name = "First Name")]
    public string FirstName {get; set;} = string.Empty;
    
    [Display(Name = "Last Name")]
    public string LastName {get; set;} = string.Empty;


    [Display(Name = "Assigned Truck")]
    public List<TruckDriver>? TruckDrivers {get; set;} = default!;

    



    public int? ReeferID {get; set;}
    public Reefer? Reefer {get; set;} = default!;








}

