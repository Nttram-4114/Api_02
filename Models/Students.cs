using System.ComponentModel.DataAnnotations;

namespace Web2_02.Models
{
    public class Students
    {
        [Key]
        public Guid? StudentId { get; set; }
        public string? Name { get; set; }
        public List<StudentCourses>? StudentCourses { get; set; }
    }
}
