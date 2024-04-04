
using System.ComponentModel.DataAnnotations;

namespace Web2_02.Models
{
    public class Courses
    {
        [Key]
        public int CourseId { get; set; }
        public string? CourseName { get; set; }
        public string? Description { get; set; }
        public List<StudentCourses>? StudentCourses { get; set; }
    }
}
