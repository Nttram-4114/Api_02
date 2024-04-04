using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Web2_02.Models
{
    public class StudentCourses
    {
        public Students? Student { get; set; }
        [Key]
        public int StudentId { get; set; }
        public Courses? Courses { get; set; }
        [Key]
        public int CoursesId { get; set; }
    }
}

