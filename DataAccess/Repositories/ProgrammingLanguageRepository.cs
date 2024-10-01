using DataAccess.DataContext;
using DataAccess.Entities;
using DataAccess.Interfaces;

namespace DataAccess.Repositories
{
    public class ProgrammingLanguageRepository : Repository<ProgrammingLanguage>, IProgrammingLanguageRepository
    {
        public ProgrammingLanguageRepository(ApplicationDbContext context) : base(context) { }
    }
}
