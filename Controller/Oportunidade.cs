using CareerConnect.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace CareerConnect.Controller{
    class Oportunidade{

        private static int contadorID = 1;
        public int ID { get; set; }
        public string TituloVaga { get; set; }
        public string DescricaoVaga { get; set; }
        public double SalarioVaga { get; set; }
        public int ClassificacaoVaga { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }

        private static List<Oportunidade> oportunidades = new List<Oportunidade>();


        public Oportunidade(){}

        public Oportunidade(string tituloVaga, string descricaoVaga, double salarioVaga, string nomeEmpresa, string cNPJ){
            ID = contadorID++;
            TituloVaga = tituloVaga;
            DescricaoVaga = descricaoVaga;
            SalarioVaga = salarioVaga;
            NomeFantasia = nomeEmpresa;
            CNPJ = cNPJ;
        }

        //criando vagas pre definidas
        static Oportunidade(){
            AdicionarOportunidade(new Oportunidade("Desenvolvedor Backend", "Desenvolvimento de sistemas na plataforma .NET", 5000.0, "Google", "49.239.703/0001-66"));
            AdicionarOportunidade(new Oportunidade("Desenvolvedor Frontend", "Desenvolvimento de interfaces utilizando AngularJS", 4000.0, "Google", "49.239.703/0001-66"));
            AdicionarOportunidade(new Oportunidade("Analista de Banco de Dados", "Análise de dados e manutenção de bancos de dados SQL Server", 6000.0, "Google", "49.239.703/0001-66"));
        }

        //adiciona oportu na lista
        public static void AdicionarOportunidade(Oportunidade oportunidade){
            oportunidades.Add(oportunidade);
        }

        //retorna a lista de oportunidades
        public static List<Oportunidade> ListarOportunidades(){
            return oportunidades;
        }

        //remove oportunidade da lista
        public static void RemoverOportunidade(Oportunidade oportunidade){
            oportunidades.Remove(oportunidade);
        }

        //buscando oportu por ID da vaga
        public static Oportunidade BuscarOportunidadePorId(int id){
            foreach(Oportunidade oportunidade in oportunidades){
                if(oportunidade.ID == id){
                    return oportunidade;
                }
            }
            return null;
        }
        
        //buscando oportu por NOME da vaga
        public static Oportunidade BuscarOportunidadePorTitulo(string titulo){
            foreach(Oportunidade oportunidade in oportunidades){ //percorre a lista oportunidades
                if(oportunidade.TituloVaga == titulo){ //verifica se o titulo da lista é igual o informado
                    return oportunidade; //retorna se encontro
                }
            }
            return null; //retorna nada se nao encontrar nada
        }

        //buscar CNPJ ja cadastrado
        public static Oportunidade BuscarCNPJ(string CNPJ){
            foreach(Oportunidade oportunidade in oportunidades){
                if(oportunidade.CNPJ == CNPJ){
                    return oportunidade;
                }
            }
            return null;
        }

        //cadastra a oportunidade verificando se ja existe um TITULO ou CNPJ igual [ate entao]
        public static void CadastrarOportunidadeNova(string titulo, string descricao, double salario, string empresa, string cnpj){
            Oportunidade novaOportunidade = new Oportunidade(titulo, descricao, salario, empresa, cnpj);
            if(Oportunidade.BuscarOportunidadePorTitulo(titulo) == null){
                Oportunidade.AdicionarOportunidade(novaOportunidade);
                MessageBox.Show("A oportunidade foi cadastrada com sucesso!");
                Cadastrar_Oportunidade.FormVagas.AtualizarGridView();
            }else{
                MessageBox.Show("Já existe uma vaga com esse mesmo nome, troque por outro.");
            }
        }

        //buscando oportunidade por id ou titulo num metodo apenas
        public static Oportunidade BuscarOportunidadePorIdOuTitulo(string idOuTitulo){
            if (int.TryParse(idOuTitulo, out int id)){ //verificando se é int
                return oportunidades.FirstOrDefault(u => u.ID == id); // busca por ID
            }else{
                return oportunidades.FirstOrDefault(u => u.TituloVaga.ToLower() == idOuTitulo.ToLower()); // busca o titulo td minusculo pra evitar erros
            }
        }

        //metodo void para ser usado dentro do EditarVaga estatico
        public static void EditarVaga(string tituloOuId, string titulo, string descricao, double salario, string nome, string cnpj){
            Oportunidade oportunidade = null;

            //busca vaga pelo ID na lista de vagas
            if(int.TryParse(tituloOuId, out int id)){
                oportunidade = oportunidades.Find(u => u.ID == id); //busca pela vaga pelo id
            }else{
                oportunidade = oportunidades.Find(u => u.TituloVaga == titulo); //busca pelo titulo
            }
          
            if(oportunidade == null){ // se não encontrou a vaga{
                MessageBox.Show("Vaga não encontrada.");
            }else{
                oportunidade.TituloVaga = titulo;
                oportunidade.DescricaoVaga = descricao;
                oportunidade.SalarioVaga = salario;
                oportunidade.NomeFantasia = nome;
                oportunidade.CNPJ = cnpj;
                MessageBox.Show("Vaga editada com sucesso!");
            }
        }

        //metodo pra pesquisar o nome de uma empresa e ir atualizando
        public static List<Oportunidade> ProcurarEmpresaPorNome(string nome, List<Oportunidade> oportunidades){
            return oportunidades.Where(u => u.NomeFantasia.Contains(nome)).ToList();
        }
    }
}
