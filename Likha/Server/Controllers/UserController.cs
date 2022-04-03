using Likha.Server.Services.UserService;
using Likha.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Likha.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _user;

        public UserController(IUserService user)
        {
            _user = user;
        }

        List<User> Users = new List<User>
        {
            new User {Id=1, Email="Batingamark@gmail.com", LastName="Batinga", FirstName="Mark", Phone="09501109163"},
        };

        [HttpGet("{username}")]
        public async Task<ActionResult<User>> GetUser(string username)
        {
            var dbuser = await _user.GetUser(username);
            return Ok(dbuser);
        }

        [HttpPost("login")]
        public async Task<ActionResult<User>> LoginUser(User user)
        {
            var dbuser = await _user.LoginUser(user);
            return Ok(dbuser);
        }


        [HttpPost("register")]
        public async Task<ActionResult<List<User>>> RegisterUser(User user)
        {
            List<User> Users = await _user.RegisterUser(user);
            if (Users != null)
                return Ok(Users);
            return NotFound(Users);
        }

        [HttpPut]
        public async Task<ActionResult<List<User>>> UpdateUser(User user)
        {
            List<User> Users = await _user.UpdateUser(user);
            if (Users != null)
                return Ok(Users);
            return NotFound(Users);
        }
    }
}
