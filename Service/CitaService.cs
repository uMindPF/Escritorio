using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using uMind.Model;

namespace uMind.Service
{
    internal class CitaService
    {
        private static readonly HttpClient HttpClient = new HttpClient();

        public static async Task<List<Citas>> getCitas()
        {
            try
            {
                string token = await TokenService.getToken("a", "a");
                HttpClient.DefaultRequestHeaders.Add("Authorization", token);
                using HttpResponseMessage response = await HttpClient.GetAsync(ConnectionInfo.URL_API + "consultas/citas");
                if (response.IsSuccessStatusCode)
                {
                    return JsonSerializer.Deserialize<List<Citas>>(await response.Content.ReadAsStringAsync());
                }
            }
            catch (Exception exception)
            { }
            return null;
        }

        public static async Task<List<Citas>> getCitasDoctor(int id)
        {
            try
            {
                string token = await TokenService.getToken("a", "a");
                HttpClient.DefaultRequestHeaders.Add("Authorization", token);
                using HttpResponseMessage response = await HttpClient.GetAsync(ConnectionInfo.URL_API + "consultas/citas/doctor/" + id);
                if (response.IsSuccessStatusCode)
                {
                    return JsonSerializer.Deserialize<List<Citas>>(await response.Content.ReadAsStringAsync());
                }
            } catch (Exception exception) { }

            return null;
        }
    }
}
