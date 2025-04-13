using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace asyncawait.Services
{
    public class UserService
    {
        private readonly HttpClient _httpClient;
        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<string>> GetUserNamesAsync(CancellationToken cancellationToken)
        {
            var users = await _httpClient.GetFromJsonAsync<List<UserDto>>("https://api.example.com/users", cancellationToken)
                .ConfigureAwait(false);
            return users.Select(s => s.Name).ToList();
        }
    }
    class UserDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
