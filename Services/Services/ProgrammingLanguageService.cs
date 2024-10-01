using AutoMapper;
using BusinessLogic.Dtos;
using BusinessLogic.Interfaces;
using DataAccess.Interfaces;

namespace BusinessLogic.Services
{
    public class ProgrammingLanguageService : IProgrammingLanguageService
    {
        private readonly IProgrammingLanguageRepository _programmingLanguageRepository;
        private readonly IMapper _mapper;

        public ProgrammingLanguageService(IProgrammingLanguageRepository programmingLanguageRepository, IMapper mapper)
        {
            _programmingLanguageRepository = programmingLanguageRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProgrammingLanguageDto>> GetAllAsync()
        {
            var programmingLanguages = await _programmingLanguageRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<ProgrammingLanguageDto>>(programmingLanguages);
        }
    }
}
