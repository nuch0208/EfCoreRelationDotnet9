namespace EfCoreRelationDotnet9.Models
{
    public class Post
    {
        public int Id {get; set;}
        public string? Content { get; set; }
        public Blog? Blog { get; set; }
        public int BlogId { get; set; }
    }
}