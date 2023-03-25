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
using uMind.Service;

namespace uMind
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private async void btnEntrar_Click(object sender, RoutedEventArgs e)
        {
            errorLabel.Visibility = Visibility.Hidden;

            string username = usernameText.Text;
            string password = passwordText.Text;


            if (await LoginService.Login(username, password))
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                errorLabel.Visibility = Visibility.Visible;
            }

        }
    }
}
