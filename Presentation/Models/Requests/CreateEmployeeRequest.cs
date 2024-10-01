using System.ComponentModel.DataAnnotations;

namespace Presentation.Models.Requests
{
    public class CreateEmployeeRequest
    {
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "First name must be between 2 and 50 characters.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Last name must be between 2 and 50 characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        [RegularExpression("^(Male|Female|Other)$", ErrorMessage = "Gender must be Male, Female, or Other.")]
        public string Gender { get; set; }

        [Range(0, 150, ErrorMessage = "Age must be between 0 and 150.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "DepartmentId is required.")]
        public int DepartmentId { get; set; }

        public List<int> ProgrammingLanguageIds { get; set; }
    }
}