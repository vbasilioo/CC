using CC.Controller;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CC.UserControls
{
    public partial class Candidaturas : UserControl
    {

        private ObservableCollection<Candidato> candidaturas;

        public Candidaturas()
        {
            InitializeComponent();
            GridOportunidades.ItemsSource = Oportunidade.oportunidadesAprovadas;
        }

        private void btnAprovar_Click(object sender, RoutedEventArgs e)
        {
            if(GridOportunidades.SelectedItem != null)
            {
                Oportunidade oportunidadeSelecionada = (Oportunidade)GridOportunidades.SelectedItem;

                if(oportunidadeSelecionada.StatusVaga == "Aberta"){

                    Candidato.AdicionarCandidato(oportunidadeSelecionada, oportunidadeSelecionada.ID);
                    Notificacao notificacao = new Notificacao
                    {
                        Titulo = "Nova candidatura",
                        Mensagem = $"Você se candidatou para a vaga {oportunidadeSelecionada.TituloVaga}.",
                        UsuarioDestinatario = Usuario.UsuarioLogado
                    };

                    Notificacao.AdicionarNotificacao(notificacao);
                    Notificacao.AdicionarNotificacaoCoordenador("Nova Inscrição", $"O candidato {Usuario.UsuarioLogado.Nome} se inscreveu para a vaga {oportunidadeSelecionada.TituloVaga}.");
                    MessageBox.Show($"Você se candidatou para a vaga {oportunidadeSelecionada.TituloVaga}.");
                }
                else
                {
                    MessageBox.Show("A vaga está fechada. Não é possível se candidatar.");
                }
            }
        }
    }
}
