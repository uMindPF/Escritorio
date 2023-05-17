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
        public HistorialClinico(int idPaciente)
        {
            
            InitializeComponent();
            cargarHistorial(idPaciente);
        }

        private async void cargarHistorial(int id)
        {
            historial = await HistorialClinicoService.getHistorialClinico(id);
            datagridHistorial.Items.Clear();

            displayPacientes(historial);


        }

        private void displayPacientes(List<HistoriaClinica> historialClinico)
        {
            foreach (var historial in historialClinico)
            {

                datagridHistorial.Items.Add(new
                    {
                        Id = historial.id,
                        Descripcion = historial.descripcion,
                        Fecha = historial.fecha,
                        Titulo = historial.titulo
                    });
                
            }
        }
    }
}
