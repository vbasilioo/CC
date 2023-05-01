using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC.Controller
{
    public class Mensagem
    {
        private int Participante { get; set; }
        private string? Texto { get; set; }
        private DateTime dataEnvio { get; set; }

        public Mensagem(string texto)
        {
            Participante = Usuario.UsuarioLogado.ID;
            Texto = texto;
            dataEnvio = DateTime.Now;
        }
    }
}
