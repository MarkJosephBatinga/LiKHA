using Likha.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Likha.Client.Services.UserService
{
    interface IUserService
    {
        public List<User> Users { get; set; }
        public User User { get; set; }

        Task<User> GetUser(string username);

        Task<List<User>> CreateUser(User user);

        Task<List<User>> UpdateUser(User user, int id);

        Task<User> LoginUser(User user);
    }
}
