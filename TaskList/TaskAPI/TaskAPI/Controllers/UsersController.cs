using Microsoft.AspNetCore.Mvc;
using TaskAPI.Models;

namespace TaskAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : BaseController
    {
        public UsersController(TaskDBContext dbContext) : base (dbContext)
        {
        }

        [HttpGet]
        [Route("users")]
        public IActionResult GetUsers()
        {
            try 
            { 
                var listUsers = _dbContext.Users
                    .Select(t => new UsersDTO { })
            }
        }
    }
}
