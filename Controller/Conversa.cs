using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerConnect.Controller
{
    public class Conversa
    {
        public int IDRemetente { get; set; }
        public int IDDestinatario { get; set; }
        public List<Mensagem> Mensagens { get; set; }

        public Conversa(int remetente, int destinatario)
        {
            IDRemetente = remetente;
            IDDestinatario = destinatario;
            Mensagens = new List<Mensagem>();
        }
    }
}
