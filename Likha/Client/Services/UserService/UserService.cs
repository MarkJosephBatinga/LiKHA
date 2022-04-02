using Likha.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Likha.Client.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly HttpClient _http;

        public event Action OnChange;

        public UserService(HttpClient http)
        {
            _http = http;
        }

        public List<User> Users { get; set; }
        public User User { get; set; }

        public async Task<User> LoginUser(User user)
        {
            var dbuser = new User();
            var result = await _http.PostAsJsonAsync<User>($"api/user/login", user);
            if(result != null)
            {
                dbuser = await result.Content.ReadFromJsonAsync<User>();
            }
            return dbuser;
        }

        public async Task<List<User>> UpdateUser(User user, int id)
        {
            var result = await _http.PutAsJsonAsync($"api/user/{id}", user);
            var users = await result.Content.ReadFromJsonAsync<List<User>>();
            return users;
        }

        public async Task<User> GetUser(string username)
        {
            User = await _http.GetFromJsonAsync<User>($"api/user/{username}");
            OnChange.Invoke();
            return User;
        }

        public async Task<List<User>> RegisterUser(User user)
        {
            var result = await _http.PostAsJsonAsync("api/user/register", user);
            var status = await result.Content.ReadFromJsonAsync<List<User>>();
            return status;
        }
    }
}
