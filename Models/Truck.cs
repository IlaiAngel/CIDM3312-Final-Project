namespace FinalProject.Models;

public class Truck
{
    public int TruckID {get; set;} // Primary Key
    public string Description {get; set;} = string.Empty;

    // This property is optional (?) because Students can exist without being in a course. Courses can exist without students.
public List<TruckDriver>? TruckDrivers {get; set;} = default!; // Navigation property. A student can be enrolled in many courses
}

public class TruckDriver
{
    public int TruckID {get; set;} // Composite Primary Key, Foreign Key 1
    public int DriverID {get; set;} // Composite Primary Key, Foreign Key 2
    public Driver Driver {get; set;} = default!; // Navigation Property
    public Truck Truck {get; set;} = default!; // Navigation Property
}

