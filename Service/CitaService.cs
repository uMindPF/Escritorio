using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Xps.Serialization;
using uMind.Model;

namespace uMind.Service
{
    internal class CitaService
    {
        public static async Task<List<Cita>> getCitas()
        {
            try
            {
                string token = await TokenService.getToken();
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", token);
                using HttpResponseMessage response = await client.GetAsync(ConnectionInfo.URL_API + "consultas/citas");
                if (response.IsSuccessStatusCode)
                {
                    return JsonSerializer.Deserialize<List<Cita>>(await response.Content.ReadAsStringAsync());
                }
            }
            catch (Exception exception)
            { }
            return null;
        }

        public static async Task<List<Cita>> getCitasDoctor(int id)
        {
            try
            {
                string token = await TokenService.getToken();
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", token);
                using HttpResponseMessage response =
                    await client.GetAsync(ConnectionInfo.URL_API + "consultas/citas/doctor/" + id);
                if (response.IsSuccessStatusCode)
                {
                    return JsonSerializer.Deserialize<List<Cita>>(await response.Content.ReadAsStringAsync());
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            return null;
        }

        public static async Task<List<Cita>> getCitasDate(DateTime date)
        {
            try
            {
                string token = await TokenService.getToken();
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", token);
                using HttpResponseMessage response = 
                    await client.GetAsync(ConnectionInfo.URL_API + "consultas/citas/date/" + date.ToString("yyyy-MM-dd"));

                if (response.IsSuccessStatusCode)
                {
                    return JsonSerializer.Deserialize<List<Cita>>(await response.Content.ReadAsStringAsync());
                }

            } catch (Exception exception) { }

            return null;
        }

        public static async Task<List<Cita>> getCitasDoctorDate(int idDoctor, DateTime date)
        {
	        try
	        {
		        string token = await TokenService.getToken();
		        HttpClient client = new HttpClient();
		        client.DefaultRequestHeaders.Add("Authorization", token);

		        using HttpResponseMessage response =
			        await client.GetAsync(ConnectionInfo.URL_API + "consultas/citas/"+ idDoctor + "/" + date.ToString("yyyy-MM-dd"));

		        if (response.IsSuccessStatusCode)
		        {
			        return JsonSerializer.Deserialize<List<Cita>>(await response.Content.ReadAsStringAsync());
		        }

	        }
	        catch (Exception exception)
	        {
		        MessageBox.Show("a");
	        }

			return null;
		}

        public static async Task saveCita(Cita cita)
        {
	        string token = await TokenService.getToken();
	        HttpClient client = new HttpClient();
	        client.DefaultRequestHeaders.Add("Authorization", token);

	        string json = JsonSerializer.Serialize(cita);
	        StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

	        using HttpResponseMessage response = await client.PostAsync(ConnectionInfo.URL_API + "consultas/citas/save", content);
	        if (!response.IsSuccessStatusCode)
	        {
		        Exception exception = new Exception(await response.Content.ReadAsStringAsync());
		        throw exception;
	        }
	    }

        public static async Task deleteCita(int id)
        {
			string token = await TokenService.getToken();
			HttpClient client = new HttpClient();
			client.DefaultRequestHeaders.Add("Authorization", token);

			using HttpResponseMessage response = await client.GetAsync(ConnectionInfo.URL_API + "consultas/citas/delete/" + id);
			if (!response.IsSuccessStatusCode)
			{
				Exception exception = new Exception(await response.Content.ReadAsStringAsync());
				throw exception;
			}
        }
    }
}
