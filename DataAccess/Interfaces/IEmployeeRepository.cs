using DataAccess.Entities;

namespace DataAccess.Interfaces
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Task<IEnumerable<Employee>> GetEmployeesWithWorkExperienceAsync();

        Task<IEnumerable<Employee>> SearchEmployeesAsync(string searchTerm);
    }
}
