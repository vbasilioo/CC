using CC.Controller;
using System.Windows;
using System.Windows.Input;

namespace CC
{
    public partial class AlterarSenha : Window
    {
        public AlterarSenha()
        {
            InitializeComponent();
            LabelSucesso.Visibility = Visibility.Collapsed;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Usuario.RedefinirSenha(CampoEmail.Text, CampoSenha.Password);
            LabelSucesso.Visibility = Visibility.Visible;
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
    }
}
