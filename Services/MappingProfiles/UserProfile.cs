using AutoMapper;
using BusinessLogic.Dtos;
using DataAccess.Entities;

namespace BusinessLogic.MappingProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, CreateUserDto>().ReverseMap();
        }
    }
}
