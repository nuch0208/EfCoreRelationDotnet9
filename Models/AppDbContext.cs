using Microsoft.EntityFrameworkCore;

namespace EfCoreRelationDotnet9.Models;
public class AppDbContext(DbContextOptions<AppDbContext> options)  : DbContext (options)
    {
    public DbSet<User> Users => Set<User>();
    public DbSet<Profile> Profiles => Set<Profile>();
    public DbSet<Blog> Blogs => Set<Blog>();
    public DbSet<Post> Posts => Set<Post>();
    public DbSet<Student> Students => Set<Student>();
    public DbSet<Course> Courses => Set<Course>();
    public DbSet<CourseStudent> CourseStudents => Set<CourseStudent>();
    } 