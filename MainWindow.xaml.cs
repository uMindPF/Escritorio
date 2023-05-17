using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Dragablz;
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
        private List<Paciente> pacientes;
        private List<Cita> citas;

        public MainWindow()
        {
            InitializeComponent();

            getDoctoresAsync();
            getPacientesAsync();
            getCitasAsync();
		}


        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnRegistrarCita_Click(object sender, RoutedEventArgs e)
        {
	        BuscarPaciente buscarPacientes = new BuscarPaciente(this);
            buscarPacientes.ShowDialog();
        }

        private void btnRegistrar_Click_1(object sender, RoutedEventArgs e)
        {
            RegistrarPaciente registrarPaciente = new RegistrarPaciente(this);
            registrarPaciente.ShowDialog();
        }

        private void btnModificarCita_Click(object sender, RoutedEventArgs e)
        {
	        Button button = (Button)sender;

	        var data = dataGridCitas.SelectedItem;
	        int id = (int)data.GetType().GetProperty("IdCita").GetValue(data, null);

	        foreach (var cita in citas)
	        {
		        if (cita.id == id)
		        {
					RegistrarCita modificarCita = new RegistrarCita(cita, this);
					modificarCita.ShowDialog();
			        break;
		        }
	        }
        }

        private void btnMinimizar_Click(object sender, RoutedEventArgs e)
        {
            Window mainWindow = Application.Current.MainWindow;
            mainWindow.WindowState = WindowState.Minimized;
        }

        private async void changeSelectedDoctor(object sender, RoutedEventArgs e)
        {
            int selectedIndex = cbPsicologo.SelectedIndex;

            if (selectedIndex == -1)
            {
                return;
            }

            if (selectedIndex == 0)
            {
                getCitasAsync();
                return;
            }

            selectedIndex--;

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
            doctores = await DoctorService.getDoctors();
            cbPsicologo.Items.Clear();
            cbPsicologo.Items.Add("Todos");

            if (doctores == null)
            {
	            return;
            }

            try
            {
                foreach (var doctor in doctores)
                {
	                cbPsicologo.Items.Add(doctor.nombre + " " + doctor.apellidos);
                }
            }
            catch (Exception ex)
            { }
        }

        public async void getCitasAsync()
        {

	        citas = await CitaService.getCitas();

            dataGridCitas.Items.Clear();

            if (citas == null)
            {
                return;
            }

            displayCitas(citas);

        }

        public async void getPacientesAsync()
        {
            pacientes = await PacienteService.getPacientes();
            dataGridPacientes2.Items.Clear();

            if (pacientes == null)
            {
	            return;
            }

            displayPacientes(pacientes);
        }

        private void displayCitas(List<Cita> citas)
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

        private void displayPacientes(List<Paciente> pacientes)
        {
            try
            {
                foreach (var paciente in pacientes)
                {
	                if (paciente.fechaBaja == "")
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

                Paciente paciente = await PacienteService.getPacienteId(id);

                List<Paciente> pacientes = new List<Paciente>();
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

        private void deletePaciente(object sender, RoutedEventArgs e)
        {
            Button button = (Button) sender;

            MessageBoxResult result = MessageBox.Show("¿Está seguro de que desea dar de baja el paciente?", "Dar de baja", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                var data = dataGridPacientes2.SelectedItem;
	            int id = (int)data.GetType().GetProperty("Id").GetValue(data, null);

	            foreach (var paciente in pacientes)
	            {
		            if (paciente.id == id)
		            {
                        paciente.fechaBaja = DateTime.Now.ToString("yyyy-MM-dd");

			            PacienteService.savePaciente(paciente);
			            break;
		            }
	            }
	            getPacientesAsync();
            }
        }

        private void btnModificarPaciente_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button) sender;

            var data = dataGridPacientes2.SelectedItem;
            int id = (int)data.GetType().GetProperty("Id").GetValue(data, null);

            foreach (var paciente in pacientes)
            {
	            if (paciente.id == id)
	            {
		            RegistrarPaciente modificarPaciente = new RegistrarPaciente(paciente, this);
					modificarPaciente.ShowDialog();
					break;
				}
			}
        }

        private void dateForward (object sender, RoutedEventArgs e)
        {
            DateTime? selectedDate = datePickerCita.SelectedDate;
            if (selectedDate == null)
            {
				return;
			}
			datePickerCita.SelectedDate = ((DateTime)selectedDate).AddDays(1);
        }

        private void dateBackward(object sender, RoutedEventArgs e)
        {
			DateTime? selectedDate = datePickerCita.SelectedDate;
			if (selectedDate == null)
			{
				return;
			}
			datePickerCita.SelectedDate = ((DateTime)selectedDate).AddDays(-1);
		}
    }
}
