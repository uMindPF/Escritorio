using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using uMind.Model;

namespace uMind.Service
{
    internal class DoctorService
    {

        public static async Task<List<Doctor>> getDoctors()
        {
            try
            {
                string token = await TokenService.getToken();

                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", token);

                using HttpResponseMessage response = await httpClient.GetAsync(ConnectionInfo.URL_API + "consultas/usuarios");

                if (response.IsSuccessStatusCode)
                {
                    return JsonSerializer.Deserialize<List<Doctor>>(await response.Content.ReadAsStringAsync());
                }
            }
            catch (Exception exception)
            { }

            return null;
        }

    }
}
