using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CC.Controller
{
    public class Candidato
    {
        private static int contador = 0;
        private int IDCandidato { get; set; }
        public string? Autor { get; set; }  
        public string? NomeCandidato { get; set; }
        public string? NomeSocial { get; set; }
        public int Telefone { get; set; }
        public string? Comentarios { get; set; }
        public string? NomeFantasia { get; set; }
        public string? CNPJ { get; set; }
        public string? TituloVaga { get; set; }
        public static List<Candidato> VagasInscritas = new List<Candidato>();

        public Candidato(string? nome, string? nomeSocial, int telefone, string? comentarios, Tuple<string, string, string> tituloCNPJnomefantasia)
        {
            IDCandidato = contador++;
            Autor = Usuario.UsuarioLogado.Nome;
            NomeCandidato = nome;
            NomeSocial = nomeSocial;
            Telefone = telefone;
            Comentarios = comentarios;
            TituloVaga = tituloCNPJnomefantasia.Item1;
            CNPJ = tituloCNPJnomefantasia.Item2;
            NomeFantasia = tituloCNPJnomefantasia.Item3;
        }

        public static void AdicionarVaga(int id, string nomeSocial, int telefone, string comentarios)
        {
            Tuple<string, string, string> dados = Oportunidade.GetTituloCNPJeNomeFantasiaById(id);
            Candidato novaCandidatura = new Candidato(Usuario.UsuarioLogado.Nome, nomeSocial, telefone, comentarios, dados);
            VagasInscritas.Add(novaCandidatura);
            MessageBox.Show("Você foi inscrito com sucesso!");
        }

        public static void AssociarCandidato(int id, string nome, string nomeSocial, int telefone, string comentarios)
        {
            Tuple<string, string, string> dados = Oportunidade.GetTituloCNPJeNomeFantasiaById(id);
            Candidato novaAssociacao = new Candidato(nome, nomeSocial, telefone, comentarios, dados);
            VagasInscritas.Add(novaAssociacao);
            MessageBox.Show($"Você associou {nome} com sucesso!");
        }

        public static List<Candidato> ListarVagasInscritas(){
            return VagasInscritas.FindAll(u => u.NomeCandidato == Usuario.UsuarioLogado.Nome);
        }

        public static List<Candidato> ListarInscritos(){
            return VagasInscritas;
        }

        public static Candidato ListarCandidato(string nome)
        {
            return VagasInscritas.FirstOrDefault(c => c.NomeCandidato == nome);
        }

        public static Candidato BuscarInscricao(string idOuTitulo){
            if (int.TryParse(idOuTitulo, out int id)){ 
                return VagasInscritas.FirstOrDefault(u => u.IDCandidato == id); 
            }else{
                return VagasInscritas.FirstOrDefault(u => u.TituloVaga.ToLower() == idOuTitulo.ToLower()); 
            }
        }

        public static void RemoverVaga(Candidato candidato){
            VagasInscritas.Remove(candidato);
            MessageBox.Show($"{candidato.NomeCandidato} desassociado com sucesso.");
        }

        public static void RemoverVagaInscrita(string idounome)
        {
            if(int.TryParse(idounome, out int id))
            {
                Candidato candidato = Candidato.BuscarInscricao(idounome);
                if(candidato != null)
                {
                    string opcao = Microsoft.VisualBasic.Interaction.InputBox("Certeza que deseja excluir essa inscrição? (sim ou nao)");
                    if(opcao.ToLower() == "sim") Candidato.RemoverVaga(candidato);
                    else MessageBox.Show("A ação foi cancelada.");
                }else MessageBox.Show("A vaga não foi localizada!");
            }
            else
            {
                Candidato candidato = Candidato.BuscarInscricao(idounome.ToString());
                if(candidato != null)
                {
                    string opcao = Microsoft.VisualBasic.Interaction.InputBox("Certeza que deseja excluir essa inscrição? (sim ou nao)");
                    if(opcao.ToLower() == "sim") Candidato.RemoverVaga(candidato);
                    else MessageBox.Show("A ação foi cancelada.");
                }else MessageBox.Show("A vaga não foi localizada!");
            }
        }
    }
}
