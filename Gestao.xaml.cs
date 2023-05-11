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
using System.Windows.Shapes;

namespace CC
{
    /// <summary>
    /// Lógica interna para Gestao.xaml
    /// </summary>
    public partial class Gestao : Window
    {
        public Gestao()
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(GridOportunidades.SelectedItem != null)
            {
                Oportunidade oportunidadeSelecionada = (Oportunidade)GridOportunidades.SelectedItem;
                Oportunidade.oportunidadesAprovadas.Add(oportunidadeSelecionada);
                Oportunidade.oportunidades.Remove(oportunidadeSelecionada);
                GridOportunidades.Items.Refresh();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if(GridOportunidades.SelectedItem != null)
            {
                Oportunidade oportunidadeSelecionada = (Oportunidade)GridOportunidades.SelectedItem;
                Oportunidade.oportunidadesReprovadas.Add(oportunidadeSelecionada);
                Oportunidade.oportunidades.Remove(oportunidadeSelecionada);
                GridOportunidades.Items.Refresh();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if(GridOportunidades.SelectedItem != null)
            {
                Oportunidade oportunidadeSelecionada = (Oportunidade)GridOportunidades.SelectedItem;
                Oportunidade_Inscricao oport = new Oportunidade_Inscricao(oportunidadeSelecionada.ID);
                oport.Show();
            }
        }


        private void btnAssociar_Click(object sender, RoutedEventArgs e)
        {
            string nome = (GridCandidaturas.SelectedValue as Candidato)?.NomeCandidato;
            AssociarCandidato assoc = new AssociarCandidato(nome);
            assoc.Show();   
            this.Hide();
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

            Candidato.RemoverVaga(candidatoSelecionado);
            GridCandidaturas.Items.Refresh();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            BuscarCandidato busca = new BuscarCandidato();
            busca.Show();   
            this.Hide();
        }
    }
}
