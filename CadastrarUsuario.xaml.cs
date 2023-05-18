using CC.Controller;
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
using System.Security.Cryptography;

namespace CC
{
    /// <summary>
    /// Lógica interna para CadastrarUsuario.xaml
    /// </summary>
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
            if(txtCargo.Text == "Candidato" || txtCargo.Text == "Empresa"){

                string senha = txtSenha.Text;
                string senhaCriptografada = CriptografarSenha(txtSenha.Text);

                Usuario novoUsuario = new Usuario
                {
                    Nome = txtNome.Text,
                    Email = txtEmail.Text,
                    Senha = senha,
                    SenhaCriptografada = senhaCriptografada,
                    Cargo = txtCargo.Text,
                    DataNascimento = int.Parse(txtIdade.Text),
                    Endereco = txtResidencia.Text,
                };
            }else if(txtCargo.Text == "candidato" || txtCargo.Text == "empresa" || txtCargo.Text == "coordenador"
                || txtCargo.Text == "Coordenador")
            {
                MessageBox.Show("Você inseriu um cargo inválido. Tente: Empresa ou Candidato");
            }
        }

        public static string CriptografarSenha(string senha)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(senha);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}
