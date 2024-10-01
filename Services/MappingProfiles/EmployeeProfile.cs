using AutoMapper;
using BusinessLogic.Dtos;
using DataAccess.Entities;

namespace BusinessLogic.MappingProfiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeDto>()
            .ForMember(dest => dest.ProgrammingLanguageIds, opt => opt.MapFrom(src =>
                src.WorkExperiences.Select(we => we.ProgrammingLanguageId).ToList()
            ))
            .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src =>
                src.Department != null ? src.Department.Name : null
            ));

            CreateMap<CreateEmployeeDto, Employee>()
           .ForMember(dest => dest.WorkExperiences, opt => opt.MapFrom(src =>
               src.ProgrammingLanguageIds.Select(id => new WorkExperience
               {
                   ProgrammingLanguageId = id,
               }).ToList()
           ));

            CreateMap<UpdateEmployeeDto, Employee>()
            .ForMember(dest => dest.WorkExperiences, opt => opt.MapFrom(src =>
                src.ProgrammingLanguageIds.Select(id => new WorkExperience
                {
                    ProgrammingLanguageId = id,
                    EmployeeId = src.Id
                }).ToList()
            ))
            .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.DepartmentId));
        }
    }
}
