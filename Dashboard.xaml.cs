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
    /// Lógica interna para Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {

        private bool Maximizado = false;

        public Dashboard()
        {
            InitializeComponent();
            ListarOportunidades();
            AlterarNomeCargo();
        }

        private void ListarOportunidades()
        {
            var converter = new BrushConverter();
            ObservableCollection<Oportunidade> oportunidades = new ObservableCollection<Oportunidade>();
            GridOportunidades.ItemsSource =  Oportunidade.ListarOportunidades();
        }

        private void AlterarNomeCargo()
        {
            string nome = Usuario.UsuarioLogado.Nome.Substring(0, Usuario.UsuarioLogado.Nome.LastIndexOf(" "));
            campoUsuario.Text = nome;
            campoCargo.Text = Usuario.UsuarioLogado.Cargo;
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
            Conversa conversa = new Conversa();
            conversa.Show();
            this.Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Gestao gestao = new Gestao();
            gestao.Show();
            this.Hide();
        }
    }
}
