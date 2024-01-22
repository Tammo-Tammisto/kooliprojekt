using KooliProjekt.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

#if (DEBUG)
            using (var scope = app.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                dbContext.Database.Migrate();

                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

                IdentityUser user = new();
                user.UserName = "aidake-mind@tim.ee";
                user.EmailConfirmed = true;
                user.PasswordHash = userManager.PasswordHasher.HashPassword(user, "KristiTerroriseerib");

                userManager.CreateAsync(user).Wait();

                if (dbContext.Project.Count() == 0)
                {
                    Project project = new();

                    project.Id = "1";
                    project.ProjectName = "Projekt #1";
                    project.Start = "23.10.2023";
                    project.Deadline = "23.01.2024";
                    project.Budget = "100000";
                    project.HourlyRate = "100";
                    project.Team = "Team #1";

                    dbContext.Add(project);
                    dbContext.SaveChanges();
                }
            }
#endif

            app.Run();
        }
    }
}