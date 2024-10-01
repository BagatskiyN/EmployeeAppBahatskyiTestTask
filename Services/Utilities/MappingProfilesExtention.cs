using BusinessLogic.MappingProfiles;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLogic.Utilities
{
    public static class MappingProfilesExtention
    {
        public static void AddBusinessLogicProfiles(this IServiceCollection services)
        {
            services.AddAutoMapper(cfg =>
            {
                cfg.AddProfile<DepartmentProfile>();
                cfg.AddProfile<EmployeeProfile>();
                cfg.AddProfile<UserProfile>();
                cfg.AddProfile<ProgrammingLanguageProfile>();
            });
        }
    }
}
