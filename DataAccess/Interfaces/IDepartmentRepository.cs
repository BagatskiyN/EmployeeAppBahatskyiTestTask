using DataAccess.Entities;

namespace DataAccess.Interfaces
{
    public interface IDepartmentRepository : IRepository<Department>
    {
        Task<Department> GetDepartmentWithEmployeesAsync(int departmentId);
    }
}
