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
    }
}
