using DeliverCompany.Models;
using Microsoft.AspNetCore.Identity;

public class IdentitySeeder
{
    public static async Task SeedRolesAndUsersAsync(IServiceProvider serviceProvider)
    {
        var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
        var userManager = serviceProvider.GetRequiredService<UserManager<Employee>>();

        // Skapa rollerna Admin och Employee om de inte finns
        string[] roleNames = { "Admin", "Employee" };
        IdentityResult roleResult;

        foreach (var roleName in roleNames)
        {
            var roleExists = await roleManager.RoleExistsAsync(roleName);
            if (!roleExists)
            {
                roleResult = await roleManager.CreateAsync(new IdentityRole(roleName));
            }
        }

        // Skapa användarna med rätt e-post och lösenord
        await CreateEmployeeIfNotExists(userManager, "admin@example.com", "Admin User", "admin123", "Admin");
        await CreateEmployeeIfNotExists(userManager, "john@example.com", "John Doe", "password123", "Employee");
        await CreateEmployeeIfNotExists(userManager, "jane@example.com", "Jane Doe", "password123", "Employee");
        await CreateEmployeeIfNotExists(userManager, "tom@example.com", "Tom Hardy", "password123", "Employee");
        await CreateEmployeeIfNotExists(userManager, "emily@example.com", "Emily Davis", "password123", "Employee");
        await CreateEmployeeIfNotExists(userManager, "sophia@example.com", "Sophia Turner", "password123", "Employee");
        await CreateEmployeeIfNotExists(userManager, "luke@example.com", "Luke Perry", "password123", "Employee");
    }

    private static async Task CreateEmployeeIfNotExists(UserManager<Employee> userManager, string email, string name, string password, string role)
    {
        if (await userManager.FindByEmailAsync(email) == null)
        {
            var user = new Employee
            {
                UserName = email,
                Email = email,
                Name = name
            };

            var result = await userManager.CreateAsync(user, password);
            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(user, role);
            }
        }
    }
}
