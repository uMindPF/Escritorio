using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uMind.Model
{
	public class HistoriaClinica
	{
		public int id { get; set; }
		public Paciente paciente { get; set; }
		public string fecha { get; set; }
		public string titulo { get; set; }
		public string descripcion { get; set; }
	}
}
