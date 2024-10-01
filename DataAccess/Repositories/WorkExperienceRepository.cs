using DataAccess.DataContext;
using DataAccess.Entities;
using DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class WorkExperienceRepository : Repository<WorkExperience>, IWorkExperienceRepository
    {
        public WorkExperienceRepository(ApplicationDbContext context) : base(context) { }

        public async Task<IEnumerable<WorkExperience>> GetWorkExperienceForEmployeeAsync(int employeeId)
        {
            return await _context.WorkExperiences
                                 .Where(we => we.EmployeeId == employeeId)
                                 .Include(we => we.ProgrammingLanguage)
                                 .ToListAsync();
        }
    }
}