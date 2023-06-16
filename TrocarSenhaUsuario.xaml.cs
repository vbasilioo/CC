using CC.Controller;
using System.Windows;

namespace CC
{
    public partial class TrocarSenhaUsuario : Window
    {
        public TrocarSenhaUsuario()
        {
            InitializeComponent();
            CampoNovaSenha.Visibility = Visibility.Collapsed;
            CampoConfirmarSenha.Visibility = Visibility.Collapsed;
            labelNovaSenha.Visibility = Visibility.Collapsed;
            labelConfirmarSenha.Visibility = Visibility.Collapsed;
            LabelSenhaIncorretaPadrao.Visibility = Visibility.Collapsed;
            LabelSucesso.Visibility = Visibility.Collapsed;
            BotaoRedefinir2.Visibility = Visibility.Collapsed;  
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(CampoSenhaAtual.Password == Usuario.UsuarioLogado.Senha)
            {
                LabelSenhaIncorretaPadrao.Visibility= Visibility.Collapsed;
                labelNovaSenha.Visibility = Visibility.Visible;
                CampoNovaSenha.Visibility = Visibility.Visible;
                labelConfirmarSenha.Visibility = Visibility.Visible;
                CampoConfirmarSenha.Visibility = Visibility.Visible;

                LabelSucesso.Visibility = Visibility.Collapsed;
                BotaoRedefinir.Visibility = Visibility.Collapsed;
                BotaoRedefinir2.Visibility = Visibility.Visible;
            }else{
                LabelSenhaIncorretaPadrao.Visibility = Visibility.Visible;
                LabelSucesso.Visibility = Visibility.Collapsed;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void BotaoRedefinir2_Click(object sender, RoutedEventArgs e)
        {
            if(CampoNovaSenha.Password == CampoConfirmarSenha.Password){
                Usuario.UsuarioLogado.Senha = CampoNovaSenha.Password;
                LabelSucesso.Visibility = Visibility.Visible;
            }else
                LabelSucesso.Visibility = Visibility.Collapsed;
        }
    }
}
