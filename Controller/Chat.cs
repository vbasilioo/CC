using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareerConnect.Controller{
    public class Chat{
        public static Dictionary<int, Stack<Mensagem>> conversas = new Dictionary<int, Stack<Mensagem>>();

        public static int GerarIDConversa(int idRemetente, int idDestinatario){
            int menorID = Math.Min(idRemetente, idDestinatario);
            int maiorID = Math.Max(idRemetente, idDestinatario);
            return menorID * 1000000 + maiorID;
        }

        public static void IniciarConversa(int idRemetente, int idDestinatario){
            int idConversa = GerarIDConversa(idRemetente, idDestinatario);
            
            if(!conversas.ContainsKey(idConversa)){
                conversas.Add(idConversa, new Stack<Mensagem>());
            }
        }

        public static void EnviarMensagem(int idRemetente, int idDestinatario, string texto, Form telaChat){
            int idConversa = GerarIDConversa(idRemetente, idDestinatario);
            
            if(!conversas.ContainsKey(idConversa)){
                IniciarConversa(idRemetente, idDestinatario);
            }

            Mensagem novaMensagem = new Mensagem(idRemetente, idDestinatario, texto);
            conversas[idConversa].Push(novaMensagem);
        }

        public static List<Mensagem> ObterMensagens(int idRemetente, int idDestinatario){
            int idConversa = GerarIDConversa(idRemetente, idDestinatario);
            
            if(!conversas.ContainsKey(idConversa)){
                IniciarConversa(idRemetente, idDestinatario);
            }

            return new List<Mensagem>(conversas[idConversa].Reverse());
        }

        public static void ExcluirMensagem(int idRemetente, int idDestinatario, int idMensagem){
            int idConversa = GerarIDConversa(idRemetente, idDestinatario);

            if(!conversas.ContainsKey(idConversa)){
                throw new Exception("Conversa não encontrada.");
            }

            Stack<Mensagem> mensagens = conversas[idConversa];
            Stack<Mensagem> novasMensagens = new Stack<Mensagem>();

            while(mensagens.Count > 0){
                Mensagem mensagem = mensagens.Pop();

                if(mensagem.ID == idMensagem){
                    continue;
                }

                novasMensagens.Push(mensagem);
            }
        }

        public static List<Mensagem> BuscarConversaPorDestinatario(int idRemetente, int idDestinatario)
        {
            int idConversa = GerarIDConversa(idRemetente, idDestinatario);

            if (!conversas.ContainsKey(idConversa))
            {
                IniciarConversa(idRemetente, idDestinatario);
            }

            return new List<Mensagem>(conversas[idConversa]);
        }

        public static bool PodeEnviarMensagem(int idRemetente, int idDestinatario)
        {
            if(idRemetente == Usuario.usuarioLogado.ID || idDestinatario == Usuario.usuarioLogado.ID) return true;

            return false;
        }

        public static List<Stack<Mensagem>> ObterConversasPorUsuario(int idUsuario)
        {
            List<Stack<Mensagem>> conversas = new List<Stack<Mensagem>>();
            foreach (var conversa in conversas)
            {
                if (conversa.Any(m => m.IDRemetente == idUsuario || m.IDDestinatario == idUsuario))
                {
                    conversas.Add(conversa);
                }
            }
            return conversas;
        }
    }
}
