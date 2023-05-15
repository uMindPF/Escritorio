using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using uMind.Logica;
using uMind.Model;
using uMind.Service;
using System.IO;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;


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

        private void exportData()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo de Word|*.docx";
            saveFileDialog.Title = "Exportar datos";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(saveFileDialog.FileName, WordprocessingDocumentType.Document))
                {
                    /*
                    MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                    mainPart.Document = new Document();
                    Body body = mainPart.Document.AppendChild(new Body());
                    StyleDefinitionsPart styleDefinitionsPart = mainPart.AddNewPart<StyleDefinitionsPart>();
                    styleDefinitionsPart.Styles = new Styles();

                    Paragraph titleParagraph = body.AppendChild(new Paragraph());
                    titleParagraph.ParagraphProperties = new ParagraphProperties(new ParagraphStyleId() { Val = "Title" });
                    titleParagraph.AppendChild(new Run(new Text("Registros del paciente " + TextNombre.Text)));

                    Paragraph paragraph = body.AppendChild(new Paragraph());

                    Run runId = paragraph.AppendChild(new Run());
                    runId.AppendChild(new Text("ID del paciente: "));
                    Run runIdValor = paragraph.AppendChild(new Run());
                    runIdValor.AppendChild(new Text(TextID.Text));

                    Paragraph paragraph2 = body.AppendChild(new Paragraph());

                    Run runNombre = paragraph2.AppendChild(new Run());
                    runNombre.AppendChild(new Text("Nombre del paciente: "));
                    Run runNombreValor = paragraph2.AppendChild(new Run());
                    runNombreValor.AppendChild(new Text(TextNombre.Text));

                    Paragraph paragraph3 = body.AppendChild(new Paragraph());

                    Run runApellidos = paragraph3.AppendChild(new Run());
                    runApellidos.AppendChild(new Text("Apellidos del paciente: "));
                    Run runApellidosValor = paragraph3.AppendChild(new Run());
                    runApellidosValor.AppendChild(new Text(TextApellidos.Text));

                    Paragraph paragraph4 = body.AppendChild(new Paragraph());

                    Run runTelefono = paragraph4.AppendChild(new Run());
                    runTelefono.AppendChild(new Text("Teléfono del paciente: "));
                    Run runTelefonoValor = paragraph4.AppendChild(new Run());
                    runTelefonoValor.AppendChild(new Text(TextTelefono.Text));

                    Paragraph paragraph5 = body.AppendChild(new Paragraph());

                    Run runCorreo = paragraph5.AppendChild(new Run());
                    runCorreo.AppendChild(new Text("Correo electrónico del paciente: "));
                    Run runCorreoValor = paragraph5.AppendChild(new Run());
                    runCorreoValor.AppendChild(new Text(TextCorreo.Text));

                    Paragraph paragraph6 = body.AppendChild(new Paragraph());

                    Run runPoblacion = paragraph6.AppendChild(new Run());
                    runPoblacion.AppendChild(new Text("Población del paciente: "));
                    Run runPoblacionValor = paragraph6.AppendChild(new Run());
                    runPoblacionValor.AppendChild(new Text(TextPoblacion.Text));

                    Paragraph paragraph7 = body.AppendChild(new Paragraph());

                    Run runSexo = paragraph7.AppendChild(new Run());
                    runSexo.AppendChild(new Text("Sexo del paciente: "));
                    Run runSexoValor = paragraph7.AppendChild(new Run());
                    runSexoValor.AppendChild(new Text(ComboBoxSexo.Text));

                    wordDocument.Close();
                    */
                    
                    MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                    mainPart.Document = new Document();
                    Body body = mainPart.Document.AppendChild(new Body());

                    // Agregar estilos
                    StyleDefinitionsPart styleDefinitionsPart = mainPart.AddNewPart<StyleDefinitionsPart>();
                    styleDefinitionsPart.Styles = new Styles();

                    // Título
                    Paragraph titleParagraph = body.AppendChild(new Paragraph());
                    Run titleRun = titleParagraph.AppendChild(new Run(new Text("Registros del paciente " + TextNombre.Text)));
                    RunProperties titleRunProperties = titleRun.RunProperties ?? new RunProperties();
                    titleRunProperties.Bold = new Bold();
                    titleRunProperties.FontSize = new FontSize() { Val = "48" };
                    titleRun.RunProperties = titleRunProperties; 
                    RunFonts titleRunFonts = new RunFonts() { Ascii = "Bahnschrift" };
                    titleRunProperties.Append(titleRunFonts);

                    // Datos del paciente
                    AddDataParagraph(body, "ID del paciente: ", TextID.Text);
                    AddDataParagraph(body, "Nombre del paciente: ", TextNombre.Text);
                    AddDataParagraph(body, "Apellidos del paciente: ", TextApellidos.Text);
                    AddDataParagraph(body, "Teléfono del paciente: ", TextTelefono.Text);
                    AddDataParagraph(body, "Correo electrónico del paciente: ", TextCorreo.Text);
                    AddDataParagraph(body, "Población del paciente: ", TextPoblacion.Text);
                    AddDataParagraph(body, "Sexo del paciente: ", ComboBoxSexo.Text);

                    wordDocument.Close();
                }
            }
        }

        private void AddDataParagraph(Body body, string labelText, string valueText)
        {
            Paragraph paragraph = body.AppendChild(new Paragraph());
            paragraph.AppendChild(new Run(new Text(labelText))
            {
                RunProperties = new RunProperties(new Bold() { Val = true }, new Color() { Val = "2E74B5" })
            });

            paragraph.ParagraphProperties = new ParagraphProperties(new SpacingBetweenLines() { After = "0" });
            paragraph.ParagraphProperties.Append(new RunFonts() { Ascii = "Bahnschrift" });

            paragraph.AppendChild(new Run(new Text(valueText)));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            exportData();
        }
    }
}
