using EfCoreRelationDotnet9.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace EfCoreRelationDotnet9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OneToManyController(AppDbContext context) : ControllerBase
    {
        [HttpPost("add-blog")]
        public async Task<IActionResult> CreateBlog(Blog blog)
        {
            context.Blogs.Add(blog);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("get-blogs")]
        public async Task<IActionResult> GetBlog()
        {
            return Ok(await context.Blogs.Include(x=>x.Posts).ToArrayAsync());
        }

        [HttpPost("add-post")]
        public async Task<IActionResult> CreatePost(Post post)
        {
            context.Posts.Add(post);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("get-post")]
        public async Task<IActionResult> GetPost()
        {
            return Ok(await context.Posts.Include(x=>x.Blog).ToArrayAsync());
        }
        
    }
}

