using DataAccess.DataContext;
using DataAccess.Entities;
using DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDbContext context) : base(context) { }

        public new async Task<Employee> GetByIdAsync(int id)
        {
            return await _context.Employees
                .Include(x => x.WorkExperiences)
                .Include(x => x.Department)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Employee>> GetEmployeesWithWorkExperienceAsync()
        {
            return await _context.Employees
                                 .Include(e => e.WorkExperiences)
                                 .ThenInclude(we => we.ProgrammingLanguage)
                                 .Where(e => !e.IsDeleted)
                                 .ToListAsync();
        }

        public async Task<IEnumerable<Employee>> SearchEmployeesAsync(string searchTerm)
        {
            return await _context.Employees
                         .Where(e => string.IsNullOrEmpty(searchTerm) ||
                                      (e.FirstName.Contains(searchTerm) || e.LastName.Contains(searchTerm)))
                         .Where(e => !e.IsDeleted)
                         .ToListAsync();
        }
    }
}
