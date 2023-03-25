using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uMind.Model
{
    public class Citas
    { 
        public int id { get; set; }
        public Doctor doctor { get; set; }
        public Pacientes paciente { get; set; }
        public string dia { get; set; }
        public string hora { get; set; }
        public double duracion { get; set; }
        public string estado { get; set; }
        public string tipoVista { get; set; }
    }
}
