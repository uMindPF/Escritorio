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
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Psicologo { get; set; }
        public string Población { get; set; }
        public string Sexo { get; set; }
        public string FechaNacimiento { get; set; }
        public string FechaInicio { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }


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
            Pacientes pacientes = new Pacientes { Id = id, Nombre = nombre };
            Pacientes.Add(pacientes);
        }
    }

}
