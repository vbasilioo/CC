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
    /// <summary>
    /// Interação lógica para Contato.xam
    /// </summary>
    public partial class Contato : UserControl
    {

        public Usuario Destinatario { get; set; }
        public Usuario Remetente { get; set; }

        public Contato(Usuario usuario)
        {
            InitializeComponent();
            DadosUsuario(usuario);
            Destinatario = usuario;
        }

        private void DadosUsuario(Usuario usuario)
        {
            if (usuario == null)
            {
                throw new ArgumentException("O usuário é inválido");
            }

            var conversas = Chat.ObterConversasIniciadas();
            var remetente = conversas.FirstOrDefault(c => c.Usuario1 == usuario.ID || c.Usuario2 == usuario.ID)?.ObterOutroParticipante(Usuario.UsuarioLogado.ID);
            Nome.Text = usuario.Nome;
        }
    }
}
