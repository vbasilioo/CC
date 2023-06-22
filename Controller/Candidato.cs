using CC.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CC.Controller
{
    public class Candidato
    {
        private static int contador = 0;
        public int IDVaga { get; set; }
        public int IDCandidato { get; set; }
        public string? Autor { get; set; }  
        public string? NomeCandidato { get; set; }
        public string? Curso { get; set; }
        public string? NomeSocial { get; set; }
        public int Telefone { get; set; }
        public string? Comentarios { get; set; }
        public string? NomeFantasia { get; set; }
        public string? CNPJ { get; set; }
        public string? TituloVaga { get; set; }
        public static List<Candidato> VagasInscritas = new List<Candidato>();
        public static List<Candidato> VagasCandidato = new List<Candidato>();

        public Candidato()
        {

        }

        public Candidato(string? nome, int id, string? curso)
        {
            IDCandidato = contador++;
            Autor = Usuario.UsuarioLogado.Nome;
            NomeCandidato = nome;
            IDVaga = id;
            Curso = curso;
        }

        public Candidato(string? nome, string? vaga)
        {
            IDCandidato = contador++;
            Autor = Usuario.UsuarioLogado.Nome;
            NomeCandidato = nome;
            TituloVaga = vaga;
        }

        public static void AdicionarCandidato(Oportunidade oportunidade, int id, string tituloVaga)
        {
            contador++;
            Candidato novaCandidatura = new Candidato(Usuario.UsuarioLogado.Nome, id, Usuario.UsuarioLogado.Curso);
            novaCandidatura.TituloVaga = tituloVaga;
            VagasCandidato.Add(novaCandidatura);
        }

        public static void AdicionarInformacoesCandidato(int id, string nomeSocial, int telefone, string comentarios)
        {
            Candidato candidato = VagasCandidato.FirstOrDefault(c => c.IDCandidato == id);

            if(candidato != null)
            {
                candidato.NomeSocial = nomeSocial;
                candidato.Telefone = telefone;
                candidato.Comentarios = comentarios;
            }
        }

        public static List<Candidato> MinhasCandidaturas()
        {
            return VagasCandidato;
        }

        public static void AdicionarVaga(Oportunidade oportunidade, int id)
        {
            Candidato novaCandidatura = new Candidato(Usuario.UsuarioLogado.Nome, id, Usuario.UsuarioLogado.Curso);
            VagasCandidato.Add(novaCandidatura);
            MessageBox.Show("Você foi inscrito com sucesso!");
        }

        public static void AssociarCandidato(int id, string nome)
        {
            Oportunidade oportunidade = Oportunidade.BuscarOportunidadePorId(id);

            if(oportunidade != null)
            {
                string vaga = oportunidade.TituloVaga;
                Candidato novaAssociacao = new Candidato(nome, vaga);
                VagasCandidato.Add(novaAssociacao);
            }
        }

        public static List<Candidato> ListarVagasInscritas(){
            return VagasCandidato.FindAll(u => u.NomeCandidato == Usuario.UsuarioLogado.Nome);
        }

        public static List<Candidato> ListarInscritos(){
            return VagasCandidato;
        }

        public static Candidato ListarCandidato(string nome)
        {
            return VagasCandidato.FirstOrDefault(c => c.NomeCandidato == nome);
        }

        public static Candidato BuscarInscricao(string idOuTitulo){
            if (int.TryParse(idOuTitulo, out int id)){ 
                return VagasCandidato.FirstOrDefault(u => u.IDCandidato == id); 
            }else{
                return VagasCandidato.FirstOrDefault(u => u.TituloVaga.ToLower() == idOuTitulo.ToLower()); 
            }
        }

        public static void RemoverVaga(Candidato candidato){
            VagasCandidato.Remove(candidato);
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

        public static List<Candidato> RetornarCandidatosPorCNPJ(string CNPJ, string titulo){
            List<Candidato> candidatos = new List<Candidato>();

            foreach(var candidatura in VagasCandidato){
                if(Usuario.UsuarioLogado.CNPJEmpresa == CNPJ && candidatura.TituloVaga == titulo){
                    candidatos.Add(candidatura);
                }
            }

            return candidatos;
        }

        public static List<Candidato> RetornarCandidatosPorID(int id)
        {
            List<Candidato> candidatosFiltrados = new List<Candidato>();

            foreach(Candidato candidato in VagasCandidato)
            {
                if(candidato.IDVaga == id)
                {
                    candidatosFiltrados.Add(candidato);
                }
            }

            return candidatosFiltrados;
        }

    }
}
