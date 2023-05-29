using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC.Controller
{
    public class Administracao
    {
        public static int contador = 0;
        public int ID { get; set; }
        public string Email { get; set; }
        public string Assunto { get; set; }

        public static List<Administracao> EsqueciSenha { get; set; } = new List<Administracao>();

        public static void AdicionarSenhaEsquecida(string email, string assunto)
        {
            Administracao adm = new Administracao
            {
                ID = contador++,
                Email = email,
                Assunto = assunto
            };

            EsqueciSenha.Add(adm);
        }

        public static List<Administracao> ListarSenhasEsquecidas()
        {
            return EsqueciSenha;
        }
    }
}
