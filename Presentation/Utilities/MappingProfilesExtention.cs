using Presentation.MappingProfiles;
using AutoMapper;

namespace Presentation.Utilities
{
    public static class MappingProfilesExtention
    {
        public static void AddPresentationProfiles(this IServiceCollection services)
        {
            services.AddAutoMapper(cfg =>
            {
                cfg.AddProfile<EmployeeMappingProfile>();
            });
        }
    }
}
