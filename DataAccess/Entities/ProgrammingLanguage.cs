namespace DataAccess.Entities
{
    public class ProgrammingLanguage : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<WorkExperience> WorkExperiences { get; set; }
    }
}
