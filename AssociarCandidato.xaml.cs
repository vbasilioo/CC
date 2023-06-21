using CC.Controller;
using CC.UserControls;
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
        private Candidato candidato;
        private Oportunidade oportunidade;

        public AssociarCandidato(string nome)
        {
            InitializeComponent(); 
            PreencherCombobox();
            nomeCandidato = nome;
            lblSucessoAssoc.Visibility = Visibility.Collapsed;

            var usuario = Candidato.ListarInscritos().FirstOrDefault(u => u.NomeCandidato == nome);

            if (usuario != null)
            {
                txtNome.Text = usuario.NomeCandidato;
                txtComentarios.Text = usuario.Comentarios;
                txtTelefone.Text = usuario.Telefone.ToString();
            }
        }

        private void PreencherCombobox()
        {
            List<Oportunidade> oportunidades = Oportunidade.oportunidadesAprovadas;
            cmbVagas.ItemsSource = oportunidades;
            cmbVagas.DisplayMemberPath = "TituloVaga";
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtTelefone.Text, out int telefone))
            {
                if (string.IsNullOrEmpty(txtComentarios.Text))
                    txtComentarios.Text = "N/A";

                Oportunidade oportunidade = cmbVagas.SelectedItem as Oportunidade;
                int idVaga = oportunidade.ID;

                string tituloVaga = Oportunidade.BuscarOportunidadePorId(idVaga)?.TituloVaga;
                if (!string.IsNullOrEmpty(tituloVaga))
                {
                    Candidato.AssociarCandidato(idVaga, txtNome.Text, int.Parse(txtTelefone.Text), txtComentarios.Text);

                    Candidato destinatario = new Candidato
                    {
                        NomeCandidato = txtNome.Text
                    };

                    Notificacao notificacao = new Notificacao
                    {
                        Titulo = "Nova associação",
                        Mensagem = $"O coordenador {Usuario.UsuarioLogado.Nome} associou você à vaga {tituloVaga}.",
                        Destinatario = destinatario
                    };

                    lblSucessoAssoc.Visibility = Visibility.Visible;
                    Notificacao.AdicionarNotificacao(notificacao);
                    Notificacao.AdicionarNotificacaoCoordenador("Nova associação", $"Você associou {destinatario.NomeCandidato} à vaga {tituloVaga}.");
                }
                else
                {
                    MessageBox.Show("A vaga selecionada não foi encontrada.");
                }
            }
        }
    }
}
