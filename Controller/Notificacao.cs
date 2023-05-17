using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC.Controller
{
    public class Notificacao
    {
        public int IDNotificacao { get; set; }
        public string? Informativo { get; set; } 
        public static List<Notificacao> listaNotificacoes { get; set; } = new List<Notificacao>();

        public Notificacao()
        {
            
        }

        public static void AdicionarNotificacao(Notificacao notificacao)
        {
            listaNotificacoes.Add(notificacao);
        }

        public static List<Notificacao> ListarNotificacoes()
        {
            return listaNotificacoes;
        }
    }
}
