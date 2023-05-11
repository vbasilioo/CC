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
    public partial class Dashboard : Window
    {

        private List<Oportunidade> listaPesquisa = new List<Oportunidade>();
        private List<Oportunidade> resultadoPesquisa = new List<Oportunidade>();
        private bool Maximizado = false;

        public Dashboard()
        {
            InitializeComponent();
            GridOportunidadesAprovadas.ItemsSource = Oportunidade.oportunidadesAprovadas;
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
                colunaAcoes.Visibility = Visibility.Collapsed;
                btnChat.Visibility = Visibility.Collapsed;
                btnGestao.Visibility = Visibility.Collapsed;
                btnVagas.Visibility = Visibility.Collapsed;
                btnAdm.Visibility = Visibility.Collapsed;
            }else if(Usuario.VerificarCargoUsuario() == "Coordenador")
            {
                colunaAcoes.Visibility = Visibility.Collapsed;
                btnChat.Visibility = Visibility.Collapsed;
                btnVagas.Visibility = Visibility.Collapsed;
                btnAdm.Visibility = Visibility.Collapsed;
                btnCandidatura.Visibility = Visibility.Collapsed;
            }else if(Usuario.VerificarCargoUsuario() == "Empresa")
            {
                btnChat.Visibility = Visibility.Collapsed;
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Bate_papo chat = new Bate_papo();   
            chat.Show();    
            this.Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Gestao gestao = new Gestao();
            gestao.Show();
            this.Hide();
        }

        private void btnVagas_Click(object sender, RoutedEventArgs e)
        {
            Gestao_Controle controle = new Gestao_Controle();
            controle.Show();
            this.Hide();
        }

        private void campoPesquisar_TextChanged(object sender, TextChangedEventArgs e)
        {
            foreach(Oportunidade oportunidade in Oportunidade.oportunidadesAprovadas)
            {
                if (oportunidade.NomeFantasia.Contains(campoPesquisar.Text))
                {
                    resultadoPesquisa.Add(oportunidade);
                }
            }

            GridOportunidadesAprovadas.ItemsSource = resultadoPesquisa;

            if(campoPesquisar.Text == "")
            {
                GridOportunidadesAprovadas.ItemsSource = Oportunidade.oportunidadesAprovadas;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Oportunidade oportunidade = button.DataContext as Oportunidade;
            int ID = oportunidade.ID;

            if(oportunidade.CNPJ == Usuario.UsuarioLogado.CNPJEmpresa)
            {
                Editar_Vaga editar = new Editar_Vaga(ID);
                editar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("CNPJ inválido.");
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
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
                MessageBox.Show("CNPJ inválido.");
            }
        }

        private void btnCandidatura_Click(object sender, RoutedEventArgs e)
        {
            Candidatura candidatura = new Candidatura();
            candidatura.Show();
            this.Hide();
        }
    }
}
