using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using uMind.Logica;
using uMind.Model;
using uMind.Service;

namespace uMind
{
    /// <summary>
    /// Lógica de interacción para RegistrarCita.xaml
    /// </summary>
    public partial class RegistrarCita : Window
    {
	    Cita cita;
	    private MainWindow main;

	    private List<Doctor> doctors;
        private List<DateTime> horasDisponibles;

		public RegistrarCita(Paciente paciente, MainWindow main)
        {
	        InitializeComponent();

            loadComboBoxs();

            TextBoxID.Text = paciente.id.ToString();
            TextBoxName.Text = paciente.nombre;

            cita = new Cita();
            cita.paciente = paciente;

            this.main = main;
        }

        public RegistrarCita(Cita cita, MainWindow main)
        {
            InitializeComponent();

            loadComboBoxs();

			TextBoxID.Text = cita.paciente.id.ToString();
			TextBoxName.Text = cita.paciente.nombre;

            this.cita = cita;

            ComboBoxDoctor.Text = cita.doctor.nombre + " " + cita.doctor.apellidos;
            DatePickerDia.Text = cita.dia;
            ComboBoxHora.Text = cita.hora;

            ComboBoxDuracion.Text = cita.duracion.ToString();
            ComboBoxEstado.Text = cita.estado;
            ComboBoxTipoVisita.Text = cita.tipoVista;

            this.main = main;
        }

        private void loadComboBoxs()
        {
            getDoctors();

            foreach (var estado in Enum.GetNames(typeof(Estado)))
		        ComboBoxEstado.Items.Add(estado);

            foreach (var visita in Enum.GetNames(typeof(TiposVisita)))
                ComboBoxTipoVisita.Items.Add(visita);
        }

        private async void getHours()
        {
	        try
	        {
		        Doctor doctor = cita.doctor;
		        DateTime date = DateTime.Parse(DatePickerDia.Text);

		        if (ComboBoxDoctor.SelectedIndex != -1)
		        {
					doctor = doctors[ComboBoxDoctor.SelectedIndex];
				}

		        if (date == null || doctor == null)
		        {
			        return;
		        }

		        horasDisponibles = await CalcularHora.dayHours(date, doctor.id);

                ComboBoxHora.Items.Clear();

		        foreach (var hora in horasDisponibles)
		        {
			        ComboBoxHora.Items.Add(hora.ToString("HH:mm"));
		        }

	        }
	        catch (Exception e)
	        { }
		}

        private async void getDoctors()
        {
            doctors = await DoctorService.getDoctors();

            foreach (var doc in doctors)
            {
	            ComboBoxDoctor.Items.Add(doc.nombre + " " + doc.apellidos);
            }
        }

        private void getDuracion()
        {
            string horaSelecionada = ComboBoxHora.Text;

            if (horaSelecionada == "")
            {
	            return;
            }

            DateTime hora = DateTime.ParseExact(horaSelecionada, "HH:mm", null);

            ComboBoxDuracion.Items.Clear();

            hora = hora.AddMinutes(30);
            if (horasDisponibles.Contains(hora))
            {
                ComboBoxDuracion.Items.Add("30");
                hora = hora.AddMinutes(15);
                if (horasDisponibles.Contains(hora))
                {
					ComboBoxDuracion.Items.Add("45");
					hora = hora.AddMinutes(15);
					if (horasDisponibles.Contains(hora))
					{
						ComboBoxDuracion.Items.Add("60");
					}
				}
            }
        }

        private void btnAtras_Click(object sender, RoutedEventArgs e)
        {
	        this.Close();
        }

        private async void guardarCita()
        {
	        if (DatePickerDia.Text == "" || ComboBoxDoctor.SelectedIndex == -1 ||
	            ComboBoxDuracion.SelectedIndex == -1 || ComboBoxEstado.SelectedIndex == -1 ||
	            ComboBoxHora.SelectedIndex == -1 || ComboBoxTipoVisita.SelectedIndex == -1)
	        {
		        MessageBox.Show("Rellena todos los campos");
		        return;
	        }

	        //cita.dia = DatePickerDia.DisplayDate.ToString("yyyy-MM-dd");
	        cita.dia = Fechas.cambiarFormato(DatePickerDia.Text);

	        cita.hora = ComboBoxHora.Text;
	        cita.duracion = Double.Parse(ComboBoxDuracion.Text);
	        cita.estado = ComboBoxEstado.Text;
	        cita.tipoVista = ComboBoxTipoVisita.Text;

            cita.doctor = doctors[ComboBoxDoctor.SelectedIndex];

	        try
	        {
		        await CitaService.saveCita(cita);
                MessageBox.Show("Cita guardada");
                this.Close();

                main.getCitasAsync();
			}
	        catch (Exception e)
	        {
                MessageBox.Show("Error al guardar la Cita: \n"+e);
	        }

        }

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
	        guardarCita();
        }


        private void DatePickerDia_OnSelectedDateChanged(object? sender, SelectionChangedEventArgs e)
        {
	        getHours();
        }

        private void ComboBoxHora_OnDropDownClosed(object? sender, EventArgs e)
        {
	        getDuracion();
        }

        private void ComboBoxDoctor_OnDropDownClosed(object? sender, EventArgs e)
        {
			getHours();
		}
    }
}
