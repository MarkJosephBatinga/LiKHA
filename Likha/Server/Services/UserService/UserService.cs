using Likha.Server.Data;
using Likha.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Likha.Server.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly DataContext _dataContext;

        public UserService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<User> LoginUser(User user)
        {
            User dbuser = await _dataContext.Users.FirstOrDefaultAsync(u => u.Username == user.Username && u.Password == user.Password);
            var dbnotfound = new User();
            if (dbuser == null)
                return dbnotfound;
            return dbuser;
        }
    }
}
