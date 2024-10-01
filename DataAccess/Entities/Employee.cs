namespace DataAccess.Entities
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public int DepartmentId { get; set; }

        public Department Department { get; set; }

        public bool IsDeleted { get; set; }

        public ICollection<WorkExperience> WorkExperiences { get; set; }
    }
}
