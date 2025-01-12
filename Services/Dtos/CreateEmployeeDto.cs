﻿namespace BusinessLogic.Dtos
{
    public class CreateEmployeeDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int DepartmentId { get; set; }
        public List<int> ProgrammingLanguageIds { get; set; }
    }
}
