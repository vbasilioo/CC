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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace CC.UserControls
{

    public partial class OportunidadesAprovadas : UserControl
    {

        private DispatcherTimer timer;

        public OportunidadesAprovadas()
        {
            InitializeComponent();
            VerificarCargo();
            GridOportunidadesAprovadas.ItemsSource = Oportunidade.oportunidadesAprovadas;

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            GridOportunidadesAprovadas.Items.Refresh();
            GridOportunidadesAprovadas.ItemsSource = Oportunidade.oportunidadesAprovadas;
            GridOportunidadesAprovadas.Items.Refresh();
        }

         private void VerificarCargo()
         {
            if(Usuario.VerificarCargoUsuario() == "Candidato")
            {
                colunaAcoes.Visibility = Visibility.Collapsed;
            }else if(Usuario.VerificarCargoUsuario() == "Coordenador")
            {
                colunaAcoes.Visibility = Visibility.Collapsed;
            }
         } 

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Oportunidade oportunidade = button.DataContext as Oportunidade;
            int ID = oportunidade.ID;

            if(oportunidade.CNPJ == Usuario.UsuarioLogado.CNPJEmpresa)
            {
                Editar_Vaga editar = new Editar_Vaga(ID);
                editar.Show();
            }
            else
            {
                MessageBox.Show("A vaga não é sua para você poder editar.");
            }
        }

        private void btnRemover_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Oportunidade oportunidade = button.DataContext as Oportunidade;

            if(oportunidade.CNPJ == Usuario.UsuarioLogado.CNPJEmpresa)
            {
                Oportunidade.RemoverOportunidade(oportunidade);
                GridOportunidadesAprovadas.Items.Refresh();
            }
            else
            {
                MessageBox.Show("A vaga não é sua para você poder remover.");
            }
        }

        private void btnFechar_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Oportunidade oportunidade = button.DataContext as Oportunidade;
            
            if(oportunidade != null){
                if(oportunidade.CNPJ == Usuario.UsuarioLogado.CNPJEmpresa)
                {
                    FecharVaga fecharVaga = new FecharVaga(oportunidade.ID);   
                    fecharVaga.Show();
                    //EncerrarVaga fecharvaga = new EncerrarVaga(oportunidade.ID);
                    //fecharvaga.Show();
                }
                else
                {
                    MessageBox.Show("A vaga não é sua para você poder fechar.");
                }
            }
            else
            {
                MessageBox.Show("Oportunidade inválida.");
            }
        }
    }
}
