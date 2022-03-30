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
    }
}
