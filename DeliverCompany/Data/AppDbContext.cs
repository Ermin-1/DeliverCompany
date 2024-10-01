using Microsoft.EntityFrameworkCore;
using DeliverCompany.Models;

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

            // Seed data for Drivers
            modelBuilder.Entity<Driver>().HasData(
                new Driver { DriverID = 1, DriverName = "Alice Smith", CarReg = "ABC123", NoteDate = DateTime.Now.AddDays(-1), NoteDescription = "Completed delivery route", ResponsibleEmployee = "John Doe", BeloppIn = 500.00m, BeloppUt = 200.00m, TotalBeloppIn = 500.00m, TotalBeloppUt = 200.00m },
                new Driver { DriverID = 2, DriverName = "Bob Johnson", CarReg = "XYZ789", NoteDate = DateTime.Now.AddDays(-2), NoteDescription = "Vehicle maintenance", ResponsibleEmployee = "Admin User", BeloppIn = 0.00m, BeloppUt = 100.00m, TotalBeloppIn = 0.00m, TotalBeloppUt = 100.00m },
                new Driver { DriverID = 3, DriverName = "Michael Brown", CarReg = "LMN456", NoteDate = DateTime.Now.AddDays(-3), NoteDescription = "Delivered groceries", ResponsibleEmployee = "Jane Doe", BeloppIn = 400.00m, BeloppUt = 150.00m, TotalBeloppIn = 400.00m, TotalBeloppUt = 150.00m },
                new Driver { DriverID = 4, DriverName = "Emma Wilson", CarReg = "JKL789", NoteDate = DateTime.Now.AddDays(-4), NoteDescription = "Completed overnight delivery", ResponsibleEmployee = "Tom Hardy", BeloppIn = 600.00m, BeloppUt = 200.00m, TotalBeloppIn = 600.00m, TotalBeloppUt = 200.00m },
                new Driver { DriverID = 5, DriverName = "Oliver Martinez", CarReg = "OPQ123", NoteDate = DateTime.Now.AddDays(-5), NoteDescription = "Completed furniture delivery", ResponsibleEmployee = "Emily Davis", BeloppIn = 700.00m, BeloppUt = 300.00m, TotalBeloppIn = 700.00m, TotalBeloppUt = 300.00m },
                new Driver { DriverID = 6, DriverName = "Lucas Green", CarReg = "RST456", NoteDate = DateTime.Now.AddDays(-6), NoteDescription = "Delivered medical supplies", ResponsibleEmployee = "Sophia Turner", BeloppIn = 1000.00m, BeloppUt = 400.00m, TotalBeloppIn = 1000.00m, TotalBeloppUt = 400.00m },
                new Driver { DriverID = 7, DriverName = "Liam White", CarReg = "UVW789", NoteDate = DateTime.Now.AddDays(-7), NoteDescription = "Delivered electronics", ResponsibleEmployee = "Luke Perry", BeloppIn = 1200.00m, BeloppUt = 500.00m, TotalBeloppIn = 1200.00m, TotalBeloppUt = 500.00m }
            );

            // Seed data for Employees
            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmployeeId = 1, Name = "Admin User", Email = "admin@example.com", Password = "admin123", Role = "Admin" },
                new Employee { EmployeeId = 2, Name = "John Doe", Email = "john@example.com", Password = "password123", Role = "Employee" },
                new Employee { EmployeeId = 3, Name = "Jane Doe", Email = "jane@example.com", Password = "password123", Role = "Employee" },
                new Employee { EmployeeId = 4, Name = "Tom Hardy", Email = "tom@example.com", Password = "hardy123", Role = "Employee" },
                new Employee { EmployeeId = 5, Name = "Emily Davis", Email = "emily@example.com", Password = "davis123", Role = "Employee" },
                new Employee { EmployeeId = 6, Name = "Sophia Turner", Email = "sophia@example.com", Password = "turner123", Role = "Employee" },
                new Employee { EmployeeId = 7, Name = "Luke Perry", Email = "luke@example.com", Password = "perry123", Role = "Employee" }
            );

            // Seed data for Events
            modelBuilder.Entity<Event>().HasData(
                new Event { EventID = 1, BeloppIn = 400.00m, BeloppUt = 50.00m, DriverID = 1, NoteDate = DateTime.Now.AddDays(-1), NoteDescription = "Delivered goods to customer" },
                new Event { EventID = 2, BeloppIn = 0.00m, BeloppUt = 300.00m, DriverID = 2, NoteDate = DateTime.Now.AddDays(-2), NoteDescription = "Vehicle repaired" },
                new Event { EventID = 3, BeloppIn = 0.00m, BeloppUt = 100.00m, DriverID = 1, NoteDate = DateTime.Now.AddDays(-3), NoteDescription = "Picked up supplies" },
                new Event { EventID = 4, BeloppIn = 400.00m, BeloppUt = 50.00m, DriverID = 3, NoteDate = DateTime.Now.AddDays(-4), NoteDescription = "Delivered groceries" },
                new Event { EventID = 5, BeloppIn = 600.00m, BeloppUt = 100.00m, DriverID = 4, NoteDate = DateTime.Now.AddDays(-5), NoteDescription = "Completed overnight delivery" },
                new Event { EventID = 6, BeloppIn = 700.00m, BeloppUt = 150.00m, DriverID = 5, NoteDate = DateTime.Now.AddDays(-6), NoteDescription = "Furniture delivered" },
                new Event { EventID = 7, BeloppIn = 1000.00m, BeloppUt = 200.00m, DriverID = 6, NoteDate = DateTime.Now.AddDays(-7), NoteDescription = "Delivered medical supplies" },
                new Event { EventID = 8, BeloppIn = 1200.00m, BeloppUt = 300.00m, DriverID = 7, NoteDate = DateTime.Now.AddDays(-8), NoteDescription = "Delivered electronics" }
            );
        }
    }
}
