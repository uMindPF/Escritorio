using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace uMind.Service
{
    internal class LoginService
    {
        public static async Task<bool> Login(string username, string password)
        {
            using StringContent jsonContent = new(
                JsonSerializer.Serialize(new
                {
                    username = username,
                    password = password
                }),
                Encoding.UTF8,
                "application/json");

            try
            {
                HttpClient httpClient = new HttpClient();
                using HttpResponseMessage response = await httpClient.PostAsync(ConnectionInfo.URL_API + "authorize", jsonContent);
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }
    }
}
