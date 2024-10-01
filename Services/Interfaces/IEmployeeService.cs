using BusinessLogic.Dtos;

namespace BusinessLogic.Interfaces
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDto>> GetAllAsync(string searchTerm);
        Task<EmployeeDto> GetByIdAsync(int id);
        Task CreateAsync(CreateEmployeeDto createEmployeeDto);
        Task UpdateAsync(UpdateEmployeeDto updateEmployeeDto);
        Task SoftDeleteAsync(int id);
    }
}
