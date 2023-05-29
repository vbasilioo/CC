using CC.Controller;
using System.Windows;
using System.Windows.Input;
using BCrypt.Net;
using System.Globalization;
using System;

namespace CC
{
    public partial class CadastrarUsuario : Window
    {
        public CadastrarUsuario()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left){
                this.DragMove();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow login = new MainWindow();
            login.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string senha = txtSenha.Text;
            string senhaCriptografada = BCrypt.Net.BCrypt.HashPassword(senha);

            string dataNascimentoString = txtIdade.Text;
            DateTime dataNascimento;

            if (DateTime.TryParseExact(dataNascimentoString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataNascimento))
            {
                int idade = Usuario.CalcularIdade(dataNascimento);

                Usuario novoUsuario = new Usuario
                {
                    Nome = txtNome.Text,
                    Email = txtEmail.Text,
                    Senha = senha,
                    SenhaCriptografada = senhaCriptografada,
                    Cargo = txtCargo.Text,
                    DataNascimento = idade,
                    Endereco = txtResidencia.Text,
                };

                Usuario.AdicionarUsuario(novoUsuario);
            }
        }
    }
}
