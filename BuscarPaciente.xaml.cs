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
    /// Lógica de interacción para BuscarPaciente.xaml
    /// </summary>
    public partial class BuscarPaciente : Window
    {
        public BuscarPaciente()
        {
            InitializeComponent();
            datagridBuscar.Items.Add(new { Id = "18974", Nombre = "Mariona", Apellido = "Guardia", Psicologo = "Abel" });
            datagridBuscar.Items.Add(new { Id = "18974", Nombre = "Mariona", Apellido = "Guardia", Psicologo = "Abel" });
            datagridBuscar.Items.Add(new { Id = "18974", Nombre = "Mariona", Apellido = "Guardia", Psicologo = "Abel" });
            datagridBuscar.Items.Add(new { Id = "18974", Nombre = "Mariona", Apellido = "Guardia", Psicologo = "Abel" });
            datagridBuscar.Items.Add(new { Id = "18974", Nombre = "Mariona", Apellido = "Guardia", Psicologo = "Abel" });
            datagridBuscar.Items.Add(new { Id = "18974", Nombre = "Mariona", Apellido = "Guardia", Psicologo = "Abel" });
            datagridBuscar.Items.Add(new { Id = "18974", Nombre = "Mariona", Apellido = "Guardia", Psicologo = "Abel" });
            datagridBuscar.Items.Add(new { Id = "18974", Nombre = "Mariona", Apellido = "Guardia", Psicologo = "Abel" });
            datagridBuscar.Items.Add(new { Id = "18974", Nombre = "Mariona", Apellido = "Guardia", Psicologo = "Abel" });

            datagridBuscar.Items.Add(new { Id = "18974", Nombre = "Mariona", Apellido = "Guardia", Psicologo = "Abel" });
            datagridBuscar.Items.Add(new { Id = "18974", Nombre = "Mariona", Apellido = "Guardia", Psicologo = "Abel" });
            datagridBuscar.Items.Add(new { Id = "18974", Nombre = "Mariona", Apellido = "Guardia", Psicologo = "Abel" });
            datagridBuscar.Items.Add(new { Id = "18974", Nombre = "Mariona", Apellido = "Guardia", Psicologo = "Abel" });
            datagridBuscar.Items.Add(new { Id = "18974", Nombre = "Mariona", Apellido = "Guardia", Psicologo = "Abel" });
            datagridBuscar.Items.Add(new { Id = "18974", Nombre = "Mariona", Apellido = "Guardia", Psicologo = "Abel" });
            datagridBuscar.Items.Add(new { Id = "18974", Nombre = "Mariona", Apellido = "Guardia", Psicologo = "Abel" });
            datagridBuscar.Items.Add(new { Id = "18974", Nombre = "Mariona", Apellido = "Guardia", Psicologo = "Abel" });
            datagridBuscar.Items.Add(new { Id = "18974", Nombre = "Mariona", Apellido = "Guardia", Psicologo = "Abel" });
            datagridBuscar.Items.Add(new { Id = "18974", Nombre = "Mariona", Apellido = "Guardia", Psicologo = "Abel" });
            datagridBuscar.Items.Add(new { Id = "18974", Nombre = "Mariona", Apellido = "Guardia", Psicologo = "Abel" });
            datagridBuscar.Items.Add(new { Id = "18974", Nombre = "Mariona", Apellido = "Guardia", Psicologo = "Abel" });
            datagridBuscar.Items.Add(new { Id = "18974", Nombre = "Mariona", Apellido = "Guardia", Psicologo = "Abel" });
            datagridBuscar.Items.Add(new { Id = "18974", Nombre = "Mariona", Apellido = "Guardia", Psicologo = "Abel" });
            datagridBuscar.Items.Add(new { Id = "18974", Nombre = "Mariona", Apellido = "Guardia", Psicologo = "Abel" });
            datagridBuscar.Items.Add(new { Id = "18974", Nombre = "Mariona", Apellido = "Guardia", Psicologo = "Abel" });
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void datagridBuscar_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
