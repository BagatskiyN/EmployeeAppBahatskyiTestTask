using AutoMapper;
using BusinessLogic.Dtos;
using DataAccess.Entities;

namespace BusinessLogic.MappingProfiles
{
    public class ProgrammingLanguageProfile : Profile
    {
        public ProgrammingLanguageProfile()
        {
            CreateMap<ProgrammingLanguage, ProgrammingLanguageDto>().ReverseMap();
        }
    }
}
