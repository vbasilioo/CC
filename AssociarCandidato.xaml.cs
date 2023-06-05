using CC.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CC
{
    public partial class AssociarCandidato : Window
    {

        private string nomeCandidato;

        public AssociarCandidato(string nome)
        {
            InitializeComponent();  
            nomeCandidato = nome;

            var usuario = Candidato.ListarInscritos().FirstOrDefault(u => u.NomeCandidato == nome);

            if (usuario != null)
            {
                txtNome.Text = usuario.NomeCandidato;
                txtNomesocial.Text = usuario.NomeSocial;
                txtComentarios.Text = usuario.Comentarios;
                txtTelefone.Text = usuario.Telefone.ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(txtTelefone.Text, out int telefone))
            {
                if(txtComentarios.Text == "") txtComentarios.Text = "N/A";
                if(txtNomesocial.Text == "") txtNomesocial.Text = "N/A";

                Oportunidade oportunidade = Oportunidade.BuscarOportunidadePorIdOuTitulo(txtNomeEmpresa.Text);
                Candidato.AssociarCandidato(oportunidade.ID, txtNome.Text, txtNomesocial.Text, int.Parse(txtTelefone.Text), txtComentarios.Text);

                List<Candidato> candidatos = Candidato.RetornarCandidatosPorTitulo(oportunidade.TituloVaga);

                if(candidatos.Count > 0) {
                    Candidato destinatario = candidatos.FirstOrDefault(u => u.NomeCandidato == nomeCandidato);

                    if(destinatario != null){
                    Notificacao notificacao = new Notificacao
                    {
                        Titulo = "Nova associação",
                        Mensagem = $"O coordenador {Usuario.UsuarioLogado.Nome} associou você a vaga {oportunidade.TituloVaga}.",
                        Destinatario = destinatario
                    };

                    Notificacao.AdicionarNotificacao(notificacao);
                    }
                }
            }
        }
    }
}
