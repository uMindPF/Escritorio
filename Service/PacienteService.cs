using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using uMind.Model;

namespace uMind.Service
{
    internal class PacienteService
    {
        private static readonly HttpClient HttpClient = new HttpClient();

        public static async Task<List<Pacientes>> getPacientes()
        {
            try
            {
                string token = await TokenService.getToken("a", "a");

                HttpClient.DefaultRequestHeaders.Add("Authorization", token);

                using HttpResponseMessage response = await HttpClient.GetAsync(ConnectionInfo.URL_API + "consultas/pacientes");

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync());
                    return JsonSerializer.Deserialize<List<Pacientes>>(await response.Content.ReadAsStringAsync());
                }

               
            } catch (Exception ex) { }

            return null;
        }
    }
}
