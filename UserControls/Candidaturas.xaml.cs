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
    /// <summary>
    /// Interação lógica para Candidaturas.xam
    /// </summary>
    public partial class Candidaturas : UserControl
    {

        private ObservableCollection<Candidato> candidaturas;

        public Candidaturas()
        {
            InitializeComponent();
            GridOportunidades.ItemsSource = Oportunidade.oportunidadesAprovadas;
            GridCandidaturas.ItemsSource = Candidato.VagasCandidato;
        }

        private void btnAprovar_Click(object sender, RoutedEventArgs e)
        {
            if(GridOportunidades.SelectedItem != null)
            {
                Oportunidade oportunidadeSelecionada = (Oportunidade)GridOportunidades.SelectedItem;

                Candidato.AdicionarCandidato(oportunidadeSelecionada, oportunidadeSelecionada.NomeFantasia);

                CandidatoInformacoes cand = new CandidatoInformacoes(Usuario.UsuarioLogado.Nome, oportunidadeSelecionada.TituloVaga);
                cand.Candidato = Candidato.ListarInscritos().FirstOrDefault(u => u.NomeCandidato == Usuario.UsuarioLogado.Nome);
                cand.Show();

                GridCandidaturas.Items.Refresh();   
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(GridCandidaturas.SelectedItem != null)
            {
                Candidato candidatoSelecionado = (Candidato)GridCandidaturas.SelectedItem;
                Candidato.RemoverVaga(candidatoSelecionado);
                GridCandidaturas.ItemsSource = Candidato.ListarVagasInscritas();
                GridCandidaturas.Items.Refresh();
            }
        }
    }
}
