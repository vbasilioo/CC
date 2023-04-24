using CareerConnect.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CareerConnect.Controller{
    public class Oportunidade{

        private static int contadorID = 1;
        public int ID { get; set; }
        public string TituloVaga { get; set; }
        public string DescricaoVaga { get; set; }
        public double SalarioVaga { get; set; }
        public string Requisitos { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public string StatusVaga { get; set; }

        private static List<Oportunidade> oportunidades = new List<Oportunidade>();
        private static List<Usuario> usuariosCadastrados = new List<Usuario>();

        public Oportunidade(){}

        public Oportunidade(string tituloVaga, string descricaoVaga, double salarioVaga, string requisitos, string nomeEmpresa, string cNPJ, string status){
            ID = contadorID++;
            TituloVaga = tituloVaga;
            DescricaoVaga = descricaoVaga;
            SalarioVaga = salarioVaga;
            Requisitos = requisitos;
            NomeFantasia = nomeEmpresa;
            CNPJ = cNPJ;
            StatusVaga = status;
        }

        //criando vagas pre definidas
        static Oportunidade(){
            AdicionarOportunidade(new Oportunidade("Desenvolvedor Backend", "Desenvolvimento de sistemas na plataforma .NET", 5000.0, "Experiência com C#", "Google", "49.239.703/0001-66", "Aberta"));
            AdicionarOportunidade(new Oportunidade("Desenvolvedor Frontend", "Desenvolvimento de interfaces utilizando AngularJS", 4000.0, "Experiência com JS", "Google", "49.239.703/0001-66", "Aberta"));
            AdicionarOportunidade(new Oportunidade("Engenheiro Civil", "Planejamento e execução de projetos de construção civil", 8000.0, "Experiência com projetos", "Construtora XYZ", "12.345.678/0001-90", "Aberta"));
            AdicionarOportunidade(new Oportunidade("Engenheiro Eletricista", "Desenvolvimento e implementação de projetos elétricos", 7000.0, "Experiência com grandes obras", "Empresa de Energia ABC", "23.456.789/0001-12", "Aberta"));
            AdicionarOportunidade(new Oportunidade("Assistente Administrativo", "Rotinas administrativas como atendimento telefônico, recepção, arquivo e controle de documentos", 2500.0, "Experiência com público", "Empresa de Consultoria XYZ", "34.567.890/0001-23", "Aberta"));
            AdicionarOportunidade(new Oportunidade("Auxiliar de Limpeza", "Limpeza e organização de ambientes corporativos", 1500.0, "Trabalho em equipe", "Empresa de Limpeza ABC", "45.678.901/0001-34", "Aberta"));
            AdicionarOportunidade(new Oportunidade("Estagiário de Marketing", "Apoio na criação e execução de campanhas de marketing", 1000.0, "Criatividade", "Agência de Publicidade XYZ", "56.789.012/0001-45", "Aberta"));
            AdicionarOportunidade(new Oportunidade("Estagiário de TI", "Apoio no desenvolvimento e manutenção de sistemas", 1200.0, "5 anos de experiência na área", "Empresa de Tecnologia ABC", "67.890.123/0001-56", "Aberta"));
            AdicionarOportunidade(new Oportunidade("Desenvolvedor Mobile", "Desenvolvimento de aplicativos mobile para Android e iOS", 6000.0, "Experiência com Flutter e Dart", "Empresa de Tecnologia XYZ", "78.901.234/0001-67", "Aberta"));
            AdicionarOportunidade(new Oportunidade("Assistente de Recursos Humanos", "Atividades relacionadas a recrutamento e seleção, treinamento e desenvolvimento, entre outras", 3000.0, "Pós-graduação em treinamento", "Empresa de RH ABC", "89.012.345/0001-78", "Aberta"));
            AdicionarOportunidade(new Oportunidade("Recepcionista", "Atendimento ao público, recepção e encaminhamento de visitantes", 2500.0, "Experiência em hotelaria", "Hotel XYZ", "12.345.678/0001-12", "Aberta"));
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
        public static void CadastrarOportunidadeNova(string titulo, string descricao, double salario, string requisitos, string empresa, string cnpj, string status){
            Oportunidade novaOportunidade = new Oportunidade(titulo, descricao, salario, requisitos, empresa, cnpj, status);
            Oportunidade.AdicionarOportunidade(novaOportunidade);
            MessageBox.Show("A oportunidade foi cadastrada com sucesso!");
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
        public static void EditarVaga(string tituloOuId, string titulo, string descricao, double salario, string requisitos, string nome, string cnpj, string status){
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
                oportunidade.Requisitos = requisitos;
                oportunidade.NomeFantasia = nome;
                oportunidade.CNPJ = cnpj;
                oportunidade.StatusVaga = status;
                MessageBox.Show("Vaga editada com sucesso!");
            }
        }

        /*public static bool EditarVaga(int id, string titulo, string descricao, double salario, string empresa, string cnpj, string status){
            for(int i=0;i<oportunidades.Count;i++){
                if(oportunidades[i].ID == id && oportunidades[i].CNPJ == Usuario.usuarioLogado.CNPJEmpresa){
                    oportunidades[i] = new Oportunidade(titulo, descricao, salario, empresa, cnpj, status);

                    return true;
                }
            }
            return false;
        }*/

        //metodo pra pesquisar o nome de uma empresa e ir atualizando
        public static List<Oportunidade> ProcurarEmpresaPorNome(string nome, List<Oportunidade> oportunidades){
            return oportunidades.Where(u => u.NomeFantasia.Contains(nome)).ToList();
        }

        //metodo de editar a vaga pra ir dentro do botao
        public static void EditarVagaNaTela(string idOuNome){
            int id;

            if(int.TryParse(idOuNome, out id)){ //verificando se o informado é INT ou STRING
                Oportunidade oportunidade = Oportunidade.BuscarOportunidadePorId(id); //buscando a oportunidade caso for ID
                if(oportunidade != null){ //se encontrar algo, abre a tela aq
                    Editar_Oportunidade edo = new Editar_Oportunidade(idOuNome);
                    edo.Show();
                }else{
                    MessageBox.Show("A vaga não foi encontrada.");
                }
            }else{
                Oportunidade oportunidade = Oportunidade.BuscarOportunidadePorTitulo(idOuNome);
                if(oportunidade != null){ 
                    Editar_Oportunidade edo = new Editar_Oportunidade(idOuNome);
                    edo.Show();
                }else{
                    MessageBox.Show("A vaga não foi encontrada.");
                }
            }
        }

        //metodo de deletar a vaga q vai dentro do botao
        public static void DeletarVagaNaTela(string idOuNome){
            if(int.TryParse(idOuNome, out int id)){ 
                Oportunidade oportunidade = Oportunidade.BuscarOportunidadePorId(id);
                if(oportunidade != null){
                    string opcao = Microsoft.VisualBasic.Interaction.InputBox("Certeza que deseja excluir essa inscrição? (sim ou nao)");
                    if(opcao.ToLower() == "sim") Oportunidade.RemoverOportunidade(oportunidade);
                    else MessageBox.Show("A ação foi cancelada.");
                }else MessageBox.Show("A vaga não foi localizada!");
            }else{
                Oportunidade oportunidade = Oportunidade.BuscarOportunidadePorId(id);
                if(oportunidade != null){
                    string opcao = Microsoft.VisualBasic.Interaction.InputBox("Certeza que deseja excluir essa inscrição? (sim ou nao)");
                    if(opcao.ToLower() == "sim") Oportunidade.RemoverOportunidade(oportunidade);
                    else MessageBox.Show("A ação foi cancelada.");
                }else MessageBox.Show("A vaga não foi localizada!");
            }

           /* if(int.TryParse(idOuNome, out id)){ //verificando se o informado é INT ou STRING
                Oportunidade oportunidade = Oportunidade.BuscarOportunidadePorId(id); //buscando a oportunidade caso for ID
                if(oportunidade != null){ //se encontrar algo, abre a tela aq
                    string opcao = Microsoft.VisualBasic.Interaction.InputBox("Certeza que deseja excluir essa vaga? (sim ou nao)");
                    if(opcao.ToLower() == "sim") Oportunidade.RemoverOportunidade(oportunidade);
                    else MessageBox.Show("A ação foi cancelada.");
                }else{
                    MessageBox.Show("A vaga não foi encontrada.");
                }
            }else{
                Oportunidade oportunidade = Oportunidade.BuscarOportunidadePorTitulo(idOuNome);
                if(oportunidade != null){ 
                    string opcao = Microsoft.VisualBasic.Interaction.InputBox("Certeza que deseja excluir essa vaga? (sim ou nao)");
                    if(opcao.ToLower() == "sim") Oportunidade.RemoverOportunidade(oportunidade);
                    else MessageBox.Show("A ação foi cancelada.");
                }else{
                    MessageBox.Show("A vaga não foi encontrada.");
                }
            }*/
        }

        //metodo para contar quantas vagas tao cadastrar nesse CNPJ
        public static int ContarVagasNesseCNPJ(string cnpj){
            int contador = 0;

            foreach(Oportunidade oportunidade in oportunidades){
                if(oportunidade.CNPJ == cnpj){
                    contador++;
                }
            }
            return contador;
        }

        //verificando se uma empresa é valida e possui oportunidade cadastrada
        // para o usuario poder se cadastrar
        public bool VerificarEmpresa(string nomeOuID){
            return this.NomeFantasia == nomeOuID || this.ID.ToString() == nomeOuID;
        }


       /* //busca vaga atraves do id
        public static Oportunidade BuscarVaga(int idVaga){
            foreach(Oportunidade oportunidade in oportunidades){
                if (oportunidade.ID == idVaga){
                    return oportunidade;
                }
            }
            return null;
        }

        //verifica empresa informando o cnpj
        public static bool VerificarEmpresaCNPJ(string cnpjVaga, string cnpjEmpresaLogada){
            if(cnpjVaga == cnpjEmpresaLogada) return true;
            else return false;
        }
       */

        public static Oportunidade BuscarVagaPorIdOuNomeECNPJ(string idOuNome, string cnpjEmpresa){
            foreach(Oportunidade u in oportunidades){
                if((u.ID.ToString() == idOuNome || u.TituloVaga == idOuNome) && u.CNPJ == cnpjEmpresa){
                    return u;
                }
            }
            return null;
        }

        //verificando se a vaga está aberta
        public static bool VerificarVagaAberta(string nomeOuID){
            Oportunidade oportunidade = Oportunidade.BuscarOportunidadePorIdOuTitulo(nomeOuID);

            if(oportunidade != null && oportunidade.StatusVaga == "Aberta"){
                return true;
            }else{
                return false;
            }
        }

        //tuple serve pra armazenar diversos tipos de referencias de diferentes tipos (string, int, double) ou (string, string, float)
        public static Tuple<string, string, string> GetTituloCNPJeNomeFantasiaById(int id){
            foreach(Oportunidade oportunidade in oportunidades){
                if(oportunidade.ID == id){
                    return Tuple.Create(oportunidade.TituloVaga, oportunidade.CNPJ, oportunidade.NomeFantasia); //armazena no tuple o necessario pra retorna
                }
            }
            return null; // ou levante uma exceção caso não encontre a oportunidade
        }

        //verifica o id da vaga q o usuario qer editar ou excluir e se pertence a ele
        public static Oportunidade VerificandoUsuarioParaAlteracoes(string id, string usuario){
            foreach(Oportunidade u in oportunidades){
                if((u.ID.ToString() == id || u.TituloVaga == id) && Usuario.usuarioLogado.Nome == usuario){
                    return u;
                }
            }
            return null;
        }

        public static bool VerificarVagaDaEmpresa(int idVaga){
            foreach(var vaga in oportunidades){
                if(vaga.ID == idVaga && vaga.CNPJ == Usuario.usuarioLogado.CNPJEmpresa){
                    return true;
                }
            }
            return false;
        }
    }
}
