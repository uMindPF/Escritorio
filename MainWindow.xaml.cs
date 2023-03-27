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

        private List<Doctor> doctores;

        public MainWindow()
        {
            InitializeComponent();

            getDoctoresAsync();
            getCitasAsync();
            getPacientesAsync();

            //Prueba combobox psicologos
            /*
            cbPsicologo.Items.Add("08291 Abel");
            cbPsicologo.Items.Add("01154 Laura");
            cbPsicologo.Items.Add("32189 Alba");
            */

            //Pruebas datos datagrid Citas
            /*
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
            */

            //Prueba datos datagrid Pacientes
            /*
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
            */
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

        private async void changeSelectedDoctor(object sender, RoutedEventArgs e)
        {
            int selectedIndex = cbPsicologo.SelectedIndex;

            if (selectedIndex == -1)
            {
                return;
            }

            var citas = await CitaService.getCitasDoctor(doctores[selectedIndex].id);
            dataGridCitas.Items.Clear();

            if (citas == null)
            {
                return;
            }

            displayCitas(citas);
        }

        private async void changeSelectedDate(object sender, EventArgs e)
        {
            DateTime? selectedDate = datePickerCita.SelectedDate;

            if (selectedDate == null)
            {
                getCitasAsync();
                return;
            }

            dataGridCitas.Items.Clear();

            var citas = await CitaService.getCitasDate((DateTime)selectedDate);

            if (citas == null)
            {
                return;
            }

            dataGridCitas.Items.Clear();
            displayCitas(citas);

        }

        private async void getDoctoresAsync()
        {
            var doctors = await DoctorService.getDoctors();
            doctores = doctors;
            cbPsicologo.Items.Clear();

            if (doctors == null)
            {
                return;
            }

            try
            {
                foreach (var doctor in doctors)
                {
                    cbPsicologo.Items.Add(doctor.nombre);
                }
            }
            catch (Exception ex)
            { }
        }

        private async void getCitasAsync()
        {

            var citas = await CitaService.getCitas();

            dataGridCitas.Items.Clear();

            if (citas == null)
            {
                return;
            }

            displayCitas(citas);

        }

        private async void getPacientesAsync()
        {
            var pacientes = await PacienteService.getPacientes();
            dataGridPacientes2.Items.Clear();

            if (pacientes == null)
            {
                return;
            }

            displayPacientes(pacientes);
        }

        private void displayCitas(List<Citas> citas)
        {
            try
            {
                foreach (var cita in citas)
                {
                    dataGridCitas.Items.Add(new
                    {
                        IdCita = cita.id,
                        IdPaciente = cita.paciente.id,
                        NombrePaciente = cita.paciente.nombre,
                        ApellidoPaciente = cita.paciente.apellidos,
                        Psicologo = cita.doctor.nombre,
                        Dia = cita.dia,
                        Hora = cita.hora,
                        Estado = cita.estado,
                        TipoVisita = cita.tipoVista
                    });
                }
            }
            catch (Exception ex)
            { }
        }

        private void displayPacientes(List<Pacientes> pacientes)
        {
            try
            {
                foreach (var paciente in pacientes)
                {
                    dataGridPacientes2.Items.Add(new
                    {
                        Id = paciente.id,
                        Nombre = paciente.nombre,
                        Psicologo = paciente.doctor.nombre,
                        Poblacion = paciente.poblacion,
                        Sexo = paciente.sexo,
                        FechaNacimiento = paciente.fechaNacimiento,
                        FechaInicio = paciente.fechaAlta,
                        Correo = paciente.email,
                        Telefono = paciente.telefono
                    });
                }
            } catch (Exception ex) { }
        }

        private async void idPaciente(object sender, TextChangedEventArgs e)
        {
            TextBox senderTextBox = (TextBox) sender;

            dataGridPacientes2.Items.Clear();

            if(senderTextBox.Text == "")
            {
                getPacientesAsync();
                return;
            }

            try
            {
                int id = int.Parse(senderTextBox.Text);

                Pacientes paciente = await PacienteService.getPacienteId(id);

                List<Pacientes> pacientes = new List<Pacientes>();
                if (paciente != null)
                {
                    pacientes.Add(paciente);
                    displayPacientes(pacientes);
                }

            } catch (Exception ex) {
                senderTextBox.Text = "";
            }
        }

        private async void nombrePaciente(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox) sender;

            dataGridPacientes2.Items.Clear();

            if (textBox.Text == "")
            {
                getPacientesAsync();
                return;
            }

            try
            {
                var pacientes = await PacienteService.getPacientesNombre(textBox.Text);
                if (pacientes == null)
                {
                    return;
                }
                displayPacientes(pacientes);
            } catch (Exception ex) { }
            
        }
    }
}
