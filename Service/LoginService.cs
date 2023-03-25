using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace uMind.Service
{
    internal class LoginService
    {
        private static readonly HttpClient HttpClient = new HttpClient();

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
                using HttpResponseMessage response =
                    await HttpClient.PostAsync(ConnectionInfo.URL_API + "authorize", jsonContent);
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }
    }
}
