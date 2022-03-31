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
            new User {Id=1, Email="Batingamark@gmail.com", Password="Mark", LastName="Batinga", FirstName="Mark", Phone="09501109163"},
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


        [HttpPost]
        public async Task<ActionResult<List<User>>> CreateUser(User user)
        {
            user.Id = Users.Max(u => u.Id + 1);
            Users.Add(user);
            return Ok(Users);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<User>>> UpdateUser(User user, int id)
        {
            var dbUser = Users.FirstOrDefault(u => u.Id == id);
            var userIndex = Users.IndexOf(dbUser);
            if (dbUser == null)
                return NotFound(dbUser);

            Users[userIndex] = user;
            return Ok(Users);
        }
    }
}
