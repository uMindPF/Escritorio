using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uMind.Model
{
    public class Pacientes
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public Doctor doctor { get; set; }
        public string poblacion { get; set; }
        public string sexo { get; set; }
        public string fechaNacimiento { get; set; }
        public string fechaAlta { get; set; }
        public string fechaBaja { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }


    }

    public class ListarPacientes
    {
        public ObservableCollection<Pacientes> Pacientes { get; set; }

        public ListarPacientes()
        {
            Pacientes = new ObservableCollection<Pacientes>();
        }

        public void EliminarRegistro(Pacientes pacientes)
        {
            Pacientes.Remove(pacientes);
        }

        public void AgregarPaciente(int id, string nombre)
        {
            Pacientes pacientes = new Pacientes { id = id, nombre = nombre };
            Pacientes.Add(pacientes);
        }
    }

}
