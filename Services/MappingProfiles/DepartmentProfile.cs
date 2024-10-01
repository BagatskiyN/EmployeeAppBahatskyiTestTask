using AutoMapper;
using BusinessLogic.Dtos;
using DataAccess.Entities;

namespace BusinessLogic.MappingProfiles
{
    public class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            CreateMap<Department, DepartmentDto>().ReverseMap();
        }
    }
}
