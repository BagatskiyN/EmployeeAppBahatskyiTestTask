using DataAccess.DataContext;
using DataAccess.Entities;
using DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(ApplicationDbContext context) : base(context) { }

        public async Task<Department> GetDepartmentWithEmployeesAsync(int departmentId)
        {
            return await _context.Departments
                                 .Include(d => d.Employees)
                                 .FirstOrDefaultAsync(d => d.Id == departmentId);
        }
    }
}
