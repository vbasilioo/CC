using CC.Controller;
using CC.UserControls;
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
    /// <summary>
    /// Lógica interna para Bate_papo.xaml
    /// </summary>
    public partial class Bate_papo : Window
    {

        

        public Bate_papo()
        {
            InitializeComponent();

            foreach (var conversa in Usuario.ConversasIniciadas)
            {
                Usuario destinatario;
                if (conversa.Remetente == Usuario.UsuarioLogado.Nome)
                {
                    destinatario = Usuario.usuariosCadastrados.FirstOrDefault(u => u.Nome == conversa.Destinatario);
                }
                else
                {
                    destinatario = Usuario.usuariosCadastrados.FirstOrDefault(u => u.Nome == conversa.Remetente);
                }

                Contato contato = new Contato(destinatario);
                wrapContatos.Children.Add(contato);
            }
        }

        private void btnIniciar_Click(object sender, RoutedEventArgs e)
        {
            string nome = Microsoft.VisualBasic.Interaction.InputBox("Digite seu nome:", "Iniciar Conversa");
            var usuario = Usuario.usuariosCadastrados.FirstOrDefault(u => u.Nome == nome);

            try
            {
                Contato contato = new Contato(usuario);
                wrapContatos.Children.Add(contato); 

                if(usuario == Usuario.UsuarioLogado)
                {
                    Usuario destinatario = contato.Destinatario;
                    Chat novaConversa = new Chat(destinatario.ID, Usuario.UsuarioLogado.Nome, destinatario.Nome, destinatario);
                    novaConversa.AdicionarMensagem(Usuario.UsuarioLogado.Nome, "Olá, eu quero conversar com você!");
                    Usuario.ConversasIniciadas.Add(novaConversa);
                }
                else
                {
                    Chat novaConversa = new Chat(Usuario.UsuarioLogado.ID, usuario.Nome, Usuario.UsuarioLogado.Nome, usuario);
                    novaConversa.AdicionarMensagem(Usuario.UsuarioLogado.Nome, "Olá, eu quero conversar com você!");
                    Usuario.ConversasIniciadas.Add(novaConversa);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
        }
    }
}
