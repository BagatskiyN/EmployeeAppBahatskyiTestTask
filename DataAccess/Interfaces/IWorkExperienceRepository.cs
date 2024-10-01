using DataAccess.Entities;

namespace DataAccess.Interfaces
{
    public interface IWorkExperienceRepository : IRepository<WorkExperience>
    {
        Task<IEnumerable<WorkExperience>> GetWorkExperienceForEmployeeAsync(int employeeId);
    }
}
