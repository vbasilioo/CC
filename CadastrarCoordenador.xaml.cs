using System;
using System.Globalization;
using System.Windows;
using BCrypt.Net;
using CC.Controller;

namespace CC
{
    public partial class CadastrarCoordenador : Window
    {
        public CadastrarCoordenador()
        {
            InitializeComponent();
            LabelSucesso.Visibility = Visibility.Collapsed;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nome = CampoNome.Text;
            string email = CampoEmail.Text;
            string endereco = CampoEndereco.Text;
            string senha = CampoSenha.Password;
            string senhacriptografada = BCrypt.Net.BCrypt.HashPassword(senha);

            string dataNascimentoString = CampoNascimento.Text;
            DateTime dataNascimento;

            if(nome.Contains(" ")){
                if (DateTime.TryParseExact(dataNascimentoString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataNascimento))
                {
                    int idade = Usuario.CalcularIdade(dataNascimento);

                    Usuario novoCoordenador = new Usuario
                    {
                        Nome = nome,
                        Email = email,
                        Senha = senha,
                        SenhaCriptografada = senhacriptografada,
                        Cargo = "Coordenador",
                        DataNascimento = idade,
                        Endereco = endereco,
                    };

                    Usuario.AdicionarUsuario(novoCoordenador);
                    LabelSucesso.Visibility = Visibility.Visible;
                }
            }else
                MessageBox.Show("O usuário deve conter nome e sobrenome.");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
