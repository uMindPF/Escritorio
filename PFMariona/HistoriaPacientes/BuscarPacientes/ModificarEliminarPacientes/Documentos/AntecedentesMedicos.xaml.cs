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

namespace PFMariona
{
    /// <summary>
    /// Lógica de interacción para AntecedentesMedicos.xaml
    /// </summary>
    public partial class AntecedentesMedicos : Window
    {
        public AntecedentesMedicos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
