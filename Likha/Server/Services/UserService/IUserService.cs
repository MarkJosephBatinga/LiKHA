using Likha.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Likha.Server.Services.UserService
{
    public interface IUserService
    {
        Task<User> LoginUser(User user);

        Task<User> GetUser(string username);
        Task<User> GetUserById(int userId);

        Task<List<User>> RegisterUser(User user);

        Task<List<User>> UpdateUser(User user);
    }
}
