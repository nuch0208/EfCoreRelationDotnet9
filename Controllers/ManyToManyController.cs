using EfCoreRelationDotnet9.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace EfCoreRelationDotnet9.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ManyToManyController(AppDbContext context) : ControllerBase
    {
        [HttpPost("add-student")]
        public async Task<IActionResult> CreateBlog(Student student)
        {
            context.Students.Add(student);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("get-students")]
        public async Task<IActionResult> GetStudent()
        {
            return Ok(await context.Students.Include(x => x.CoursesStudents).ToListAsync());
        }
        [HttpPost("add-course")]
        public async Task<IActionResult> CreateCourse(Course course)
        {
            context.Courses.Add(course);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("get-course")]
        public async Task<IActionResult> GetCourses()
        {
            return Ok(await context.Courses.Include(x => x.CoursesStudents).ToListAsync());
        }

        [HttpPost("add-course-student")]
        public async Task<IActionResult> CreateStudentCourse(CourseStudent studentCourse)
        {
            context.CourseStudents.Add(studentCourse);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("get-courses-student")]
        public async Task<IActionResult> GetStudentCourses()
        {
            return Ok(await context.CourseStudents.Include(x => x.Course).Include(x => x.Student).ToListAsync());
        }
    }
}