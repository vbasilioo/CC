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

    public partial class FecharVaga : Window
    {
        public FecharVaga(int id)
        {
            InitializeComponent();
            List<Candidato> candidatos = Candidato.RetornarCandidatosPorID(id);
            GridCandidatos.ItemsSource = candidatos;
        }

        private void btnSelecionar_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Candidato candidato = (Candidato)button.DataContext;

            if (candidato != null)
            {
                Notificacao notificacao = new Notificacao
                {
                    Titulo = "Nova seleção",
                    Mensagem = $"Você foi selecionado para a vaga {candidato.TituloVaga}.",
                    Destinatario = candidato
                };

                Notificacao.AdicionarNotificacao(notificacao);
                Notificacao.AdicionarNotificacaoCoordenador("Nova Seleção", $"O candidato {candidato.NomeCandidato} foi selecionado para a vaga {candidato.TituloVaga}.");
                Notificacao.AdicionarNotificacaoEmpresa("Nova Seleção", $"Você selecionou o candidato {candidato.NomeCandidato} para a vaga {candidato.TituloVaga}.");
                Oportunidade.VerificarVagaCNPJ(Usuario.UsuarioLogado.CNPJEmpresa);

                MessageBox.Show($"O {candidato.NomeCandidato} foi selecionado para a vaga.");
                this.Hide();
            }
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }

        }
    }
}
