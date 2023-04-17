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
    /// Lógica de interacción para ModificarPaciente.xaml
    /// </summary>
    public partial class ModificarPaciente : Window
    {
        public ModificarPaciente()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

		private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
		{

		}
	}
}
