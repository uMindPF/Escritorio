using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using uMind.Logica;
using uMind.Model;
using uMind.Service;

namespace uMind
{
    /// <summary>
    /// Lógica de interacción para RegistrarPaciente.xaml
    /// </summary>
    public partial class RegistrarPaciente : Window
    {
        private List<Doctor> doctores;
        private MainWindow mainWindow;

        public RegistrarPaciente(MainWindow mainWindow)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;

            getDoctors();
            setSexo();
        }

        public RegistrarPaciente(Paciente paciente, MainWindow mainWindow)
        {
			InitializeComponent();

            this.mainWindow = mainWindow;
			
			setSexo();
            setPaciente(paciente);
        }

        private async void setPaciente(Paciente paciente)
        {
            TextID.Text = paciente.id.ToString();
            TextNombre.Text = paciente.nombre;
            TextApellidos.Text = paciente.apellidos;
            TextTelefono.Text = paciente.telefono;
            TextCorreo.Text = paciente.email;
            TextPoblacion.Text = paciente.poblacion;
            ComboBoxSexo.Text = paciente.sexo;
            DatePickerNacimiento.Text = paciente.fechaNacimiento;
            DatePickerAlta.Text = paciente.fechaAlta;

            await getDoctors();

			for (int i = 0; i < doctores.Count; i++)
            {
	            if (doctores[i].id == paciente.doctor.id)
	            {
					ComboBoxDoctor.SelectedIndex = i;
					break;
				}
			}
        }

        private async Task getDoctors()
        {
	        doctores = await DoctorService.getDoctors();

	        foreach (Doctor doctor in doctores)
	        {
		        ComboBoxDoctor.Items.Add(doctor.nombre + " " + doctor.apellidos);
	        }
        }

        private void setSexo()
        {
            foreach (var sexo in Enum.GetNames(typeof(Sexo)))
				ComboBoxSexo.Items.Add(sexo);
        }

        private void btnAtras_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
	        guardarCita();
        }

        private async void guardarCita()
        {
	        if (TextNombre.Text == "" || TextApellidos.Text == "" || TextTelefono.Text == "" ||
	            TextCorreo.Text == "" || DatePickerAlta.Text == "" || DatePickerNacimiento.Text == "" ||
	            ComboBoxDoctor.SelectedIndex == -1 || ComboBoxSexo.SelectedIndex == -1)
	        {
		        MessageBox.Show("Rellena todos los campos");
		        return;
	        }

	        Paciente paciente = new Paciente();
	        paciente.id = TextID.Text == "" ? 0 : int.Parse(TextID.Text);
	        paciente.nombre = TextNombre.Text;
	        paciente.apellidos = TextApellidos.Text;
	        paciente.telefono = TextTelefono.Text;
	        paciente.email = TextCorreo.Text;
	        paciente.poblacion = TextPoblacion.Text;
	        paciente.sexo = ComboBoxSexo.Text;

	        //paciente.fechaNacimiento = DatePickerNacimiento.DisplayDate.ToString("yyyy-MM-dd");
	        //paciente.fechaAlta = DatePickerAlta.DisplayDate.ToString("yyyy-MM-dd");

            paciente.fechaNacimiento = Fechas.cambiarFormato(DatePickerNacimiento.Text);
            paciente.fechaAlta = Fechas.cambiarFormato(DatePickerAlta.Text);

            paciente.doctor = doctores[ComboBoxDoctor.SelectedIndex];

	        try
	        {
		        await PacienteService.savePaciente(paciente);
		        MessageBox.Show("Paciente registrado");
		        this.Close();
		        mainWindow.getPacientesAsync();
	        }
	        catch (Exception e)
	        {
		        MessageBox.Show("Error al registrar el Paciente: \n"+e);
	        }
        }
    }
}
