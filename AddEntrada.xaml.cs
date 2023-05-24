using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        private HistoriaClinica historiaClinica;

        public AddEntrada(Paciente paciente)
        {
            InitializeComponent();
            historiaClinica = new HistoriaClinica();
            historiaClinica.paciente = paciente;

            TextID.Text = paciente.id + "";
            TextNombre.Text = paciente.nombre;
        }

        public AddEntrada(HistoriaClinica entrada)
        {
            InitializeComponent();
            historiaClinica = entrada;

            TextID.Text = entrada.paciente.id + "";
            TextNombre.Text = entrada.paciente.nombre;
            TextTitulo.Text = entrada.titulo;
            TextDescripcion.Text = entrada.descripcion;
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

        private async void Guardar_Click(object sender, RoutedEventArgs e)
        {
	        historiaClinica.titulo = TextTitulo.Text;
            historiaClinica.descripcion = TextDescripcion.Text;
            historiaClinica.fecha = Fechas.cambiarFormato((DateTime.Now).ToString());

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
