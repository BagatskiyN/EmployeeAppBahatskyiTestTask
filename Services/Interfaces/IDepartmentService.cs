using BusinessLogic.Dtos;

namespace BusinessLogic.Interfaces
{
    public interface IDepartmentService
    {
        Task<IEnumerable<DepartmentDto>> GetAllAsync();
    }
}
