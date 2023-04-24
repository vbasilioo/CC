using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerConnect.Controller{
    public class Mensagem
    {
        public int IDRemetente { get; }
        public int IDDesteinatario { get; }
        public string Texto { get; }

        public Mensagem(int idRemetente, int idDestinatario, string texto)
        {
            IDRemetente = idRemetente;
            IDDesteinatario = idDestinatario;
            Texto = texto;
        }

        public override string ToString()
        {
            return $"{IDRemetente}: {Texto}";
        }
    }
}
