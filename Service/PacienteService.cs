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
        public static async Task<List<Pacientes>> getPacientes()
        {
            try
            {
                string token = await TokenService.getToken();

                HttpClient httpClient = new HttpClient();

                httpClient.DefaultRequestHeaders.Add("Authorization", token);

                using HttpResponseMessage response = await httpClient.GetAsync(ConnectionInfo.URL_API + "consultas/pacientes");

                if (response.IsSuccessStatusCode)
                {
                    return JsonSerializer.Deserialize<List<Pacientes>>(await response.Content.ReadAsStringAsync());
                }

               
            } catch (Exception ex) { }

            return null;
        }

        public static async Task<Pacientes> getPacienteId(int id)
        {
            try
            {
                string token = await TokenService.getToken();
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", token);
                using HttpResponseMessage response = await httpClient.GetAsync(ConnectionInfo.URL_API + "consultas/pacientes/" + id);
                if (response.IsSuccessStatusCode)
                {
                    return JsonSerializer.Deserialize<Pacientes>(await response.Content.ReadAsStringAsync());
                }
            }
            catch (Exception ex) { }
            return null;
        }

        public static async Task<List<Pacientes>> getPacientesNombre(string name)
        {
            try
            {
                string token = await TokenService.getToken();
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", token);
                using HttpResponseMessage response = await httpClient.GetAsync(ConnectionInfo.URL_API + "consultas/pacientes/nombre/" + name);
                if (response.IsSuccessStatusCode)
                {
                    return JsonSerializer.Deserialize<List<Pacientes>>(await response.Content.ReadAsStringAsync());
                }
            }
            catch (Exception ex) { }
            return null;
        }
    }
}
