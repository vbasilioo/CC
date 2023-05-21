using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC.Controller
{
    public class Notificacao
    {
        public int IDNotificacao { get; set; }
        public string? Titulo { get; set; }
        public string? Mensagem { get; set; }
        public Candidato Destinatario { get; set; }
        public Usuario UsuarioDestinatario { get; set; }
        public static List<Notificacao> listaNotificacoes { get; set; } = new List<Notificacao>();

        public Notificacao()
        {
            
        }

        public static void AdicionarNotificacao(Notificacao notificacao)
        {
            listaNotificacoes.Add(notificacao);  
        }

        public static List<Notificacao> ListarNotificacoes()
        {
            return listaNotificacoes;
        }  

        public static void AdicionarNotificacaoCoordenador(string titulo, string mensagem)
        {
            List<Usuario> coordenadores = Usuario.usuariosCadastrados
                .Where(u => u.Cargo == "Coordenador").ToList();

            foreach(Usuario coordenador in coordenadores)
            {
                Notificacao notificacaoCoordenador = new Notificacao
                {
                    Titulo = titulo,
                    Mensagem = mensagem,
                    UsuarioDestinatario = coordenador
                };

                AdicionarNotificacao(notificacaoCoordenador);
            }
        }

        public static void AdicionarNotificacaoEmpresa(string titulo, string mensagem)
        {
            List<Usuario> empresas = Usuario.usuariosCadastrados
                .Where(u => u.Cargo == "Empresa").ToList();

            foreach(Usuario empresa in empresas)
            {
                Notificacao notificacaoEmpresa = new Notificacao
                {
                    Titulo = titulo,
                    Mensagem = mensagem,
                    UsuarioDestinatario = empresa
                };

                AdicionarNotificacao(notificacaoEmpresa);
            }
        }
    }
}
