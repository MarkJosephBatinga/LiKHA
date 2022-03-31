using Likha.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Likha.Client.Repository.UserRepository
{
    public interface IUserRepository
    {
        User PasswordEncrypt(User user);
        User PasswordDecrypt(User user);
    }
}
