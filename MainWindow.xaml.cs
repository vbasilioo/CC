using CC.Controller;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e){}

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e){}

        private void textPassword_MouseDown(object sender, MouseButtonEventArgs e){}

        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e){}

        private void Button_Click_1(object sender, RoutedEventArgs e){}

        private void Border_MouseDown(object sender, MouseButtonEventArgs e){}

        private void textEmail_MouseDown(object sender, MouseButtonEventArgs e){}

        private void txtEmail_TextChanged_1(object sender, TextChangedEventArgs e){}

        private void txtPassword_PasswordChanged_1(object sender, RoutedEventArgs e){}

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string email = txtEmail.Text;
            string senha = new System.Net.NetworkCredential(string.Empty, txtPassword.SecurePassword).Password;

            if(Usuario.FazerLogin(email, senha))
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                lblErroUsuario.Visibility = Visibility.Visible;
                lblErroUsuario.Text = "E-mail ou senha incorreto.";
                txtEmail.Text = "";
                txtPassword.Clear();
            }
        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            EsqueciSenha esqueci = new EsqueciSenha();
            esqueci.Show();
            this.Hide();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            CadastrarUsuario cad = new CadastrarUsuario();
            cad.Show();
            this.Hide();
        }
    }
}
