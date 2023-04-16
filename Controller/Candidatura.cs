using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CareerConnect.Controller;

namespace CareerConnect.Controller{
    class Candidatura{

        public static int ContarInscricoes = 1;
        public int ID { get; set; }
        public string Nome { get; set; }
        public string NomeSocial { get; set; }
        public int Telefone { get; set; }
        public string Comentarios { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public string TituloVaga { get; set; }

        public static List<Candidatura> VagasInscritas = new List<Candidatura>();
     
        public Candidatura(){}

        /*public Candidatura(string nomeSocial, int telefone, string comentarios){
            NomeSocial = nomeSocial;
            Telefone = telefone;
            Comentarios = comentarios;
        }*/

        public Candidatura(string nome, string nomeSocial, Tuple<string, string, string> tituloCNPJnomefantasia, int telefone, string comentarios){
            ID = ContarInscricoes++;
            Nome = nome;
            NomeSocial = nomeSocial;
            Telefone = telefone;
            Comentarios = comentarios;
            TituloVaga = tituloCNPJnomefantasia.Item1; //item 1 e o titulo vaga
            CNPJ = tituloCNPJnomefantasia.Item2; //item 2 cnpj
            NomeFantasia = tituloCNPJnomefantasia.Item3; //item 3 nomefantasia
        }

        public static void AdicionarVagaInscrita(int id, string nomeSocial, int telefone, string comentarios){
            Tuple<string, string, string> dadosOportunidade = Oportunidade.GetTituloCNPJeNomeFantasiaById(id);
            Candidatura novaCandidatura = new Candidatura(Usuario.usuarioLogado.Nome, nomeSocial, dadosOportunidade, telefone, comentarios);
            VagasInscritas.Add(novaCandidatura);
            MessageBox.Show("Você foi inscrito com sucesso!");
        }


        public static void RemoverVagaInscrita(string idounome){
            if(int.TryParse(idounome, out int id)){ 
                Candidatura candidatura = Candidatura.BuscarInscricao(id.ToString());
                if(candidatura != null){
                    string opcao = Microsoft.VisualBasic.Interaction.InputBox("Certeza que deseja excluir essa inscrição? (sim ou nao)");
                    if(opcao.ToLower() == "sim") Candidatura.RemoverVaga(candidatura);
                    else MessageBox.Show("A ação foi cancelada.");
                }else MessageBox.Show("A vaga não foi localizada!");
            }else{
                Candidatura candidatura = Candidatura.BuscarInscricao(id.ToString());
                if(candidatura != null){
                    string opcao = Microsoft.VisualBasic.Interaction.InputBox("Certeza que deseja excluir essa inscrição? (sim ou nao)");
                    if(opcao.ToLower() == "sim") Candidatura.RemoverVaga(candidatura);
                    else MessageBox.Show("A ação foi cancelada.");
                }else MessageBox.Show("A vaga não foi localizada!");
            }
        }

        public static void RemoverVaga(Candidatura candidatura){
            VagasInscritas.Remove(candidatura);
        }

        public static Candidatura BuscarInscricao(string idOuTitulo){
            if (int.TryParse(idOuTitulo, out int id)){ //verificando se é int
                return VagasInscritas.FirstOrDefault(u => u.ID == id); // busca por ID
            }else{
                return VagasInscritas.FirstOrDefault(u => u.TituloVaga.ToLower() == idOuTitulo.ToLower()); // busca o titulo td minusculo pra evitar erros
            }
        }

        public static void EditarVagaInscrita(string idoutitulo, string nomeSocial, int telefone, string comentarios){
            Candidatura candidatura = null;

            if(int.TryParse(idoutitulo, out int id)){
                candidatura = VagasInscritas.Find(u => u.ID == id); //busca inscricao pelo id
            }else{
                candidatura = VagasInscritas.Find(u => u.TituloVaga == idoutitulo); //busca pelo titulo
            }

            if(candidatura == null) MessageBox.Show("Inscrição não encontrada.");
            else{
                candidatura.NomeSocial = nomeSocial;
                candidatura.Telefone = telefone;
                candidatura.Comentarios = comentarios;
                MessageBox.Show("Inscrição atualizada com sucesso!");
            }
        }

        public static List<Candidatura> ListarInscritos(){
            return VagasInscritas;
        }

        public static List<Candidatura> ListarVagasInscritas(){
            return VagasInscritas.FindAll(u => u.Nome == Usuario.usuarioLogado.Nome);
        }

        public static void AssociarCandidato(int id, string nomeSocial, int telefone, string comentarios){
            Tuple<string, string, string> dadosOportunidade = Oportunidade.GetTituloCNPJeNomeFantasiaById(id);
            Candidatura novaCandidatura = new Candidatura(Usuario.usuarioLogado.Nome, nomeSocial, dadosOportunidade, telefone, comentarios);
            VagasInscritas.Add(novaCandidatura);
        }

        public static void DessasociarCandidato(string idounome){
            if(int.TryParse(idounome, out int id)){ 
                Candidatura candidatura = Candidatura.BuscarInscricao(id.ToString());
                if(candidatura != null){
                    string opcao = Microsoft.VisualBasic.Interaction.InputBox("Certeza que deseja desassociar esse candidato? (sim ou nao)");
                    if(opcao.ToLower() == "sim") Candidatura.RemoverVaga(candidatura);
                    else MessageBox.Show("A ação foi cancelada.");
                }else MessageBox.Show("A vaga não foi localizada!");
            }else{
                Candidatura candidatura = Candidatura.BuscarInscricao(id.ToString());
                if(candidatura != null){
                    string opcao = Microsoft.VisualBasic.Interaction.InputBox("Certeza que deseja desassociar esse candidato? (sim ou nao)");
                    if(opcao.ToLower() == "sim") Candidatura.RemoverVaga(candidatura);
                    else MessageBox.Show("A ação foi cancelada.");
                }else MessageBox.Show("A vaga não foi localizada!");
            }
        }

        public static List<Candidatura> ObterCandidatosRelacionados(string cnpjEmpresa, int idVaga){
            List<Candidatura> candidatosRelacionados = new List<Candidatura>();

            foreach (Candidatura candidatura in VagasInscritas){
                if (candidatura.ID == idVaga && candidatura.CNPJ == cnpjEmpresa){
                    candidatosRelacionados.Add(candidatura);
                }
            }

            return candidatosRelacionados;
        }

        public static List<Candidatura> RetornarCandidatosPorCNPJ(string CNPJ){
            List<Candidatura> candidatos = new List<Candidatura>();

            foreach(var candidatura in VagasInscritas){
                if(Usuario.usuarioLogado.CNPJEmpresa == CNPJ){
                    candidatos.Add(candidatura);
                }
            }

            return candidatos;
        }
    }
}
