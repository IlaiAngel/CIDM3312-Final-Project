using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>());

        if (context.Drivers.Any())
        {
            return;
        }

        // Add Students, Courses, and StudentCourses below


        // Add Students, Courses, and StudentCourses below


List<Reefer> reefres = new List<Reefer>
{
    new Reefer { ReeferID = 1, Description = "Reefer #1" },
new Reefer { ReeferID = 2, Description = "Reefer #2" },
new Reefer { ReeferID = 3, Description = "Reefer #3" },
new Reefer { ReeferID = 4, Description = "Reefer #4" },
new Reefer { ReeferID = 5, Description = "Reefer #5" },
new Reefer { ReeferID = 6, Description = "Reefer #6" },
new Reefer { ReeferID = 7, Description = "Reefer #7" },
new Reefer { ReeferID = 8, Description = "Reefer #8" },
new Reefer { ReeferID = 9, Description = "Reefer #9" },
new Reefer { ReeferID = 10, Description = "Reefer #10" },
new Reefer { ReeferID = 11, Description = "Reefer #11" },
new Reefer { ReeferID = 12, Description = "Reefer #12" },
new Reefer { ReeferID = 13, Description = "Reefer #13" },
new Reefer { ReeferID = 14, Description = "Reefer #14" },
new Reefer { ReeferID = 15, Description = "Reefer #15" },
new Reefer { ReeferID = 16, Description = "Reefer #16" },
new Reefer { ReeferID = 17, Description = "Reefer #17" },
new Reefer { ReeferID = 18, Description = "Reefer #18" },
new Reefer { ReeferID = 19, Description = "Reefer #19" },
new Reefer { ReeferID = 20, Description = "Reefer #20" },
new Reefer { ReeferID = 21, Description = "Reefer #21" },
new Reefer { ReeferID = 22, Description = "Reefer #22" },
new Reefer { ReeferID = 23, Description = "Reefer #23" },
new Reefer { ReeferID = 24, Description = "Reefer #24" },
new Reefer { ReeferID = 25, Description = "Reefer #25" },
new Reefer { ReeferID = 26, Description = "Reefer #26" },
new Reefer { ReeferID = 27, Description = "Reefer #27" },
new Reefer { ReeferID = 28, Description = "Reefer #28" },
new Reefer { ReeferID = 29, Description = "Reefer #29" },
new Reefer { ReeferID = 30, Description = "Reefer #30" },
new Reefer { ReeferID = 31, Description = "Reefer #31" },
new Reefer { ReeferID = 32, Description = "Reefer #32" },
new Reefer { ReeferID = 33, Description = "Reefer #33" },
new Reefer { ReeferID = 34, Description = "Reefer #34" },
new Reefer { ReeferID = 35, Description = "Reefer #35" },
new Reefer { ReeferID = 36, Description = "Reefer #36" },
new Reefer { ReeferID = 37, Description = "Reefer #37" },
new Reefer { ReeferID = 38, Description = "Reefer #38" },
new Reefer { ReeferID = 39, Description = "Reefer #39" },
new Reefer { ReeferID = 40, Description = "Reefer #40" },
new Reefer { ReeferID = 41, Description = "Reefer #41" },
new Reefer { ReeferID = 42, Description = "Reefer #42" },
new Reefer { ReeferID = 43, Description = "Reefer #43" },
new Reefer { ReeferID = 44, Description = "Reefer #44" },
new Reefer { ReeferID = 45, Description = "Reefer #45" },
new Reefer { ReeferID = 46, Description = "Reefer #46" },
new Reefer { ReeferID = 47, Description = "Reefer #47" },
new Reefer { ReeferID = 48, Description = "Reefer #48" },
new Reefer { ReeferID = 49, Description = "Reefer #49" },
new Reefer { ReeferID = 50, Description = "Reefer #50" },
};
context.AddRange(reefres);
context.SaveChanges();





List<Driver> drivers = new List<Driver>
{
    new Driver { FirstName = "John", LastName = "Doe" },
    new Driver { FirstName = "Jane", LastName = "Smith" },
    new Driver { FirstName = "Michael", LastName = "Johnson" },
    new Driver { FirstName = "Emily", LastName = "Davis" },
    new Driver { FirstName = "Daniel", LastName = "Garcia" },
    new Driver { FirstName = "Sophia", LastName = "Martinez" },
    new Driver { FirstName = "William", LastName = "Rodriguez" },
    new Driver { FirstName = "Olivia", LastName = "Wilson" },
    new Driver { FirstName = "James", LastName = "Anderson" },
    new Driver { FirstName = "Isabella", LastName = "Thomas" },
    new Driver { FirstName = "Alexander", LastName = "Lee" },
    new Driver { FirstName = "Mia", LastName = "Perez" },
    new Driver { FirstName = "Benjamin", LastName = "Taylor" },
    new Driver { FirstName = "Charlotte", LastName = "Moore" },
    new Driver { FirstName = "Ethan", LastName = "Jackson" },
    new Driver { FirstName = "Amelia", LastName = "Martin" },
    new Driver { FirstName = "Logan", LastName = "Harris" },
    new Driver { FirstName = "Ava", LastName = "Clark" },
    new Driver { FirstName = "Mason", LastName = "Lewis" },
    new Driver { FirstName = "Harper", LastName = "Walker" },
    new Driver { FirstName = "Elijah", LastName = "Hall" },
    new Driver { FirstName = "Ella", LastName = "Allen" },
    new Driver { FirstName = "Liam", LastName = "Young" },
    new Driver { FirstName = "Grace", LastName = "King" },
    new Driver { FirstName = "Noah", LastName = "Scott" },
    new Driver { FirstName = "Aiden", LastName = "Green" },
    new Driver { FirstName = "Abigail", LastName = "Adams" },
    new Driver { FirstName = "Lucas", LastName = "Baker" },
    new Driver { FirstName = "Emily", LastName = "Carter" },
    new Driver { FirstName = "Oliver", LastName = "Nelson" },
    new Driver { FirstName = "Hannah", LastName = "Hill" },
    new Driver { FirstName = "Jacob", LastName = "Ramirez" },
    new Driver { FirstName = "Victoria", LastName = "Mitchell" },
    new Driver { FirstName = "Matthew", LastName = "Roberts" },
    new Driver { FirstName = "Chloe", LastName = "Phillips" },
    new Driver { FirstName = "Henry", LastName = "Campbell" },
    new Driver { FirstName = "Zoe", LastName = "Parker" },
    new Driver { FirstName = "Samuel", LastName = "Evans" },
    new Driver { FirstName = "Lily", LastName = "Edwards" },
    new Driver { FirstName = "David", LastName = "Collins" },
    new Driver { FirstName = "Avery", LastName = "Stewart" },
    new Driver { FirstName = "Joseph", LastName = "Sanchez" },
    new Driver { FirstName = "Samantha", LastName = "Morris" },
    new Driver { FirstName = "Gabriel", LastName = "Rogers" },
    new Driver { FirstName = "Sofia", LastName = "Reed" },
    new Driver { FirstName = "Jackson", LastName = "Cook" },
    new Driver { FirstName = "Mila", LastName = "Morgan" },
    new Driver { FirstName = "Sebastian", LastName = "Bell" },
    new Driver { FirstName = "Layla", LastName = "Murphy" },
    new Driver { FirstName = "Emma", LastName = "Patterson" }
};
context.AddRange(drivers);
context.SaveChanges();
List<Truck> trucks = new List<Truck>
{
new Truck { Description = "Truck #1" },
new Truck { Description = "Truck #2" },
new Truck { Description = "Truck #3" },
new Truck { Description = "Truck #4" },
new Truck { Description = "Truck #5" },
new Truck { Description = "Truck #6" },
new Truck { Description = "Truck #7" },
new Truck { Description = "Truck #8" },
new Truck { Description = "Truck #9" },
new Truck { Description = "Truck #10" },
new Truck { Description = "Truck #11" },
new Truck { Description = "Truck #12" },
new Truck { Description = "Truck #13" },
new Truck { Description = "Truck #14" },
new Truck { Description = "Truck #15" },
new Truck { Description = "Truck #16" },
new Truck { Description = "Truck #17" },
new Truck { Description = "Truck #18" },
new Truck { Description = "Truck #19" },
new Truck { Description = "Truck #20" },
new Truck { Description = "Truck #21" },
new Truck { Description = "Truck #22" },
new Truck { Description = "Truck #23" },
new Truck { Description = "Truck #24" },
new Truck { Description = "Truck #25" },
new Truck { Description = "Truck #26" },
new Truck { Description = "Truck #27" },
new Truck { Description = "Truck #28" },
new Truck { Description = "Truck #29" },
new Truck { Description = "Truck #30" },
new Truck { Description = "Truck #31" },
new Truck { Description = "Truck #32" },
new Truck { Description = "Truck #33" },
new Truck { Description = "Truck #34" },
new Truck { Description = "Truck #35" },
new Truck { Description = "Truck #36" },
new Truck { Description = "Truck #37" },
new Truck { Description = "Truck #38" },
new Truck { Description = "Truck #39" },
new Truck { Description = "Truck #40" },
new Truck { Description = "Truck #41" },
new Truck { Description = "Truck #42" },
new Truck { Description = "Truck #43" },
new Truck { Description = "Truck #44" },
new Truck { Description = "Truck #45" },
new Truck { Description = "Truck #46" },
new Truck { Description = "Truck #47" },
new Truck { Description = "Truck #48" },
new Truck { Description = "Truck #49" },
new Truck { Description = "Truck #50" },

};
context.AddRange(trucks);
context.SaveChanges();

List<TruckDriver> truckDrivers = new List<TruckDriver>
{
new TruckDriver { DriverID = 1, TruckID = 1 },
new TruckDriver { DriverID = 2, TruckID = 1 },
new TruckDriver { DriverID = 3, TruckID = 3 },
new TruckDriver { DriverID = 4, TruckID = 4 },
new TruckDriver { DriverID = 5, TruckID = 5 },
new TruckDriver { DriverID = 6, TruckID = 6 },
new TruckDriver { DriverID = 7, TruckID = 7 },
new TruckDriver { DriverID = 8, TruckID = 8 },
new TruckDriver { DriverID = 9, TruckID = 9 },
new TruckDriver { DriverID = 10, TruckID = 10 },
new TruckDriver { DriverID = 11, TruckID = 11 },
new TruckDriver { DriverID = 12, TruckID = 12 },
new TruckDriver { DriverID = 13, TruckID = 13 },
new TruckDriver { DriverID = 14, TruckID = 14 },
new TruckDriver { DriverID = 15, TruckID = 15 },
new TruckDriver { DriverID = 16, TruckID = 16 },
new TruckDriver { DriverID = 17, TruckID = 17 },
new TruckDriver { DriverID = 18, TruckID = 18 },
new TruckDriver { DriverID = 19, TruckID = 19 },
new TruckDriver { DriverID = 20, TruckID = 20 },
new TruckDriver { DriverID = 21, TruckID = 21 },
new TruckDriver { DriverID = 22, TruckID = 22 },
new TruckDriver { DriverID = 23, TruckID = 23 },
new TruckDriver { DriverID = 24, TruckID = 24 },
new TruckDriver { DriverID = 25, TruckID = 25 },
new TruckDriver { DriverID = 26, TruckID = 26 },
new TruckDriver { DriverID = 27, TruckID = 27 },
new TruckDriver { DriverID = 28, TruckID = 28 },
new TruckDriver { DriverID = 29, TruckID = 29 },
new TruckDriver { DriverID = 30, TruckID = 30 },
new TruckDriver { DriverID = 31, TruckID = 31 },
new TruckDriver { DriverID = 32, TruckID = 32 },
new TruckDriver { DriverID = 33, TruckID = 33 },
new TruckDriver { DriverID = 34, TruckID = 34 },
new TruckDriver { DriverID = 35, TruckID = 35 },
new TruckDriver { DriverID = 36, TruckID = 36 },
new TruckDriver { DriverID = 37, TruckID = 37 },
new TruckDriver { DriverID = 38, TruckID = 38 },
new TruckDriver { DriverID = 39, TruckID = 39 },
new TruckDriver { DriverID = 40, TruckID = 40 },
new TruckDriver { DriverID = 41, TruckID = 41 },
new TruckDriver { DriverID = 42, TruckID = 42 },
new TruckDriver { DriverID = 43, TruckID = 43 },
new TruckDriver { DriverID = 44, TruckID = 44 },
new TruckDriver { DriverID = 45, TruckID = 45 },
new TruckDriver { DriverID = 46, TruckID = 46 },
new TruckDriver { DriverID = 47, TruckID = 47 },
new TruckDriver { DriverID = 48, TruckID = 48 },
new TruckDriver { DriverID = 49, TruckID = 49 },
new TruckDriver { DriverID = 50, TruckID = 50 },

};
context.AddRange(truckDrivers);
context.SaveChanges();
}
}