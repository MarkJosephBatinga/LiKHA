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

        public async Task<User> GetUser(string username)
        {
            User User = await _dataContext.Users.FirstOrDefaultAsync(u => u.Email == username);
            User UserNotFound = new User();
            if (User == null)
                return UserNotFound;
            return User;
        }

        public async Task<User> GetUserById(int userId)
        {
            User user = await _dataContext.Users.Where(u => u.Id == userId).FirstOrDefaultAsync();
            return user;
        }

        public async Task<User> LoginUser(User user)
        {
            User dbuser = await _dataContext.Users.FirstOrDefaultAsync(u => u.Email == user.Email && u.PasswordHash == user.PasswordHash);
            var dbnotfound = new User();
            if (dbuser == null)
                return dbnotfound;
            return dbuser;
        }

        public async Task<List<User>> RegisterUser(User user)
        {
            await _dataContext.Users.AddAsync(user);
            await _dataContext.SaveChangesAsync();
            List<User> Users = await _dataContext.Users.ToListAsync();
            return Users;
        }

        public async Task<List<User>> UpdateUser(User user)
        {
            List<User> Users = await _dataContext.Users.ToListAsync();
            var dbUser = await _dataContext.Users.FindAsync(user.Id);
            if(dbUser != null)
            {
                _dataContext.Entry(dbUser).CurrentValues.SetValues(user);
                await _dataContext.SaveChangesAsync();
            }

            return Users;
        }
    }
}
