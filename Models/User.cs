 namespace EfCoreRelationDotnet9.Models;
 public class User
    {
        public int Id { get; set; }
        public string? Username { get; set; }   
        public Profile? Profile { get; set; }
    }



    