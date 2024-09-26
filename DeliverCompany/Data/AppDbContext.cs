using DeliverCompany.Models;
using Microsoft.EntityFrameworkCore;

namespace DeliverCompany.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Event> Events { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    Name = "Admin User",
                    Email = "admin@example.com",
                    Password = "admin123",
                    Role = "Admin"
                },
                new Employee
                {
                    EmployeeId = 2,
                    Name = "John Doe",
                    Email = "john@example.com",
                    Password = "password123",
                    Role = "Employee"
                }
            );

            // Seed data for Driver
            modelBuilder.Entity<Driver>().HasData(
                new Driver
                {
                    DriverID = 1,
                    DriverName = "Alice Smith",
                    CarReg = "ABC123",
                    NoteDate = DateTime.Now.AddDays(-1),
                    NoteDescription = "Completed delivery route",
                    ResponsibleEmployee = "John Doe",
                    BeloppUt = 200.00M,
                    BeloppIn = 500.00M,
                    TotalBeloppUt = 200.00M,
                    TotalBeloppIn = 500.00M
                },
                new Driver
                {
                    DriverID = 2,
                    DriverName = "Bob Johnson",
                    CarReg = "XYZ789",
                    NoteDate = DateTime.Now.AddDays(-2),
                    NoteDescription = "Vehicle maintenance",
                    ResponsibleEmployee = "Admin User",
                    BeloppUt = 100.00M,
                    BeloppIn = 0.00M,
                    TotalBeloppUt = 100.00M,
                    TotalBeloppIn = 0.00M
                }
            );

            // Seed data for Event
            modelBuilder.Entity<Event>().HasData(
                new Event
                {
                    EventID = 1,
                    NoteDate = DateTime.Now.AddDays(-1),
                    NoteDescription = "Delivered goods to customer",
                    BeloppIn = 400.00M,
                    BeloppUt = 50.00M,
                    DriverID = 1 // Kopplad till Alice Smith
                },
                new Event
                {
                    EventID = 2,
                    NoteDate = DateTime.Now.AddDays(-2),
                    NoteDescription = "Vehicle repaired",
                    BeloppIn = 0.00M,
                    BeloppUt = 300.00M,
                    DriverID = 2 // Kopplad till Bob Johnson
                },
                new Event
                {
                    EventID = 3,
                    NoteDate = DateTime.Now.AddDays(-3),
                    NoteDescription = "Picked up supplies",
                    BeloppIn = 0.00M,
                    BeloppUt = 100.00M,
                    DriverID = 1 // Kopplad till Alice Smith
                }
            );
        }

    }
}