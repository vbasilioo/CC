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
        private int Usuario1 { get; set; }
        private int Usuario2 { get; set; }
        private List<Mensagem>? listaMensagens;

        private Usuario usuario;

        public Chat(int ID)
        {
            Usuario1 = Usuario.UsuarioLogado.ID;
            Usuario2 = ID;
            listaMensagens = new List<Mensagem>();
            ID = usuario.AdicionarChat(this);
            Chat chat = new Chat(ID);
            ((Usuario)Usuario.BuscarUsuario(Usuario.UsuarioLogado.ID)).AdicionarChat(chat);
            ((Usuario)Usuario.BuscarUsuario(Usuario.UsuarioLogado.ID)).AdicionarChat(chat);
        }

        public void AlterarID(int id)
        {
            ID = id;
        }

        public int RetornarID()
        {
            return ID;
        }

        public void EnviarNovaMensagem(string texto)
        {
            Mensagem mensagem = new Mensagem(texto);
            listaMensagens.Add(mensagem);
        }

        public int GetUsuario1()
        {
            return Usuario1;
        }

        public int GetUsuario2()
        {
            return Usuario2;
        }

        public List<Mensagem> RetornarChat()
        {
            return listaMensagens;
        }

        public Mensagem RetornarMensagem(int id)
        {
            return listaMensagens[id];
        }
    }
}
