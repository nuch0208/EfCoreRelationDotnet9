using System.Runtime.ConstrainedExecution;

namespace EfCoreRelationDotnet9.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public ICollection<CourseStudent>? CoursesStudents { get; set; }
    }
}