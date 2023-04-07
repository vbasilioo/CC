using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerConnect.Controller{
    class Candidato : Usuario{
        public int ID { get; set; }
        public string NomeSocial { get; set; }
        public string Telefone { get; set; }
        public string ComentariosInscricao { get; set; }

        public Candidato(string nome, string endereco, int idade, string email, string numeroTelefone, string nomeSocial, string comentarios)
        : base(nome, endereco, idade, email){
            this.Telefone = numeroTelefone;
            this.NomeSocial = nomeSocial;
            this.ComentariosInscricao = comentarios;
        }
    }
}
