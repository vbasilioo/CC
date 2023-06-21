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
    public partial class EncerrarVaga : Window
    {
        public EncerrarVaga(int id)
        {
            InitializeComponent();
            List<Candidato> candidatos = Candidato.RetornarCandidatosPorID(id);
            ListBoxCandidatos.ItemsSource = candidatos;

            foreach(Candidato candidato in candidatos)
            {
                Console.WriteLine("------------------------------------------------\n");
                Console.WriteLine($"Nome: {candidato.NomeCandidato}, Curso: {candidato.Curso}\n");
            }
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
