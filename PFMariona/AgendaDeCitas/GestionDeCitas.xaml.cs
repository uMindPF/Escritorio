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


namespace uMind.AgendaDeCitas
{
    /// <summary>
    /// Lógica de interacción para GestionDeCitas.xaml
    /// </summary>
    public partial class GestionDeCitas : Window
    {
        public GestionDeCitas()
        {
            InitializeComponent();
        }

        private void btnPerfil_Click(object sender, RoutedEventArgs e)
        {
            Perfil perfil = new Perfil();
            this.Close();
            perfil.Show();
        }
    }
}
