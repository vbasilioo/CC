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
    
    public partial class Perfil : UserControl
    {
        public Perfil()
        {
            InitializeComponent();
            txtNome.Text = Usuario.UsuarioLogado.Nome;
            txtEmail.Text = Usuario.UsuarioLogado.Email;
            txtEndereco.Text = Usuario.UsuarioLogado.Endereco;
            txtCargo.Text = Usuario.UsuarioLogado.Cargo;
            DateTime dataNascimento = Usuario.ObterDataNascimento(Usuario.UsuarioLogado.DataNascimento);
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Usuario usuariologado = Usuario.UsuarioLogado;

            DateTime dataNascimento = ((DateTime?)txtData.SelectedDate)?.Date ?? DateTime.MinValue;

            Usuario.EditarUsuario(usuariologado, txtNome.Text, txtEmail.Text, txtCargo.Text, dataNascimento, txtEndereco.Text, Usuario.UsuarioLogado.CNPJEmpresa);
        }
      

    }
}
