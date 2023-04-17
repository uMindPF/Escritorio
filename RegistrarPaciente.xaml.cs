using System;
using System.Collections.Generic;
using System.Windows;
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

        public RegistrarPaciente()
        {
            InitializeComponent();

            getDoctors();
            setSexo();
        }

        private async void getDoctors()
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
            if (TextNombre.Text == "" || TextApellidos.Text == "" || TextTelefono.Text == "" ||
                TextCorreo.Text == "" || DatePickerAlta.Text == "" || DatePickerNacimiento.Text == "" ||
                ComboBoxDoctor.SelectedIndex == -1 || ComboBoxSexo.SelectedIndex == -1) return;

            Paciente paciente = new Paciente();
            paciente.nombre = TextNombre.Text;
            paciente.apellidos = TextApellidos.Text;
            paciente.telefono = TextTelefono.Text;
            paciente.email = TextCorreo.Text;
            paciente.poblacion = TextPoblacion.Text;
            paciente.sexo = ComboBoxSexo.Text;
            paciente.fechaAlta = DatePickerAlta.Text;
            paciente.doctor = doctores[ComboBoxDoctor.SelectedIndex];

            string pattern = "dd/MM/yyyy";
            DateTime fechaNacimiento = DateTime.ParseExact(paciente.fechaNacimiento, pattern, null);
            DateTime fechaAlta = DateTime.ParseExact(paciente.fechaAlta, pattern, null);
            paciente.fechaNacimiento = fechaNacimiento.ToString("yyyy-MM-dd");
            paciente.fechaAlta = fechaAlta.ToString("yyyy-MM-dd");

            PacienteService.savePaciente(paciente);
        }
    }
}
