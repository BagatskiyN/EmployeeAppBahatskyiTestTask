namespace Presentation.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public int DepartmentId { get; set; }

        public string DepartmentName { get; set; }

        public List<int> ProgrammingLanguageIds { get; set; }

        public List<string> ProgrammingLanguages { get; set; }
    }
}
