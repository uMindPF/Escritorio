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
	internal class HistorialClinicoService
	{
		public static async Task<List<HistoriaClinica>> getHistorialClinico(int idPaciente)
		{
			try
			{
				string token = await TokenService.getToken();

				HttpClient httpClient = new HttpClient();
				httpClient.DefaultRequestHeaders.Add("Authorization", token);

				using HttpResponseMessage response = await httpClient.GetAsync(ConnectionInfo.URL_API + "consultas/historial/paciente/" + idPaciente);

				if (response.IsSuccessStatusCode)
				{
					return JsonSerializer.Deserialize<List<HistoriaClinica>>(await response.Content.ReadAsStringAsync());
				}
			}
			catch (Exception exception)
			{ }

			return null;
		}

		public static async Task<HistoriaClinica> getHistoriaClinicaId(int id)
		{
			try
			{
				string token = await TokenService.getToken();
				HttpClient httpClient = new HttpClient();
				httpClient.DefaultRequestHeaders.Add("Authorization", token);
				using HttpResponseMessage response = await httpClient.GetAsync(ConnectionInfo.URL_API + "consultas/historial/" + id);
				if (response.IsSuccessStatusCode)
				{
					return JsonSerializer.Deserialize<HistoriaClinica>(await response.Content.ReadAsStringAsync());
				}
			}
			catch (Exception ex) { }
			return null;
		}

		private class Data
		{
			public int id { get; set; }
			public string date { get; set; }
		}

		public static async Task<List<HistoriaClinica>> getHistorialPacienteDate(int idPaciente, DateTime date)
		{
			try
			{
				string token = await TokenService.getToken();
				HttpClient client = new HttpClient();
				client.DefaultRequestHeaders.Add("Authorization", token);

				Data sendData = new Data();

				sendData.id = idPaciente;
				sendData.date = date.ToString("yyyy-MM-dd");

				string json = JsonSerializer.Serialize(sendData);
				StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

				using HttpResponseMessage response = await client.PostAsync(ConnectionInfo.URL_API + "/consultas/historial/datePaciente", content);

				if (response.IsSuccessStatusCode)
				{
					return JsonSerializer.Deserialize<List<HistoriaClinica>>(await response.Content.ReadAsStringAsync());
				}

			}
			catch (Exception exception) { }

			return null;
		}

		public static async Task saveHsitoriaClinica(HistoriaClinica historiaClinica)
		{
			string token = await TokenService.getToken();
			HttpClient httpClient = new HttpClient();
			httpClient.DefaultRequestHeaders.Add("Authorization", token);

			string json = JsonSerializer.Serialize(historiaClinica);
			StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

			using HttpResponseMessage response = await httpClient.PostAsync(ConnectionInfo.URL_API + "consultas/historial/save", content);
			if (!response.IsSuccessStatusCode)
			{
				Exception exception = new Exception("Error al registrar la historia");
				throw exception;
			}
		}
	}
}
