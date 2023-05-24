using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
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

            usernameText.Text = Properties.Settings.Default.Username;
            passwordText.Password = Properties.Settings.Default.Password;
        }

        private async void btnEntrar_Click(object sender, RoutedEventArgs e)
        {
            errorLabel.Visibility = Visibility.Hidden;

            string username = usernameText.Text;
            string password = passwordText.Password;


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
