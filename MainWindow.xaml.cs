using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
using uMind.Model;
using uMind.Service;

namespace uMind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            getDoctoresAsync();
            getCitasAsync();
            getPacientesAsync();

            //Prueba combobox psicologos
            cbPsicologo.Items.Add("08291 Abel");
            cbPsicologo.Items.Add("01154 Laura");
            cbPsicologo.Items.Add("32189 Alba");

            //Pruebas datos datagrid Citas
            dataGridCitas.Items.Add(new { IdCita = 13024, IdPaciente = 64781, NombrePaciente = "Mariona Guàrdia", ApellidoPaciente = "Guardia", Psicologo = "08291 Abel", Dia = "25/03/23", Hora = "18:30", Estado = "Pendiente", TipoVisita = "Mantenimiento" });
            dataGridCitas.Items.Add(new { IdCita = 13024, IdPaciente = 64781, NombrePaciente = "Mariona Guàrdia", ApellidoPaciente = "Guardia", Psicologo = "08291 Abel", Dia = "25/03/23", Hora = "18:30", Estado = "Pendiente", TipoVisita = "Mantenimiento" });
            dataGridCitas.Items.Add(new { IdCita = 13024, IdPaciente = 64781, NombrePaciente = "Mariona Guàrdia", ApellidoPaciente = "Guardia", Psicologo = "08291 Abel", Dia = "25/03/23", Hora = "18:30", Estado = "Pendiente", TipoVisita = "Mantenimiento" });
            dataGridCitas.Items.Add(new { IdCita = 13024, IdPaciente = 64781, NombrePaciente = "Mariona Guàrdia", ApellidoPaciente = "Guardia", Psicologo = "08291 Abel", Dia = "25/03/23", Hora = "18:30", Estado = "Pendiente", TipoVisita = "Mantenimiento" });
            dataGridCitas.Items.Add(new { IdCita = 13024, IdPaciente = 64781, NombrePaciente = "Mariona Guàrdia", ApellidoPaciente = "Guardia", Psicologo = "08291 Abel", Dia = "25/03/23", Hora = "18:30", Estado = "Pendiente", TipoVisita = "Mantenimiento" });
            dataGridCitas.Items.Add(new { IdCita = 13024, IdPaciente = 64781, NombrePaciente = "Mariona Guàrdia", ApellidoPaciente = "Guardia", Psicologo = "08291 Abel", Dia = "25/03/23", Hora = "18:30", Estado = "Pendiente", TipoVisita = "Mantenimiento" });
            dataGridCitas.Items.Add(new { IdCita = 13024, IdPaciente = 64781, NombrePaciente = "Mariona Guàrdia", ApellidoPaciente = "Guardia", Psicologo = "08291 Abel", Dia = "25/03/23", Hora = "18:30", Estado = "Pendiente", TipoVisita = "Mantenimiento" });
            dataGridCitas.Items.Add(new { IdCita = 13024, IdPaciente = 64781, NombrePaciente = "Mariona Guàrdia", ApellidoPaciente = "Guardia", Psicologo = "08291 Abel", Dia = "25/03/23", Hora = "18:30", Estado = "Pendiente", TipoVisita = "Mantenimiento" });
            dataGridCitas.Items.Add(new { IdCita = 13024, IdPaciente = 64781, NombrePaciente = "Mariona Guàrdia", ApellidoPaciente = "Guardia", Psicologo = "08291 Abel", Dia = "25/03/23", Hora = "18:30", Estado = "Pendiente", TipoVisita = "Mantenimiento" });
            dataGridCitas.Items.Add(new { IdCita = 13024, IdPaciente = 64781, NombrePaciente = "Mariona Guàrdia", ApellidoPaciente = "Guardia", Psicologo = "08291 Abel", Dia = "25/03/23", Hora = "18:30", Estado = "Pendiente", TipoVisita = "Mantenimiento" });
            dataGridCitas.Items.Add(new { IdCita = 13024, IdPaciente = 64781, NombrePaciente = "Mariona Guàrdia", ApellidoPaciente = "Guardia", Psicologo = "08291 Abel", Dia = "25/03/23", Hora = "18:30", Estado = "Pendiente", TipoVisita = "Mantenimiento" });
            dataGridCitas.Items.Add(new { IdCita = 13024, IdPaciente = 64781, NombrePaciente = "Mariona Guàrdia", ApellidoPaciente = "Guardia", Psicologo = "08291 Abel", Dia = "25/03/23", Hora = "18:30", Estado = "Pendiente", TipoVisita = "Mantenimiento" });
            dataGridCitas.Items.Add(new { IdCita = 13024, IdPaciente = 64781, NombrePaciente = "Mariona Guàrdia", ApellidoPaciente = "Guardia", Psicologo = "08291 Abel", Dia = "25/03/23", Hora = "18:30", Estado = "Pendiente", TipoVisita = "Mantenimiento" });
            dataGridCitas.Items.Add(new { IdCita = 13024, IdPaciente = 64781, NombrePaciente = "Mariona Guàrdia", ApellidoPaciente = "Guardia", Psicologo = "08291 Abel", Dia = "25/03/23", Hora = "18:30", Estado = "Pendiente", TipoVisita = "Mantenimiento" });

            //Prueba datos datagrid Pacientes
            dataGridPacientes2.Items.Add(new { Id = 1, Nombre = "Mariona Guàrdia", Psicologo = "08291 Abel", Poblacion = "Ripollet", Sexo = "Femenino", FechaNacimiento = "19/07/1997", FechaInicio = "23/03/22", Correo = "marionaguardia19@gmail.com", Telefono = "649437248" });
            dataGridPacientes2.Items.Add(new { Id = 1, Nombre = "Mariona Guàrdia", Psicologo = "08291 Abel", Poblacion = "Ripollet", Sexo = "Femenino", FechaNacimiento = "19/07/1997", FechaInicio = "23/03/22", Correo = "marionaguardia19@gmail.com", Telefono = "649437248" });
            dataGridPacientes2.Items.Add(new { Id = 1, Nombre = "Mariona Guàrdia", Psicologo = "08291 Abel", Poblacion = "Ripollet", Sexo = "Femenino", FechaNacimiento = "19/07/1997", FechaInicio = "23/03/22", Correo = "marionaguardia19@gmail.com", Telefono = "649437248" });
            dataGridPacientes2.Items.Add(new { Id = 1, Nombre = "Mariona Guàrdia", Psicologo = "08291 Abel", Poblacion = "Ripollet", Sexo = "Femenino", FechaNacimiento = "19/07/1997", FechaInicio = "23/03/22", Correo = "marionaguardia19@gmail.com", Telefono = "649437248" });
            dataGridPacientes2.Items.Add(new { Id = 1, Nombre = "Mariona Guàrdia", Psicologo = "08291 Abel", Poblacion = "Ripollet", Sexo = "Femenino", FechaNacimiento = "19/07/1997", FechaInicio = "23/03/22", Correo = "marionaguardia19@gmail.com", Telefono = "649437248" });
            dataGridPacientes2.Items.Add(new { Id = 1, Nombre = "Mariona Guàrdia", Psicologo = "08291 Abel", Poblacion = "Ripollet", Sexo = "Femenino", FechaNacimiento = "19/07/1997", FechaInicio = "23/03/22", Correo = "marionaguardia19@gmail.com", Telefono = "649437248" });
            dataGridPacientes2.Items.Add(new { Id = 1, Nombre = "Mariona Guàrdia", Psicologo = "08291 Abel", Poblacion = "Ripollet", Sexo = "Femenino", FechaNacimiento = "19/07/1997", FechaInicio = "23/03/22", Correo = "marionaguardia19@gmail.com", Telefono = "649437248" });
            dataGridPacientes2.Items.Add(new { Id = 1, Nombre = "Mariona Guàrdia", Psicologo = "08291 Abel", Poblacion = "Ripollet", Sexo = "Femenino", FechaNacimiento = "19/07/1997", FechaInicio = "23/03/22", Correo = "marionaguardia19@gmail.com", Telefono = "649437248" });
            dataGridPacientes2.Items.Add(new { Id = 1, Nombre = "Mariona Guàrdia", Psicologo = "08291 Abel", Poblacion = "Ripollet", Sexo = "Femenino", FechaNacimiento = "19/07/1997", FechaInicio = "23/03/22", Correo = "marionaguardia19@gmail.com", Telefono = "649437248" });
            dataGridPacientes2.Items.Add(new { Id = 1, Nombre = "Mariona Guàrdia", Psicologo = "08291 Abel", Poblacion = "Ripollet", Sexo = "Femenino", FechaNacimiento = "19/07/1997", FechaInicio = "23/03/22", Correo = "marionaguardia19@gmail.com", Telefono = "649437248" });
            dataGridPacientes2.Items.Add(new { Id = 1, Nombre = "Mariona Guàrdia", Psicologo = "08291 Abel", Poblacion = "Ripollet", Sexo = "Femenino", FechaNacimiento = "19/07/1997", FechaInicio = "23/03/22", Correo = "marionaguardia19@gmail.com", Telefono = "649437248" });
            dataGridPacientes2.Items.Add(new { Id = 1, Nombre = "Mariona Guàrdia", Psicologo = "08291 Abel", Poblacion = "Ripollet", Sexo = "Femenino", FechaNacimiento = "19/07/1997", FechaInicio = "23/03/22", Correo = "marionaguardia19@gmail.com", Telefono = "649437248" });
            dataGridPacientes2.Items.Add(new { Id = 1, Nombre = "Mariona Guàrdia", Psicologo = "08291 Abel", Poblacion = "Ripollet", Sexo = "Femenino", FechaNacimiento = "19/07/1997", FechaInicio = "23/03/22", Correo = "marionaguardia19@gmail.com", Telefono = "649437248" });
            dataGridPacientes2.Items.Add(new { Id = 1, Nombre = "Mariona Guàrdia", Psicologo = "08291 Abel", Poblacion = "Ripollet", Sexo = "Femenino", FechaNacimiento = "19/07/1997", FechaInicio = "23/03/22", Correo = "marionaguardia19@gmail.com", Telefono = "649437248" });
            dataGridPacientes2.Items.Add(new { Id = 1, Nombre = "Mariona Guàrdia", Psicologo = "08291 Abel", Poblacion = "Ripollet", Sexo = "Femenino", FechaNacimiento = "19/07/1997", FechaInicio = "23/03/22", Correo = "marionaguardia19@gmail.com", Telefono = "649437248" });

        }


        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Pacientes paciente = (Pacientes)button.Tag;
            ListarPacientes viewModel = (ListarPacientes)DataContext;
            viewModel.EliminarRegistro(paciente);
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            ModificarPaciente modificarPaciente = new ModificarPaciente();
            modificarPaciente.ShowDialog();
        }


        private void btnRegistrarCita_Click(object sender, RoutedEventArgs e)
        {
            RegistrarCita registarCita = new RegistrarCita();
            BuscarPaciente buscarPacientes = new BuscarPaciente();
            buscarPacientes.ShowDialog();
            registarCita.ShowDialog();
        }

        private void btnRegistrar_Click_1(object sender, RoutedEventArgs e)
        {
            RegistrarPaciente registrarPaciente = new RegistrarPaciente();
            registrarPaciente.ShowDialog();
        }

        private void btnModificarCita_Click(object sender, RoutedEventArgs e)
        {
            ModificarCita modificarCita = new ModificarCita();
            modificarCita.ShowDialog();
        }

        private void btnMinimizar_Click(object sender, RoutedEventArgs e)
        {
            Window mainWindow = Application.Current.MainWindow;
            mainWindow.WindowState = WindowState.Minimized;
        }

        private void btnModificar2_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void getDoctoresAsync()
        {
            var doctors = await DoctorService.getDoctors();

            try
            {
                foreach (var doctor in doctors)
                {
                    cbPsicologo.Items.Add(doctor.nombre);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private async void getCitasAsync()
        {

        }

        private async void getPacientesAsync()
        {
            var pacientes = await PacienteService.getPacientes();

            if (pacientes == null)
            {
                return;
            }

            try
            {
                foreach (var paciente in pacientes)
                {
                    dataGridPacientes2.Items.Add(new
                    {
                        Id = paciente.id, Nombre = paciente.nombre, Psicologo = paciente.doctor.nombre,
                        Poblacion = paciente.poblacion, Sexo = paciente.sexo,
                        FechaNacimiento = paciente.fechaNacimiento, FechaInicio = paciente.fechaAlta,
                        Correo = paciente.email, Telefono = paciente.telefono
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
