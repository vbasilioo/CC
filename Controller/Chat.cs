using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareerConnect.Controller{
    public class Chat
    {
        private static Dictionary<int, Queue<Mensagem>> conversas = new Dictionary<int, Queue<Mensagem>>();
        private static int idConversaAtual = -1;

        public static event Action<int, Mensagem> NovaMensagemRecebida;
        public static event Action<int, Mensagem> NovaMensagemEnviada;

        public static void IniciarConversa(int idRemetente, int idDestinatario)
        {
            int idConversa = GerarIdConversa(idRemetente, idDestinatario);
            if (!conversas.ContainsKey(idConversa))
            {
                conversas.Add(idConversa, new Queue<Mensagem>());
                 idConversaAtual = idConversa;
            }
        }

        public static void EnviarMensagem(int idRemetente, string texto)
        {
            if (idConversaAtual != -1)
            {
                Mensagem mensagem = new Mensagem(idRemetente, idConversaAtual, texto);
                conversas[idConversaAtual].Enqueue(mensagem);
                NovaMensagemEnviada?.Invoke(idConversaAtual, mensagem);
            }
        }

        public static List<int> ObterConversasIniciadas(int idUsuario)
        {
            List<int> conversasIniciadas = new List<int>();
            foreach (int idConversa in conversas.Keys)
            {
                if (idConversa.ToString().StartsWith(idUsuario.ToString()))
                {
                    conversasIniciadas.Add(idConversa);
                }
            }
            return conversasIniciadas;
        }

        public static Queue<Mensagem> ObterMensagensDaConversa(int idConversa)
        {
            if (conversas.ContainsKey(idConversa))
            {
                return conversas[idConversa];
            }
            else
            {
                return null;
            }
        }

        public static bool ConversaExiste(int idConversa)
        {
            return conversas.ContainsKey(idConversa);
        }

        public static int GerarIdConversa(int idUsuario1, int idUsuario2)
        {
            int idConversa;
            if (idUsuario1 < idUsuario2)
            {
                idConversa = int.Parse(idUsuario1.ToString() + idUsuario2.ToString());
            }
            else
            {
                idConversa = int.Parse(idUsuario2.ToString() + idUsuario1.ToString());
            }
            return idConversa;
        }
    }
}
