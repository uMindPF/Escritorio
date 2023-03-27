using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
        public static async Task<List<Citas>> getCitas()
        {
            try
            {
                string token = await TokenService.getToken();
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", token);
                using HttpResponseMessage response = await client.GetAsync(ConnectionInfo.URL_API + "consultas/citas");
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
                string token = await TokenService.getToken();
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", token);
                using HttpResponseMessage response =
                    await client.GetAsync(ConnectionInfo.URL_API + "consultas/citas/doctor/" + id);
                if (response.IsSuccessStatusCode)
                {
                    return JsonSerializer.Deserialize<List<Citas>>(await response.Content.ReadAsStringAsync());
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            return null;
        }

        public static async Task<List<Citas>> getCitasDate(DateTime date)
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
                    return JsonSerializer.Deserialize<List<Citas>>(await response.Content.ReadAsStringAsync());
                }

            } catch (Exception exception) { }

            return null;
        }
    }
}
