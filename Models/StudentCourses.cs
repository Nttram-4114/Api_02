using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Web2_02.Models
{
    public class StudentCourses
    {
        public Students? Student { get; set; }
        public Guid? StudentId { get; set; }
        public Courses? Courses { get; set; }
        public Guid? CoursesId { get; set; }
    }
}

