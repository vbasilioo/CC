using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC.Controller
{
    public class Administracao
    {
        public int ID { get; set; }

        public static List<string> EsqueciSenha { get; set; } = new List<string>();

        public static void AdicionarSenhaEsquecida(string email)
        {
            EsqueciSenha.Add(email);
        }

        public static List<string> ListarSenhasEsquecidas()
        {
            return EsqueciSenha;
        }
    }
}
