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
    public partial class GestaoCoord : UserControl
    {
        public GestaoCoord()
        {
            InitializeComponent();
            ListarOportunidades();
        }

        private void ListarOportunidades()
        {
            var converter = new BrushConverter();
            ObservableCollection<Oportunidade> oportunidades = new ObservableCollection<Oportunidade>();
            GridOportunidades.ItemsSource =  Oportunidade.ListarOportunidades();
            GridCandidaturas.ItemsSource = Candidato.ListarInscritos(); 
        }

        private void btnAprovar_Click(object sender, RoutedEventArgs e)
        {
            if(GridOportunidades.SelectedItem != null)
            {
                Oportunidade oportunidadeSelecionada = (Oportunidade)GridOportunidades.SelectedItem;
                Oportunidade.oportunidadesAprovadas.Add(oportunidadeSelecionada);
                Oportunidade.oportunidades.Remove(oportunidadeSelecionada);
                oportunidadeSelecionada.ID = Oportunidade.oportunidadesAprovadas.Count-1;
                GridOportunidades.Items.Refresh();
            }
        }

        private void btnDeletar_Click(object sender, RoutedEventArgs e)
        {
            if(GridOportunidades.SelectedItem != null)
            {
                Oportunidade oportunidadeSelecionada = (Oportunidade)GridOportunidades.SelectedItem;
                Oportunidade.oportunidadesReprovadas.Add(oportunidadeSelecionada);
                Oportunidade.oportunidades.Remove(oportunidadeSelecionada);
                GridOportunidades.Items.Refresh();
            }
        }

        private void btnAssociar_Click(object sender, RoutedEventArgs e)
        {
            string nome = (GridCandidaturas.SelectedValue as Candidato)?.NomeCandidato;
            AssociarCandidato assoc = new AssociarCandidato(nome);
            assoc.Show();   
        }

        private void btnDesassociar_Click(object sender, RoutedEventArgs e)
        {
            string nome = (GridCandidaturas.SelectedValue as Candidato)?.NomeCandidato;
            Candidato candidatoSelecionado = null;  

            foreach(Candidato cand in Candidato.ListarInscritos())
            {
                if(cand.NomeCandidato == nome)
                {
                    candidatoSelecionado = cand;
                    break;
                }
            }

            if(candidatoSelecionado != null)
            {
                Candidato.RemoverVaga(candidatoSelecionado);
                GridCandidaturas.Items.Refresh();

                Candidato destinatario = new Candidato
                {
                    NomeCandidato = candidatoSelecionado.NomeCandidato
                };

                Notificacao notificacao = new Notificacao{
                    Titulo = "Desassociação de vaga",
                    Mensagem = $"O coordenador {Usuario.UsuarioLogado.Nome} desassociou você da vaga {candidatoSelecionado.TituloVaga}.",
                    Destinatario = destinatario
                };

                Notificacao.AdicionarNotificacao(notificacao);
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
