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
using System.Windows.Navigation;
using System.Windows.Shapes;
using uMind;

namespace PFMariona
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            initConfig();

        }

        public void initConfig()
        {
        }

        

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
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

        private void btnBuscarPaciente_Click(object sender, RoutedEventArgs e)
        {
            BuscarPacientes buscarPacientes = new BuscarPacientes();
            this.Close();
            buscarPacientes.Show();
        }

        private void btnPerfil_Click(object sender, RoutedEventArgs e)
        {
            Perfil perfil = new Perfil();
            this.Close();
            perfil.Show();
        }
    }
}
