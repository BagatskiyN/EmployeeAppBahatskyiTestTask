using AutoMapper;
using BusinessLogic.Dtos;
using Presentation.Models;
using Presentation.Models.Requests;

namespace Presentation.MappingProfiles
{
    public class EmployeeMappingProfile : Profile
    {
        public EmployeeMappingProfile()
        {
            CreateMap<EmployeeDto, EmployeeViewModel>().ReverseMap();
            CreateMap<EmployeeDto, UpdateEmployeeRequest>().ReverseMap();
            CreateMap<CreateEmployeeDto, CreateEmployeeRequest>().ReverseMap();
        }
    }
}
