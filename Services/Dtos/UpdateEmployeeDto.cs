namespace BusinessLogic.Dtos
{
    public class UpdateEmployeeDto
    {
        public int Id { get; set; }  

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public int DepartmentId { get; set; }

        public List<int> ProgrammingLanguageIds { get; set; }
    }
}
