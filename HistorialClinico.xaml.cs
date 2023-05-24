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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using uMind.Model;
using uMind.Service;

namespace uMind
{
    /// <summary>
    /// Lógica de interacción para HistorialClinico.xaml
    /// </summary>
    public partial class HistorialClinico : Window
    {
        private List<HistoriaClinica> historial;
        private Paciente paciente;

        public HistorialClinico(Paciente paciente)
        {
            
            InitializeComponent();
            cargarHistorial(paciente.id);
            this.paciente = paciente;
            TextId.Text = paciente.id + "";
            TextName.Text = paciente.nombre;
        }

        private async void cargarHistorial(int id)
        {
            historial = await HistorialClinicoService.getHistorialClinico(id);
            datagridHistorial.Items.Clear();

            displayHistorial(historial);
        }

        private void displayHistorial(List<HistoriaClinica> historialClinico)
        {
	        if (historialClinico == null)
	        {
		        return;
	        }

            foreach (var historial in historialClinico)
            {

                datagridHistorial.Items.Add(new
                    {
                        Id = historial.id,
                        Fecha = historial.fecha,
                        Titulo = historial.titulo
                    });
            }
        }



        private void BtnCerrar_OnClick(object sender, RoutedEventArgs e)
        {
	        this.Close();
        }

        private void ModificarEntrada(object sender, RoutedEventArgs e)
        {
	        var data = datagridHistorial.SelectedItem;
	        int id = (int)data.GetType().GetProperty("Id").GetValue(data, null);

	        foreach (var entrada in historial)
	        {
		        if (entrada.id == id)
		        {
			        AddEntrada modificarCita = new AddEntrada(entrada);
			        modificarCita.ShowDialog();
			        break;
		        }
	        }
		}
    }
}
