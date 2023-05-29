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
            LabelSucesso.Visibility = Visibility.Collapsed;
            LabelFracasso.Visibility = Visibility.Collapsed;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(Usuario.VerificarEmailCadastrado(campoEmail.Text)){
                Administracao.AdicionarSenhaEsquecida(campoEmail.Text, CampoAssunto.Text);
                LabelSucesso.Visibility = Visibility.Visible;
                LabelFracasso.Visibility = Visibility.Collapsed;
            }
            else{
                LabelFracasso.Visibility = Visibility.Visible;
                LabelSucesso.Visibility = Visibility.Collapsed;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow login = new MainWindow();
            login.Show();
            this.Hide();
        }
    }
}
