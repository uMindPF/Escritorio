using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using uMind.Model;

namespace uMind
{
    /// <summary>
    /// Lógica de interacción para RegistrarCita.xaml
    /// </summary>
    public partial class RegistrarCita : Window
    {
        Paciente _pacientes;

        public RegistrarCita(Paciente pacientes)
        {
	        InitializeComponent();

            this._pacientes = pacientes;
            TextBoxID.Text = pacientes.id.ToString();
            TextBoxName.Text = pacientes.nombre;
        }

        private void btnBuscarPaciente_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAtras_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            BuscarPaciente buscarPaciente = new BuscarPaciente();
            buscarPaciente.ShowDialog();
        }

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
