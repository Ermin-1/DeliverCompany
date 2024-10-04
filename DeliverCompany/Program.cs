using DeliverCompany.Data;
using DeliverCompany.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;

namespace DeliverCompany
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // Configure the database context
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("Connection")));

            builder.Services.AddLogging();


            //Configure RazorPages
            builder.Services.AddRazorPages();

            // Configure Identity services for Employee and IdentityRole
            builder.Services.AddIdentity<Employee, IdentityRole>(options =>
            {
                options.SignIn.RequireConfirmedAccount = true;
            })
            .AddEntityFrameworkStores<AppDbContext>()
            .AddDefaultTokenProviders();

            // Configure Identity services for Employee and IdentityRole
            builder.Services.ConfigureApplicationCookie(OptionsBuilderConfigurationExtensions =>
            {
                OptionsBuilderConfigurationExtensions.LoginPath = "/Identity/Account/Login";
                OptionsBuilderConfigurationExtensions.AccessDeniedPath = "/Identity/Account/AccessDenied";
            });

            // Add IHttpContextAccessor
            builder.Services.AddHttpContextAccessor();

            builder.Services.AddSingleton<IEmailSender, DummyEmailSender>(); 


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            // Seed roles and users
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                await IdentitySeeder.SeedRolesAndUsersAsync(services);
            }

            app.MapRazorPages();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
