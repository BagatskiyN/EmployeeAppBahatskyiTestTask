using BusinessLogic.Dtos;

namespace BusinessLogic.Interfaces
{
    public interface IProgrammingLanguageService
    {
        Task<IEnumerable<ProgrammingLanguageDto>> GetAllAsync();
    }
}
