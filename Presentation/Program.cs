using BusinessLogic.Authentication;
using BusinessLogic.Interfaces;
using BusinessLogic.Services;
using BusinessLogic.Utilities;
using DataAccess.DataContext;
using DataAccess.Interfaces;
using DataAccess.Repositories;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Presentation.Utilities;

namespace Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            builder.Services.AddScoped<IProgrammingLanguageRepository, ProgrammingLanguageRepository>();
            builder.Services.AddScoped<IWorkExperienceRepository, WorkExperienceRepository>();
            builder.Services.AddScoped<IUserRepository, UserRepository>();

            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IEmployeeService, EmployeeService>();
            builder.Services.AddScoped<IDepartmentService, DepartmentService>();
            builder.Services.AddScoped<IProgrammingLanguageService, ProgrammingLanguageService>();

            builder.Services.AddScoped<IPasswordHasher, PasswordHasher>();

            builder.Services.AddControllersWithViews();

            builder.Services.AddBusinessLogicProfiles(); 
            builder.Services.AddPresentationProfiles();

            builder.Services.AddAuthentication()
                            .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>(BasicAuthenticationDefaults.AuthenticationScheme, null);

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseAuthentication();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Employee}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
