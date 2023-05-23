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

namespace CC
{
    public partial class RedefinirSenha : Window
    {
        public RedefinirSenha()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(Usuario.VerificarEmailCadastrado(campoEmail.Text)){
                Administracao.AdicionarSenhaEsquecida(campoEmail.Text);
                MessageBox.Show("Sua mensagem foi enviada para o administrador!");
            }
            else
                MessageBox.Show("E-mail inválido.");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow login = new MainWindow();
            login.Show();
            this.Hide();
        }
    }
}
