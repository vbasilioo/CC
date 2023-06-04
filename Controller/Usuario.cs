using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Input;

namespace CC.Controller
{
    public class Usuario
    {
        /*           ATRIBUTOS          */
        public int ID { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public string? SenhaCriptografada { get; set; }
        public string? Cargo { get; set; }
        public int DataNascimento { get; set; }
        public string? Endereco { get; set; }   
        public string? Curso { get; set; }
        public string? CNPJEmpresa { get; set; }
        public int ContadorNotificacoes { get; set; }
        public static Usuario? UsuarioLogado { get; private set; }

        /*         CONSTRUTOR           */
        public static List<Usuario> usuariosCadastrados = new List<Usuario>(){
            new Usuario{
                ID = 0,
                Nome = "Vinícius Gonçalves Basílio",
                Email = "vinicius@gmail.com",
                Senha = "vinicius",
                SenhaCriptografada = "vinicius",
                Cargo = "Candidato",
                DataNascimento = 21,
                Endereco = "Jardim da Fonte, Cachoeira Paulista",
            },

            new Usuario{
                ID = 1,
                Nome = "Maria Clara Rocha",
                Email = "maria@gmail.com",
                Senha = "maria",
                SenhaCriptografada = "maria",
                Cargo = "Coordenador",
                DataNascimento = 19,
                Endereco = "Itagacaba, Cruzeiro"
            },

            new Usuario{
                ID = 2,
                Nome = "Eric Mendes",
                Email = "eric@gmail.com",
                Senha = "eric",
                SenhaCriptografada = "eric",
                Cargo = "Empresa",
                DataNascimento = 19,
                Endereco = "Centro, Cruzeiro",
                CNPJEmpresa = "45.186.994/0001-10"
            },

            new Usuario{
                ID = 3,
                Nome = "Maria Clara Conde",
                Email = "mcconde@gmail.com",
                Senha = "conde",
                SenhaCriptografada = "conde",
                Cargo = "Candidato",
                DataNascimento = 19,
                Endereco = "Centro, Cruzeiro"
            },

            new Usuario{
                ID = 4,
                Nome = "Gustavo Coutinho",
                Email = "gustavocoutinho@gmail.com",
                Senha = "gustavo",
                SenhaCriptografada = "gustavo",
                Cargo = "Empresa",
                DataNascimento = 19,
                Endereco = "Centro, Cruzeiro",
                CNPJEmpresa = "34.466.957/0001-40"
            },

            new Usuario
            {
                ID = 5,
                Nome = "Administrador Sistema",
                Email = "admin",
                Senha = "admin",
                SenhaCriptografada = "admin",
                Cargo = "Administrador",
                DataNascimento = 0,
                Endereco = "admin"
            }
        };

        public Usuario()
        {
            usuariosCadastrados ??= new List<Usuario>();
            ID = Usuario.usuariosCadastrados.Count;
        }

        // Esse construtor está sendo utilizado na classe Candidato
        public Usuario(string? nome, string? endereco, int idade, string? email)
        {
            Nome = nome;
            Endereco = endereco;
            Email = email;
            DataNascimento = idade;
            usuariosCadastrados.Add(this);
        }

        /*           MÉTODOS                */

        // Adiciona um novo usuário na lista
        public static void AdicionarUsuario(Usuario usuario)
        {
            usuariosCadastrados.Add(usuario);
        }

        // Verifica se existe 2 e-mails iguais
        public static bool VerificarEmailExiste(string? email)
        {
            return usuariosCadastrados.Any(u => u.Email == email);
        }

        // Resgata o e-mail e senha do usuário
        public static Usuario BuscarUsuario(string email, string senha)
        {
            return usuariosCadastrados.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }

        // Retorna a lista de usuários
        public static List<Usuario> ListarUsuarios()
        {
            return usuariosCadastrados;
        }

        // Busca o usuário por ID
        public static Usuario ObterUsuarioPorID(int id)
        {
            foreach(Usuario usuario in usuariosCadastrados)
            {
                if(usuario.ID == id)
                {
                    return usuario;
                }
            }
            return null;
        }

        // Busca o usuário através do nome OU do e-mail inserido
        public static Usuario BuscarUsuarioIDouEmail(string idOuEmail)
        {
            Usuario usuarioEncontrado = usuariosCadastrados.Find(u => u.ID.ToString() == idOuEmail || u.Email == idOuEmail);

            if(usuarioEncontrado != null && usuarioEncontrado.Cargo == "Candidato")
            {
                return usuarioEncontrado;
            }
            else
            {
                MessageBox.Show("O usuário não foi encontrado ou não é um candidato.");
            }

            return null;
        }

        public static int CalcularIdade(DateTime dataNascimento)
        {
            int idade = DateTime.Now.Year - dataNascimento.Year;

            if(DateTime.Now.Month < dataNascimento.Month || (DateTime.Now.Month == dataNascimento.Month && DateTime.Now.Day < dataNascimento.Day))
            {
                idade--;
            }

            return idade;
        }

        // Enviando mensagem de recuperação através do Whatsapp Web
        public static void EnviarWhatsapp(string numero, string email)
        {
            try
            {
                string mensagem = EsqueciMinhaSenha(email);

                if(numero == "")
                {
                    MessageBox.Show("Nenhum número foi adicionado");
                }

                if(numero.Length <= 0)
                {
                    numero = "+55" + numero;
                }

                numero = numero.Replace(" ", "");
                System.Diagnostics.Process.Start("https://web.whatsapp.com/send?phone=" + numero);

                Clipboard.SetText("Olá, Eu sou a Cecília, a Assistente Virtual do CareerConnect, e estou aqui para te ajudar a recuperar sua senha!\nEssa é a sua nova senha: " 
                    + mensagem + "\nFique atento, anote em algum lugar e não passe para mais ninguém!\nAgradecemos por escolher a gente no auxílio na busca de emprego!"
                    + "\n\nUm grande abraço, Cecília e Equipe CC!");

                // Espera 30s antes de enviar a mensagem
                Thread.Sleep(30000);

                // Coloca o texto no Whatsapp e envia
                Keyboard.IsKeyDown(Key.Enter);
                Keyboard.IsKeyUp(Key.Enter);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Gera números aleatórios para ser a nova senha do usuário
        private static string GerarNumeroAleatorio()
        {
            Random randNum = new Random();
            int numero = randNum.Next();
            return numero.ToString();
        }

        // Consome a API do Whatsapp para enviar mensagem com a nova senha
        public static string EsqueciMinhaSenha(string email)
        {
            var usuario = usuariosCadastrados.FirstOrDefault(u => u.Email == email);

            if(usuario == null)
            {
                MessageBox.Show("Esse e-mail não foi encontrado na lista de e-mail cadastrados. Tente novamente!");
            }

            string novaSenha = GerarNumeroAleatorio().ToString();
            return usuario.Senha = novaSenha;
        }

        // Autenticação para o sistema de login
        public static bool FazerLogin(string email, string senha)
        {
            Usuario usuario = BuscarUsuario(email, senha);

            if(usuario != null)
            {
                UsuarioLogado = usuario;
                return true;
            }
            else
            {
                return false;
            }
        }

        // Verifica o cargo do usuário dentro do Dashboard
        public static string VerificarCargoUsuario()
        {
            switch (UsuarioLogado?.Cargo)
            {
                case "Administrador":
                    return "Administrador";
                case "Candidato":
                    return "Candidato";
                case "Coordenador":
                    return "Coordenador";
                case "Empresa":
                    return "Empresa";
            }

            return null;
        }

        // Método que busca a lista de candidatos
        public static List<Usuario> BuscarCandidatos()
        {
            return usuariosCadastrados.FindAll(u => u.Cargo == "Candidato");
        }

        // Busca o usuário pelo seu e-mail ou pelo seu ID
        public static Usuario BuscarUsuarioEmailOuID(string emailOuID)
        {
            if(int.TryParse(emailOuID, out int id))
            {
                return usuariosCadastrados.FirstOrDefault(u => u.ID == id);
            }
            else
            {
                return usuariosCadastrados.FirstOrDefault(u => u.Email.ToLower() == emailOuID.ToLower());
            }
        }

        // Verifica se o CNPJ informado já existe
        public static bool VerificarCNPJExiste(string CNPJ)
        {
            return usuariosCadastrados.Any(u => u.CNPJEmpresa == CNPJ);
        }

        // Busca um usuário na DATAGRID e retorna
        public static void BuscarUsuarioNaGrid(string nomeOuID)
        {
            Usuario usuarioEncontrado = null;

            if(int.TryParse(nomeOuID, out int id))
            {
                usuarioEncontrado = usuariosCadastrados.FirstOrDefault(u => u.ID == id);
            }
            else
            {
                usuarioEncontrado = usuariosCadastrados.FirstOrDefault(u => u.Nome.ToLower() == nomeOuID.ToLower());
            }

            if(usuarioEncontrado != null)
            {
                // Adicionar código que encontra o usuário
            }
            else
            {
                MessageBox.Show("Candidato não encontrado.");
            }
        }

        // Busca a lista das empresas
        public static List<Usuario> ListarEmpresas()
        {
            return usuariosCadastrados.FindAll(u => u.Cargo == "Empresa");
        }

        // Busca o usuário através do CNPJ
        public static Usuario BuscarUsuarioPorCNPJ(string cnpj)
        {
            return usuariosCadastrados.FirstOrDefault(u => u.CNPJEmpresa == cnpj);
        }

        // Obtém o Usuário Logado
        public static Usuario GetUsuarioLogado(string cnpj)
        {
            int idUsuarioLogado = ObterIDUsuarioLogado(cnpj);

            if(idUsuarioLogado == -1) return null;

            foreach(Usuario usuario in usuariosCadastrados)
            {
                if(usuario.ID == idUsuarioLogado) return usuario;
            }

            return null;
        }

        // Obtém o ID do Usuário Logado
        public static int ObterIDUsuarioLogado(string cnpj)
        {
            int idUsuarioLogado = -1;

            foreach(Usuario usuario in usuariosCadastrados)
            {
                if(usuario.CNPJEmpresa == cnpj)
                {
                    idUsuarioLogado = usuariosCadastrados.IndexOf(usuario);
                    break;
                }
            }

            return idUsuarioLogado;
        }

        // Verifica a empresa 
        public static bool VerificarEmpresa(string cnpj, int id)
        {
            Usuario usuarioLogado = GetUsuarioLogado(cnpj);

            if(UsuarioLogado.CNPJEmpresa == cnpj) if(UsuarioLogado.ID == id) return true;

            return false;
        }

        // Método pega a idade e retorna como data de aniversário
        public static DateTime ObterDataNascimento(int idade)
        {
            DateTime dataAtual = DateTime.Now;
            int anoNascimento = dataAtual.Year - idade;
            int mesNascimento = dataAtual.Month;
            int diaNascimento = dataAtual.Day;

            if(dataAtual.Month < mesNascimento || (dataAtual.Month == mesNascimento && dataAtual.Day < diaNascimento))
            {
                anoNascimento--;
            }

            return new DateTime(anoNascimento, mesNascimento, diaNascimento);
        }

        // Edita os dados do usuário
        public static void EditarUsuario(Usuario usuarioLogado, string? nome, string? email, string? cargo, DateTime dataNascimento, string? endereco, string? cnpj)
        {
            usuarioLogado.Nome = nome;
            usuarioLogado.Email = email;
            usuarioLogado.Cargo = cargo;
            usuarioLogado.DataNascimento = CalcularIdade(dataNascimento);
            usuarioLogado.Endereco = endereco;
            usuarioLogado.CNPJEmpresa = cnpj;
            MessageBox.Show("Dados editados com sucesso!");
        }

        // Converte a idade para a data de nascimento correspondente
        public static DateTime CalcularDataNascimento(int idade)
        {
            var now = DateTime.Now;
            var dataNascimento = new DateTime(now.Year - idade, now.Month, now.Day);

            if(dataNascimento > now)
            {
                dataNascimento = dataNascimento.AddYears(-1);
            }

            return dataNascimento;
        }

        // Obtendo dados dos usuários por nome
        public static Usuario ObterUsuarioPorNome(string nome)
        {
            foreach(var usuario in usuariosCadastrados)
            {
                if(usuario.Nome == nome)
                {
                    return usuario;
                }
            }

            return null;
        }

        // Encontra o usuário através do nome
        public static void BuscarUsuarioPorNome(string nomeprocurado)
        {
            Usuario usuarioEncontrado = null;

            foreach(Usuario usuario in usuariosCadastrados)
            {
                if(usuario.Nome == nomeprocurado)
                {
                    usuarioEncontrado = usuario;
                }
            }

            if(usuarioEncontrado != null)
            {
                AssociarCandidato assoc = new AssociarCandidato(usuarioEncontrado.Nome);
                assoc.Show();
            }
            else
            {
                usuarioEncontrado = null;
            }
        }

        public static string BuscarUserNome(string nome)
        {
            Usuario usuarioEncontrado = null;

            foreach(Usuario usuario in usuariosCadastrados)
            {
                if(usuario.Nome == nome)
                {
                    usuarioEncontrado = usuario;
                    return usuarioEncontrado.ToString();
                }
            }

            return null;
        }

        // Busca o objeto do Usuário
        public static Usuario BuscarUsuarioObjeto(Usuario usuario)
        {
            return usuariosCadastrados.FirstOrDefault(u => u.Nome == usuario.Nome);
        }

        public static bool VerificarEmailCadastrado(string email)
        {
            foreach(Usuario usuario in usuariosCadastrados)
            {
                if(usuario.Email == email)
                {
                    return true;
                }
            }

            return false;
        }

        public static void RedefinirSenha(string email, string senha)
        {
            Usuario usuario = usuariosCadastrados.FirstOrDefault(u => u.Email == email);

            if(usuario != null)
            {
                string novaSenha = senha;
                usuario.Senha = novaSenha;
                usuario.SenhaCriptografada = BCrypt.Net.BCrypt.HashPassword(novaSenha);
            }
            else
            {
                MessageBox.Show("Esse e-mail é inválido.");
            }
        }
    }
}
