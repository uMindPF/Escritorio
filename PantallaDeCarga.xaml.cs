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
using System.Windows.Threading;

namespace uMind
{
    /// <summary>
    /// Lógica de interacción para PantallaDeCarga.xaml
    /// </summary>
    public partial class PantallaDeCarga : Window
    {
        private DispatcherTimer temporizador;
        public PantallaDeCarga()
        {
            InitializeComponent();
            temporizador = new DispatcherTimer();
            temporizador.Interval = TimeSpan.FromSeconds(3);
            temporizador.Tick += temporizador_Tick;
            temporizador.Start();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(0.1);

            // Establecer el valor máximo de la ProgressBar
            progressbar.Maximum = 15;

            // Iniciar el timer
            timer.Tick += (sender, args) =>
            {
                // Incrementar el valor de la ProgressBar
                progressbar.Value += 1;

                // Comprobar si la ProgressBar ha alcanzado su valor máximo
                if (progressbar.Value == progressbar.Maximum)
                {
                    // Detener el timer
                    timer.Stop();
                }
            };
            timer.Start();
        }

        private void temporizador_Tick(object sender, EventArgs e)
        {
            Login inicio = new Login();
            temporizador.Stop();
            this.Close();
            inicio.Show();

        }
    }
}
