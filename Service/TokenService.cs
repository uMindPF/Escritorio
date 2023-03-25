using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;

namespace uMind.Service
{
    internal class TokenService
    {
        private static HttpClient HttpClient = new HttpClient();

        public static async Task<string> getToken(String username, String password)
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
                using HttpResponseMessage response = await HttpClient.PostAsync(ConnectionInfo.URL_API + "authorize", jsonContent);

                if (response.IsSuccessStatusCode)
                {
                    return response.Headers.GetValues("Authorization").FirstOrDefault();
                }

                return null;
            }
            catch
            {
                return null;
            }

        }
    }
}
