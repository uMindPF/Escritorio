using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace uMind.Logica
{
	internal class Fechas
	{
		static public string cambiarFormato(string cambiar)
		{
			DateTime fecha = DateTime.Parse(cambiar);
			string fechaString = fecha.ToString("yyyy-MM-dd");
			return fechaString;
		}
	}
}
