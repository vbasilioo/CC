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

    public partial class FecharVaga : Window
    {
        public FecharVaga(string titulo)
        {
            InitializeComponent();
            labelCandidato.Visibility = Visibility.Collapsed;
            List<Candidato> candidatos = Candidato.RetornarCandidatosPorTitulo(titulo);
            listaCandidatos.DataContext = new { Candidatos = candidatos };
        }

        private void TextBlock_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Candidato candidato = (Candidato)button.Tag;

            labelCandidato.Visibility = Visibility.Visible;
            labelCandidato.Content = $"Você selecionou o candidato {candidato.NomeCandidato} para a vaga.";

            Notificacao notificacao = new Notificacao
            {
                Titulo = "Nova seleção",
                Mensagem = $"Você foi selecionado para a vaga {candidato.TituloVaga}",
                Destinatario = candidato
            };

            Notificacao.AdicionarNotificacao(notificacao);
            Oportunidade.VerificarVagaCNPJ(Usuario.UsuarioLogado.CNPJEmpresa);
        }
    }
}
