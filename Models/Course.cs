namespace EfCoreRelationDotnet9.Models
{
    public class Course
    {
        public  int  Id { get; set; }
        public string? Title { get; set; }
        public ICollection<CourseStudent>? CoursesStudents { get; set; }

    }
}