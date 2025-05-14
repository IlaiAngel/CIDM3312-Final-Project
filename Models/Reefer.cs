using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models;


public class Reefer
{
    public int ReeferID {get; set;}
    public string Description {get; set;} = string.Empty;

    public Driver Driver {get;  set;} = default!;
}


