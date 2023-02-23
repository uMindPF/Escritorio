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
using uMind;


namespace PFMariona
{
    /// <summary>
    /// Lógica de interacción para CrearPaciente.xaml
    /// </summary>
    public partial class CrearPaciente : Window
    {
        public CrearPaciente()
        {
            InitializeComponent();
        }

        private void btnCalendario_Click(object sender, RoutedEventArgs e)
        {
            Calendario calendario = new Calendario();
            calendario.Show();
            this.Close();
        }


        private void btnAtras_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btnAntecedentesMedicos_Click(object sender, RoutedEventArgs e)
        {
            AntecedentesMedicos antecedentesMedicos = new AntecedentesMedicos();
            antecedentesMedicos.ShowDialog();
        }

        private void btnBuscarPaciente_Click(object sender, RoutedEventArgs e)
        {
            BuscarPacientes buscarPacientes = new BuscarPacientes();
            this.Close();
            buscarPacientes.Show();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnHistorialClinico_Click(object sender, RoutedEventArgs e)
        {
            HistorialClinico historialClinico = new HistorialClinico();
            historialClinico.ShowDialog();
        }

        private void btnPerfil_Click(object sender, RoutedEventArgs e)
        {
            Perfil perfil = new Perfil();
            this.Close();
            perfil.Show();
        }
    }
}
