using System.ComponentModel.DataAnnotations;

namespace UniversityExplorer.Models
{
    public class StudentApplication
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Student name is required.")]
        public string StudentName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Enter a valid email address.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Country is required.")]
        public string Country { get; set; } = string.Empty;

        [Required(ErrorMessage = "University is required.")]
        public string University { get; set; } = string.Empty;

        [Required(ErrorMessage = "Course is required.")]
        public string Course { get; set; } = string.Empty;

        public string PersonalStatement { get; set; } = string.Empty;
    }
}