using Likha.Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Likha.Client.Repository.UserRepository
{
    public class UserRepository : IUserRepository
    {
        public User LoginEncrypt(LoginUser UserLogin)
        {
            User user = new User();
            user.Email = UserLogin.Email;
            user.PasswordHash = Encoding.UTF8.GetBytes(UserLogin.Password);
            return user;
        }

        public User PasswordDecrypt(User user)
        {
            string passwordbytes = Encoding.UTF8.GetString(user.PasswordHash);
            user.Password = passwordbytes;
            return user;
        }

        public User PasswordEncrypt(RegisterUser UnregisteredUser)
        {
            User user = new User();
            user.Email = UnregisteredUser.Email;
            user.PasswordHash = Encoding.UTF8.GetBytes(UnregisteredUser.Password);
            user.LastName = UnregisteredUser.LastName;
            user.FirstName = UnregisteredUser.FirstName;
            user.Phone = UnregisteredUser.Phone;
            return user;
        }
    }
}
