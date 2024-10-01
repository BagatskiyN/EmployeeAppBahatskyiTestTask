namespace DataAccess.Entities
{
    public class WorkExperience : BaseEntity
    {
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        public int ProgrammingLanguageId { get; set; }

        public ProgrammingLanguage ProgrammingLanguage { get; set; }
    }
}
