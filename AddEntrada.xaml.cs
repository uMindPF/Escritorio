using DocumentFormat.OpenXml.Office2010.Excel;
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
using uMind.Logica;
using uMind.Model;
using uMind.Service;

namespace uMind
{
    /// <summary>
    /// Lógica de interacción para AddEntrada.xaml
    /// </summary>
    public partial class AddEntrada : Window
    {
        private Paciente pacientes;
  
        public AddEntrada(int id)
        {
            InitializeComponent();
            setPaciente(id);
        }

        public AddEntrada() {
            InitializeComponent();
            NuevaEntrada.Visibility = Visibility.Collapsed;
        }
      
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TextBox textBox = (TextBox)sender;
                textBox.AppendText(Environment.NewLine);

                e.Handled = true;
            }
        }

        private async void setPaciente(int id)
        {
            pacientes = await PacienteService.getPacienteId(id);

            TextID.Text = pacientes.id.ToString();
            TextNombre.Text = pacientes.nombre;

        }

        private async void saveHistorial(int id)
        {
            pacientes = await PacienteService.getPacienteId(id);

            TextID.Text = pacientes.id.ToString();
            TextNombre.Text = pacientes.nombre;

        }

        private async void Guardar_Click(object sender, RoutedEventArgs e)
        {
     
            HistoriaClinica historiaClinica = new HistoriaClinica();
            historiaClinica.titulo = TextTitulo.Text;
            historiaClinica.descripcion = TextDescripcion.Text;
            //historiaClinica.paciente = ;
            historiaClinica.fecha = (DateTime.Now).ToString();

            try
            {
                await HistorialClinicoService.saveHsitoriaClinica(historiaClinica);
                MessageBox.Show("Entrada registrada");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnAtras_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
