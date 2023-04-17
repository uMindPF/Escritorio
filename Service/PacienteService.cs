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
        public static async Task<List<Paciente>> getPacientes()
        {
            try
            {
                string token = await TokenService.getToken();

                HttpClient httpClient = new HttpClient();

                httpClient.DefaultRequestHeaders.Add("Authorization", token);

                using HttpResponseMessage response = await httpClient.GetAsync(ConnectionInfo.URL_API + "consultas/pacientes");

                if (response.IsSuccessStatusCode)
                {
                    return JsonSerializer.Deserialize<List<Paciente>>(await response.Content.ReadAsStringAsync());
                }

               
            } catch (Exception ex) { }

            return null;
        }

        public static async Task<Paciente> getPacienteId(int id)
        {
            try
            {
                string token = await TokenService.getToken();
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", token);
                using HttpResponseMessage response = await httpClient.GetAsync(ConnectionInfo.URL_API + "consultas/pacientes/" + id);
                if (response.IsSuccessStatusCode)
                {
                    return JsonSerializer.Deserialize<Paciente>(await response.Content.ReadAsStringAsync());
                }
            }
            catch (Exception ex) { }
            return null;
        }

        public static async Task<List<Paciente>> getPacientesNombre(string name)
        {
            try
            {
                string token = await TokenService.getToken();
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", token);
                using HttpResponseMessage response = await httpClient.GetAsync(ConnectionInfo.URL_API + "consultas/pacientes/nombre/" + name);
                if (response.IsSuccessStatusCode)
                {
                    return JsonSerializer.Deserialize<List<Paciente>>(await response.Content.ReadAsStringAsync());
                }
            }
            catch (Exception ex) { }
            return null;
        }

        public static async void savePaciente(Paciente pacientes)
        {
	        try
	        {
				string token = await TokenService.getToken();
				HttpClient httpClient = new HttpClient();
				httpClient.DefaultRequestHeaders.Add("Authorization", token);

                string json = JsonSerializer.Serialize(pacientes);
				StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

				using HttpResponseMessage response = await httpClient.PostAsync(ConnectionInfo.URL_API + "consultas/pacientes/save", content);
				if (response.IsSuccessStatusCode)
				{
					MessageBox.Show("Pacientes registrado correctamente");
				}
				else
				{
					MessageBox.Show("Error al registrar el pacientes");
				}
	        }
			catch (Exception ex) { }
		}
    }
}
