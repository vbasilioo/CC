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
    }
}
