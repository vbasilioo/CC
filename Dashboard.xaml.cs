using CC.Controller;
using CC.UserControls;
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
    public partial class Dashboard : Window
    {

        private List<Oportunidade> listaPesquisa = new List<Oportunidade>();
        private List<Oportunidade> resultadoPesquisa = new List<Oportunidade>();
        private bool Maximizado = false;

        public Dashboard()
        {
            InitializeComponent();
            VerificarCargo();
            AlterarNomeCargo();
        }

        private void AlterarNomeCargo()
        {
            string nome = Usuario.UsuarioLogado.Nome.Substring(0, Usuario.UsuarioLogado.Nome.LastIndexOf(" "));
            campoUsuario.Text = nome;
            campoCargo.Text = Usuario.UsuarioLogado.Cargo;
        }

        private void VerificarCargo()
        {
            if(Usuario.VerificarCargoUsuario() == "Candidato")
            {
                //colunaAcoes.Visibility = Visibility.Collapsed;
                btnGestao.Visibility = Visibility.Collapsed;
                btnVagas.Visibility = Visibility.Collapsed;
                btnAdm.Visibility = Visibility.Collapsed;
            }else if(Usuario.VerificarCargoUsuario() == "Coordenador")
            {
                //colunaAcoes.Visibility = Visibility.Collapsed;
                btnVagas.Visibility = Visibility.Collapsed;
                btnAdm.Visibility = Visibility.Collapsed;
                btnCandidatura.Visibility = Visibility.Collapsed;
            }else if(Usuario.VerificarCargoUsuario() == "Empresa")
            {
                btnGestao.Visibility = Visibility.Collapsed;
                btnAdm.Visibility = Visibility.Collapsed;
                btnCandidatura.Visibility = Visibility.Collapsed;
            }
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ClickCount == 2)
            {
                if(Maximizado)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1680;
                    this.Height = 920;

                    Maximizado = false;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;

                    Maximizado = true;
                } 
            }
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow login = new MainWindow();
            login.Show();
            this.Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            contentDashboard.Children.Clear(); 
            GestaoCoord coord = new GestaoCoord();
            contentDashboard.Children.Add(coord);
        }

        private void btnVagas_Click(object sender, RoutedEventArgs e)
        {
            contentDashboard.Children.Clear();  
            GestaoControle gestao = new GestaoControle();
            contentDashboard.Children.Add(gestao);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
        }

        private void btnCandidatura_Click(object sender, RoutedEventArgs e)
        {
            contentDashboard.Children.Clear();  
            Candidaturas cand = new Candidaturas();
            contentDashboard.Children.Add(cand);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            contentDashboard.Children.Clear();  
            OportunidadesAprovadas aprov = new OportunidadesAprovadas();
            contentDashboard.Children.Add(aprov);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            contentDashboard.Children.Clear(); 
            Notificacoes notif = new Notificacoes();
            contentDashboard.Children.Add(notif);
        }
    }
}
