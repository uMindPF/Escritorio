using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uMind.Model
{
    public class Citas
    {
        // IdCita = 13024, IdPaciente = 64781, NombrePaciente = "Mariona Guàrdia", ApellidoPaciente = "Guardia", Psicologo = "08291 Abel", Dia = "25/03/23", Hora = "18:30", Estado = "Pendiente", TipoVisita = "Mantenimiento"
        public int id { get; set; }
        public Pacientes Paciente { get; set; }
        public string NombrePaciente { get; set; }
        public string ApellidoPaciente { get; set; }
        public string Psicologo { get; set; }
        public string Dia { get; set; }
        public string Hora { get; set; }
        public string Estado { get; set; }
        public string TipoVisita { get; set; }
    }
}
