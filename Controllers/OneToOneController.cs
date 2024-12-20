using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;
using EfCoreRelationDotnet9.Models;
using Microsoft.EntityFrameworkCore;


namespace EfCoreRelationDotnet9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OneToOneController(AppDbContext context) : ControllerBase
    {
    
        [HttpPost("add-user")]
        public async Task<IActionResult> CreateUser(User user)
        {
            context.Users.Add(user);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("get-users")]
        public async Task<IActionResult> GetUser()
        {
            return Ok(await context.Users.Include(x => x.Profile).ToListAsync());
        }

        [HttpPost("add-profile")]
        public async Task<IActionResult> CreateProfile(Profile profile)
        {
            context.Profiles.Add(profile);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("get-Profile")]
        public async Task<IActionResult> GetProfiles()
        {
            return Ok(await context.Profiles.Include(x => x.User).ToListAsync());
        }
    }
    
}