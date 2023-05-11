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
    public partial class Candidatura : Window
    {
        public Candidatura()
        {
            InitializeComponent();
            GridOportunidades.ItemsSource = Oportunidade.oportunidadesAprovadas;
            GridCandidaturas.ItemsSource = Candidato.ListarVagasInscritas();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(GridOportunidades.SelectedItem != null)
            {
                Oportunidade oportunidadeSelecionada = (Oportunidade)GridOportunidades.SelectedItem;
                
                Oportunidade_Inscricao oport = new Oportunidade_Inscricao(oportunidadeSelecionada.ID);
                oport.Show();
                this.Hide();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
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
