using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public string FullName => $"{FirstName} {LastName}";

        public string Email { get; set; } = null!;
        public int Phone { get; set; }

    }
}
