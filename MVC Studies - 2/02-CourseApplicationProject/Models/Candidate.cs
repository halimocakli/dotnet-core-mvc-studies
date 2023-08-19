using System.ComponentModel.DataAnnotations;

namespace _02_CourseApplicationProject.Models
{
    public class Candidate
    {
        [Required(ErrorMessage = "E-Mail information is required.")]
        public string? Email { get; set; } = String.Empty;

        [Required(ErrorMessage = "Name information is required.")]
        public string? FirstName { get; set; } = String.Empty;

        [Required(ErrorMessage = "Surname information is required.")]
        public string? LastName { get; set; } = String.Empty;
        
        public string? FullName => $"{FirstName} {LastName?.ToUpper()}";
        public int? Age { get; set; }
        public string? SelectedCourse { get; set; } = String.Empty;
        public DateTime ApplicationDate { get; set; }

        public Candidate()
        {
            ApplicationDate = DateTime.Now;
        }
    }
}