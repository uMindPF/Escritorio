using PFMariona;
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


namespace uMind
{
    /// <summary>
    /// Lógica de interacción para BuscarPacientes.xaml
    /// </summary>
    public partial class BuscarPacientes : Window
    {
        public BuscarPacientes()
        {
            InitializeComponent();
        }

        private void btnNuevoPaciente_Click(object sender, RoutedEventArgs e)
        {
            CrearPaciente crearPaciente = new CrearPaciente();
            this.Close();
            crearPaciente.Show();
        }

        private void btnCalendario_Click(object sender, RoutedEventArgs e)
        {
            Calendario calendario = new Calendario();
            this.Close();
            calendario.Show();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnPrueba_Click(object sender, RoutedEventArgs e)
        {
            ModificarEliminarPacientes modificarEliminarPacientes = new ModificarEliminarPacientes();
            modificarEliminarPacientes.ShowDialog();
        }

        private void btnPerfil_Click(object sender, RoutedEventArgs e)
        {
            Perfil perfil = new Perfil();
            this.Close();
            perfil.Show();
        }
    }
}
