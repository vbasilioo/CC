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
        }

        public void EnviarNovaMensagem(string texto)
        {
            Mensagem mensagem = new Mensagem(texto);
            listaMensagens.Add(mensagem);
        }
    }
}
