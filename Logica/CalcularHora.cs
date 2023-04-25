using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.VisualBasic.CompilerServices;
using uMind.Model;
using uMind.Service;

namespace uMind.Logica
{
	internal class CalcularHora
	{

		private static int horaInicio = 9;
		private static int horaFin = 19;

		public static async Task<List<DateTime>> dayHours(DateTime date, int idDoctor)
		{
			List<Cita> citasDia = await CitaService.getCitasDoctorDate(idDoctor, date);

			List<DateTime> horas = new List<DateTime>();

			for (int i = horaInicio; i < horaFin; i++)
			{
				for (int j = 0; j < 60; j+=15)
				{
					if (i == 18 && j > 30)
					{
						break;
					}

					string horaString = i + ":" + j;
					DateTime hora = DateTime.Parse(horaString);

					horas.Add(hora);
				}
			}

			if (citasDia == null)
			{
				return horas;
			}

			foreach (var citas in citasDia)
			{
				MessageBox.Show(citas.hora);
				DateTime hora = DateTime.Parse(citas.hora);
				horas.Remove(hora);

				double duracion = citas.duracion/15;

				for (int i = 0; i < duracion; i++)
				{
					hora.AddMinutes(15);
					horas.Remove(hora);
				}

			}

			return horas;
		}
	}
}
