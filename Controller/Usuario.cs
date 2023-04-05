using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System;
using System.Threading;
using CareerConnect.Views;

namespace CareerConnect.Controller{
    public class Usuario{
        
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Cargo { get; set; }
        public int DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string CNPJEmpresa { get; set; }
        public static Usuario usuarioLogado { get; private set; }

        // lista estatica com usuarios cadastrados
        private static List<Usuario> usuariosCadastrados = new List<Usuario>(){
            new Usuario(){
                ID = 0,
                Nome = "Vinicius Gonçalves Basílio",
                Email = "vinicius@gmail.com",
                Senha = "vinicius",
                Cargo = "Candidato",
                DataNascimento = 21,
                Endereco = "Jardim da Fonte, Cachoeira Paulista",
            },

            new Usuario(){
                ID = 1,
                Nome = "Maria Clara Rocha",
                Email = "maria@gmail.com",
                Senha = "maria",
                Cargo = "Coordenador",
                DataNascimento = 19,
                Endereco = "Itagacaba, Cruzeiro"
            },

            new Usuario(){
                ID = 2,
                Nome = "Eric Mendes",
                Email = "eric@gmail.com",
                Senha = "eric",
                Cargo = "Empresa",
                DataNascimento = 19,
                Endereco = "Centro, Cruzeiro",
                CNPJEmpresa = "45.186.994/0001-10"
            },

            new Usuario(){
                ID = 3,
                Nome = "Maria Clara Conde",
                Email = "mcconde@gmail.com",
                Senha = "conde",
                Cargo = "Candidato",
                DataNascimento = 19,
                Endereco = "Centro, Cruzeiro"
            },

            new Usuario(){
                ID = 4,
                Nome = "Gustavo Coutinho",
                Email = "gustavocoutinho@gmail.com",
                Senha = "gustavo",
                Cargo = "Empresa",
                DataNascimento = 19,
                Endereco = "Centro, Cruzeiro",
                CNPJEmpresa = "34.466.957/0001-40"
            }
        };

        public Usuario(){ 
            if(usuariosCadastrados == null){
                usuariosCadastrados = new List<Usuario>();
            }
            ID = Usuario.usuariosCadastrados.Count;
            //Console.WriteLine("ID: " + ID);
        }

        // adiciona um novo usuario na lista
        public static void AdicionarUsuario(Usuario usuario){
                usuariosCadastrados.Add(usuario);
        }

        // verificando se o email existe na hora de cadastra, pra evita cadastro de 2 ocnta cm msm email
        public static bool VerificarEmailExiste(string email){
            return usuariosCadastrados.Any(u => u.Email == email);
        }

        // metodo pra resgata email e senha do usuario
        public static Usuario BuscarUsuario(string email, string senha){
            return usuariosCadastrados.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }

        //metodo pra calcular idade [vai pegar o dia/mes/ano selecionado no calendario e subtrair pelo atual]
        public static int CalcularIdade(DateTime dataNascimento){
            int idade = DateTime.Now.Year - dataNascimento.Year;

            if (DateTime.Now.Month < dataNascimento.Month || (DateTime.Now.Month == dataNascimento.Month && DateTime.Now.Day < dataNascimento.Day)){
                idade--;
            }

            return idade;
        }

        // enviando mensagem pelo whatsappweb da nova senha
         public static void enviarWhatsApp(string numero, string email){
            try{
                string mensagem = Usuario.EsqueciMinhaSenha(email);

                if(numero == ""){
                    MessageBox.Show("Nenhum número adicionado!");
                }

                if(numero.Length <= 0){
                    numero = "+55" + numero;
                }

                numero = numero.Replace(" ", "");
                System.Diagnostics.Process.Start("https://web.whatsapp.com/send?phone=" + numero); // abre o zap web e o número selecionado

                // espera 35s e dps envia a mensagem automaticamente (35s por ter internets mais lentas)
                Thread.Sleep(35000); 

                SendKeys.SendWait("Olá, Eu sou a Cecília, a Assistente Virtual do CareerConnect, e estou aqui para te ajudar a recuperar sua senha!\nEssa é a sua nova senha: " 
                    + mensagem + "\nFique atento, anote em algum lugar e não passe para mais ninguém!\nAgradecemos por escolher a gente no auxílio na busca de emprego!"
                    + "\n\nUm grande abraço, Cecília e Equipe CC!");
                SendKeys.SendWait("{ENTER}");
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        //gera numeros aleatorios pra ser a nova senha da pessoa
        private static string gerarNumeroAleatorioWhatsApp(){
            Random randNum = new Random();
            int numero = randNum.Next();
            return numero.ToString();
        }

        //consome a API do zapzap pra enviar mensagem com senha aleatoria pro individuo
        public static string EsqueciMinhaSenha(string email){
            var usuario = usuariosCadastrados.FirstOrDefault(u => u.Email == email);

            if(usuario == null){
                MessageBox.Show("Esse e-mail não foi encontrado na lista de e-mail cadastrados. Tente novamente!");
            }

            string novaSenha = gerarNumeroAleatorioWhatsApp().ToString();
            return usuario.Senha = novaSenha;
        }

        //autenticao  usuario na hora do login
        public static bool FazerLogin(string email, string senha){
           Usuario usuario = Usuario.BuscarUsuario(email, senha);

           if (usuario != null){
               usuarioLogado = usuario;
               Dashboard dashboard = new Dashboard();
               dashboard.Show();
               return true;
           }else{
                MessageBox.Show("Email ou senha incorretos!");
               return false;
           }
        }

        //verifica o cargo do usuario lgoado pra ocultar ou deixar amostra os botoes
        public static string VerificarCargoUsuario(){
            switch(usuarioLogado.Cargo){
                case "Candidato":
                    return "Candidato";
                case "Coordenador":
                    return "Coordenador";
                case "Empresa":
                    return "Empresa";
                case "Selecione":
                    return "";
                default:
                    return "Outros";
            }
        }

        //metodo q busca (cria a lista) de candidatos
        public static List<Usuario> BuscarCandidatos(){
            return usuariosCadastrados.FindAll(usuario => usuario.Cargo == "Candidato");
        }

        //buscar usuario pro email ou id
        public static Usuario BuscarUsuarioEmailOuID(string emailOuID){
            if(int.TryParse(emailOuID, out int id)){ //verificando se é int
                return usuariosCadastrados.FirstOrDefault(u => u.ID == id); // busca por ID
            }else{
                return usuariosCadastrados.FirstOrDefault(u => u.Email.ToLower() == emailOuID.ToLower()); // busca o email td minusculo pra evitar erros
            }
        }

        //verificar se CNPJ do usuario ja existe
        public static bool VerificarCNPJExiste(string cnpj){
            return usuariosCadastrados.Any(u => u.CNPJEmpresa == cnpj);
        }

        //metodo que busca o usuario na grid oportunidades e retorna se achou ou nao
        public static void BuscarUsuarioNaGrid(string nomeOuID){
            Usuario usuarioEncontrado = null;
            if(int.TryParse(nomeOuID, out int id)){ //verificando se é int{
                usuarioEncontrado = usuariosCadastrados.FirstOrDefault(u => u.ID == id); // busca por ID
            }else{
                usuarioEncontrado = usuariosCadastrados.FirstOrDefault(u => u.Nome.ToLower() == nomeOuID.ToLower()); // busca o nome todo minúsculo pra evitar erros
            }

            if(usuarioEncontrado != null){
                Buscar_Candidato formBuscarCandidato = new Buscar_Candidato(usuarioEncontrado);
                formBuscarCandidato.Show();
            }else{
                MessageBox.Show("Candidato não encontrado!");
            }
        }
    }
}
