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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CC.UserControls
{
    public partial class AdministracaoUC : UserControl
    {
        public AdministracaoUC()
        {
            InitializeComponent();
            CarregarEmails();
        }

        private void CarregarEmails()
        {
            List<Administracao> emails = Administracao.ListarSenhasEsquecidas();
            GridEmails.Items.Clear();
            GridEmails.ItemsSource = emails;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CadastrarCoordenador cadcood = new CadastrarCoordenador();
            cadcood.Show();
        }

        private void BtnEditar_Click(object sender, RoutedEventArgs e)
        {
            AlterarSenha alterar = new AlterarSenha();
            alterar.Show();
        }
    }
}
