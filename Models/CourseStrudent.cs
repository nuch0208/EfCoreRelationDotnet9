namespace EfCoreRelationDotnet9.Models
{
    public class CourseStudent
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; } 
        public Student? Student { get; set; }
        public Course?  Course { get; set; }

    }
}