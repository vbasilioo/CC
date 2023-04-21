using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerConnect.Controller{
    public class Mensagem{
        public int contador = 1;
        public int ID { get; }
        public int IDRemetente { get; set; }
        public int IDDestinatario { get; set; }
        public string Conteudo { get; set; }
        public DateTime DataHora { get; }
        public bool MsgLida { get; set; }
        public Usuario EnviadaPorUsuarioLogado { get; set; }
        public Usuario DestinatarioObj { get; set; }
    
        public Mensagem(int remetente, int destinatario, string conteudo){
            ID = contador++;
            Conteudo = conteudo;
            DataHora = DateTime.Now;
            MsgLida = false;
            EnviadaPorUsuarioLogado = Usuario.ObterUsuarioPorID(remetente);
            IDRemetente = remetente;
            IDDestinatario = destinatario;
        }

        public static List<Mensagem> ObterMensagensPorUsuario(int idUsuario)
        {
            List<Mensagem> mensagens = new List<Mensagem>();

            foreach(Mensagem mensagem in mensagens)
            {
                if(mensagem.IDDestinatario == idUsuario || mensagem.IDRemetente == idUsuario)
                {
                    mensagens.Add(mensagem);
                }
            }

            return mensagens;
        }

        public static void EnviarMensagem(int remetente, int destinatario, string conteudo)
        {
            Mensagem novaMensagem = new Mensagem(remetente, destinatario, conteudo);

            if (Chat.conversas.ContainsKey(remetente))
            {
                Chat.conversas[remetente].Push(novaMensagem);
            }
            else
            {
                Chat.conversas.Add(remetente, new Stack<Mensagem>());
                Chat.conversas[remetente].Push(novaMensagem);
            }

            if (Chat.conversas.ContainsKey(destinatario))
            {
                Chat.conversas[destinatario].Push(novaMensagem);
            }
            else
            {
                Chat.conversas.Add(destinatario, new Stack<Mensagem>());
                Chat.conversas[destinatario].Push(novaMensagem);
            }
        }
    }
}
