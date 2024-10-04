using DeliverCompany.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

public class IdentitySeeder
{
    public static async Task SeedRolesAndUsersAsync(IServiceProvider serviceProvider)
    {
        var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
        var userManager = serviceProvider.GetRequiredService<UserManager<Employee>>();
        var logger = serviceProvider.GetRequiredService<ILogger<IdentitySeeder>>();

        // Skapa rollerna Admin och Employee om de inte finns
        string[] roleNames = { "Admin", "Employee" };
        IdentityResult roleResult;

        foreach (var roleName in roleNames)
        {
            var roleExists = await roleManager.RoleExistsAsync(roleName);
            if (!roleExists)
            {
                roleResult = await roleManager.CreateAsync(new IdentityRole(roleName));
                if (roleResult.Succeeded)
                {
                    logger.LogInformation($"Role '{roleName}' created successfully.");
                }
                else
                {
                    logger.LogError($"Error creating role '{roleName}': {string.Join(", ", roleResult.Errors.Select(e => e.Description))}");
                }
            }
        }

        // Skapa användarna med rätt e-post och lösenord
        await CreateEmployeeIfNotExists(userManager, logger, "admin@example.com", "Admin User", "Admin@12345", "Admin");
        await CreateEmployeeIfNotExists(userManager, logger, "john@example.com", "John Doe", "JohnDoe@12345", "Employee");
        await CreateEmployeeIfNotExists(userManager, logger, "jane@example.com", "Jane Doe", "JaneDoe@12345", "Employee");
        await CreateEmployeeIfNotExists(userManager, logger, "tom@example.com", "Tom Hardy", "TomHardy@12345", "Employee");
        await CreateEmployeeIfNotExists(userManager, logger, "emily@example.com", "Emily Davis", "EmilyDavis@12345", "Employee");
        await CreateEmployeeIfNotExists(userManager, logger, "sophia@example.com", "Sophia Turner", "SophiaTurner@12345", "Employee");
        await CreateEmployeeIfNotExists(userManager, logger, "luke@example.com", "Luke Perry", "LukePerry@12345", "Employee");
    }

    private static async Task ResetUserPassword(UserManager<Employee> userManager, Employee user, string newPassword)
    {
        var token = await userManager.GeneratePasswordResetTokenAsync(user);
        var result = await userManager.ResetPasswordAsync(user, token, newPassword);

        if (!result.Succeeded)
        {
            throw new Exception($"Failed to reset password: {string.Join(", ", result.Errors.Select(e => e.Description))}");
        }
    }

    private static async Task CreateEmployeeIfNotExists(UserManager<Employee> userManager, ILogger logger, string email, string name, string password, string role)
    {
        var user = await userManager.FindByEmailAsync(email);
        if (user == null)
        {
            user = new Employee
            {
                UserName = email,
                Email = email,
                Name = name,
                EmailConfirmed = true, // Gör att användaren kan logga in direkt utan att bekräfta e-post
                NormalizedEmail = email.ToUpper(),
                NormalizedUserName = email.ToUpper()

            };

            var result = await userManager.CreateAsync(user, password);
            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(user, role);
                logger.LogInformation($"User '{email}' created successfully and assigned to role '{role}'.");
            }
            else
            {
                logger.LogError($"Error creating user '{email}': {string.Join(", ", result.Errors.Select(e => e.Description))}");
            }
        }
        else
        {
            logger.LogInformation($"User '{email}' already exists. Resetting password.");
            await ResetUserPassword(userManager, user, password);
            await userManager.AddToRoleAsync(user, role);
        }
    }
}
