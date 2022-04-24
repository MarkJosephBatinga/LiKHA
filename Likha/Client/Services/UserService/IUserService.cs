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
        event Action OnChange;

        Task<User> GetUser(string username);
        Task<User> GetUserById(int UserId);

        Task<List<User>> RegisterUser(User user);

        Task<List<User>> UpdateUser(User user);

        Task<User> LoginUser(User user);
    }
}
