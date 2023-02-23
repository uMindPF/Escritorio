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
    /// Lógica de interacción para Calendario.xaml
    /// </summary>
    public partial class Calendario : Window
    {
        public Calendario()
        {
            InitializeComponent();
        }

        private void btnNuevoPaciente_Click(object sender, RoutedEventArgs e)
        {
            CrearPaciente crearPaciente = new CrearPaciente();
            crearPaciente.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnCalendario_Click(object sender, RoutedEventArgs e)
        {
            Calendario calendario = new Calendario();
            this.Show();
            calendario.Show();
        }

        private void btnBuscarPaciente_Click(object sender, RoutedEventArgs e)
        {
            BuscarPacientes buscarPacientes = new BuscarPacientes();
            this.Close();
            buscarPacientes.Show();
        }

        private void btnSalir_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnPerfil_Click(object sender, RoutedEventArgs e)
        {
            Perfil perfil = new Perfil();
            this.Close();
            perfil.Show();
        }
    }
}
