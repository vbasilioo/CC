using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CareerConnect.Controller{
    class Candidatura{

        public string NomeSocial { get; set; }
        public int Telefone { get; set; }
        public string Comentarios { get; set; }

        public static List<Candidatura> VagasInscritas { get; } = new List<Candidatura>();
     
        public Candidatura(){}

        public Candidatura(string nomeSocial, int telefone, string comentarios){
            NomeSocial = nomeSocial;
            Telefone = telefone;
            Comentarios = comentarios;
        }

        public static void AdicionarVagaInscrita(string nomeSocial, int telefone, string comentarios){
            //VagasInscritas.Add(candidatura);
            Candidatura novaCandidatura = new Candidatura(nomeSocial, telefone, comentarios);
            VagasInscritas.Add(novaCandidatura);
            MessageBox.Show("Você foi inscrito com sucesso!");
        }

        public static void RemoverVagaInscrita(Candidatura candidatura){
            VagasInscritas.Remove(candidatura);
        }

        public static void EditarVagaInscrita(string nomeSocial, int telefone, string comentarios){
            Candidatura candidatura = null;

            if(candidatura==null) MessageBox.Show("Inscrição não encontrada");
            else{
                candidatura.NomeSocial = nomeSocial;
                candidatura.Telefone = telefone;
                candidatura.Comentarios = comentarios;
            }
        }

        public static List<Candidatura> ListarVagasInscritas(){
            return VagasInscritas;
        }
    }
}
