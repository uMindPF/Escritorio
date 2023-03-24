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
    /// Lógica de interacción para ModificarCita.xaml
    /// </summary>
    public partial class ModificarCita : Window
    {
        public ModificarCita()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAtras_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
