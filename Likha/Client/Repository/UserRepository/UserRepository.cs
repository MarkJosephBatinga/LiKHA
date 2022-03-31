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
        public User PasswordDecrypt(User user)
        {
            string passwordbytes = Encoding.UTF8.GetString(user.PasswordHash);
            user.Password = passwordbytes;
            return user;
        }

        public User PasswordEncrypt(User user)
        {
            byte[] passwordbytes = Encoding.UTF8.GetBytes(user.Password);
            user.PasswordHash = passwordbytes;
            return user;
        }
    }
}
