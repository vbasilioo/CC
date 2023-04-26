using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerConnect.Controller
{
    public class Conversa
    {
        public int IDUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public List<Mensagem> Historico { get; set; }

        public Conversa(int id, string nome)
        {
            IDUsuario = id;
            NomeUsuario = nome;
            Historico = new List<Mensagem>();
        }

        public override string ToString()
        {
            return NomeUsuario;
        }
    }
}
