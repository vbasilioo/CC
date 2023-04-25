using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareerConnect.Controller{
    public class Chat
    {
        private static int contador = 1;
        public int ID { get; private set; }
        public string Mensagem { get; private set; }
        public string NomeRemetente { get; private set; }
        public DateTime horaEnvio { get; private set; }

        public static Stack<Chat> Mensagens = Mensagens = new Stack<Chat>();


        public Chat(string remetente, string mensagem)
        {
            ID = contador++;
            Mensagem = mensagem;
            NomeRemetente = remetente;
        }

        public static void EnviarMensagem(Chat chat)
        {
            Mensagens.Push(chat);
        }

        public static List<Chat> ObterMensagens()
        {
            return Mensagens.Reverse().ToList();
        }

        public static void EnviarNovaMensagem(string remetente, string mensagem)
        {
            Chat chat = new Chat(remetente, mensagem);
            Chat.EnviarMensagem(chat);
        }

        public override string ToString()
        {
            horaEnvio = DateTime.Now;
            return $"[{horaEnvio.ToString("HH:mm")}] {NomeRemetente}: {Mensagem}";
        }
    }
}
