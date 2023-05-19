using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC.Controller
{
    public class Chat
    {
        private int ID { get; set; }
        public string Remetente { get; set; }
        public string Destinatario { get; set; }
        public int Usuario1 { get; set; }  
        public int Usuario2 { get; set; }
        public List<Mensagem>? listaMensagens;
        public List<string> Mensagens { get; } = new List<string>();

        private Usuario usuario;

        public Chat(int ID, string remetente, string destinatario, Usuario usuario)
        {
            Remetente = remetente;
            Destinatario = destinatario;
            Usuario1 = Usuario.UsuarioLogado.ID;
            Usuario2 = ID;
            this.usuario = usuario;
        }

        public void AdicionarMensagem(string remetente, string mensagem)
        {
            Mensagens.Add($"{remetente}: {mensagem}");
        }

        public void EnviarNovaMensagem(string texto)
        {
            Mensagem mensagem = new Mensagem(texto);
            listaMensagens.Add(mensagem);
        }

        public string ObterOutroParticipante(int ID)
        {
            if(Usuario1 == ID)
            {
                return ObterUsuario(Usuario2);
            }
            else if(Usuario2 == ID)
            {
                return ObterUsuario(Usuario1);
            }
            else
            {
                throw new ArgumentException("Usuário inválido");
            }
        }

        public string ObterUsuario(int ID)
        {
            return Usuario.ObterUsuarioPorID(ID).ToString();
        }

        public static List<Chat> ObterConversasIniciadas()
        {
            return Usuario.ConversasIniciadas.Where(c => c.Usuario1 == Usuario.UsuarioLogado.ID || c.Usuario2 == Usuario.UsuarioLogado.ID).ToList();
        }

    }
}
