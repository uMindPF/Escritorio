using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using uMind.Model;
using uMind.Service;

namespace uMind
{
    /// <summary>
    /// Lógica de interacción para BuscarPaciente.xaml
    /// </summary>
    public partial class BuscarPaciente : Window
    {
        private List<Paciente> pacientes;

        public BuscarPaciente()
        {
            InitializeComponent();

            cargarPacientes();
        }

        private async void cargarPacientes()
        {
            pacientes = await PacienteService.getPacientes();
            datagridBuscar.Items.Clear();

            if (pacientes != null)
            {
                displayPacientes(pacientes);
            }
        }

        private void displayPacientes(List<Paciente> pacientes)
        {
            foreach (var paciente in pacientes)
            {
	            if (paciente.fechaBaja == "")
	            {
		            datagridBuscar.Items.Add(new
		            {
			            Id = paciente.id, Nombre = paciente.nombre,
			            Apellido = paciente.apellidos, Psicologo = paciente.doctor.nombre
		            });
	            }
            }   
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void datagridBuscar_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var pacienteSelected = datagridBuscar.SelectedItem;

            if (pacienteSelected == null) return;
            
            int id = (int)pacienteSelected.GetType().GetProperty("Id").GetValue(pacienteSelected, null);

            foreach (var paciente in pacientes)
            {
	            if (paciente.id == id)
	            {
		            RegistrarCita registarCita = new RegistrarCita(paciente);
					registarCita.ShowDialog();
				}
            }

            this.Close();
        }

        private async void TextChangedId(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            datagridBuscar.Items.Clear();
            if (textBox.Text == "")
            {
                cargarPacientes();
                return;
            }
            try
            {

                int id = int.Parse(textBox.Text);
                var paciente = await PacienteService.getPacienteId(id);
                List<Paciente> pacientes = new List<Paciente>();
                pacientes.Add(paciente);
                datagridBuscar.Items.Clear();
                if (paciente != null)
                {
                    displayPacientes(pacientes);
                }
                
            } catch (Exception ex)
            {
                textBox.Text = "";
            }
        }

        private async void TextChangedName(object sender, TextChangedEventArgs e)
        {
            datagridBuscar.Items.Clear();

            TextBox textBox = sender as TextBox;

            if (textBox.Text == "")
            {
                cargarPacientes();
                return;
            }

            var pacientes = await PacienteService.getPacientesNombre(textBox.Text);
            if (pacientes != null)
            {
                displayPacientes(pacientes);
            }

        }
    }
}
