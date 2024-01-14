using Ksiegarnia.Data;
using Ksiegarnia.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks; // Dodaj using dla obsługi async/await

namespace Ksiegarnia
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30); // Ustaw czas bezczynności sesji
            });
            services.AddScoped<IBookRepository, BookRepository>();


        }

        public async void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSession();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseStaticFiles();

            // Uzyskaj dostęp do dostawcy usług (IServiceProvider) poprzez zbudowanie zakresu z serwisów.
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;

                var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                var userManager = serviceProvider.GetRequiredService<UserManager<User>>();

                string[] roleNames = { "Administrator", "Użytkownik" };

                IdentityResult roleResult;

                foreach (var roleName in roleNames)
                {
                    var roleExist = await roleManager.RoleExistsAsync(roleName);
                    if (!roleExist)
                    {
                        roleResult = await roleManager.CreateAsync(new IdentityRole(roleName));
                    }
                }

               User user = await userManager.FindByEmailAsync("admin@example.com");

                if (user == null)
                {
                    user = new User()
                    {
                        UserName = "admin@example.com",
                        Email = "admin@example.com",
                    };
                    await userManager.CreateAsync(user, "Admin@123");
                }
                await userManager.AddToRoleAsync(user, "Administrator");
            }
        }
    }
}
