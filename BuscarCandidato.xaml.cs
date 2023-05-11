    using CC.Controller;
using System.Windows;
using System.Windows.Documents;

namespace CC
{
    public partial class BuscarCandidato : Window
    {
        public BuscarCandidato()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var usuario = Candidato.ListarCandidato(txtNome.Text);
            
            if(usuario!= null)
            {
                string informacoes = $"Nome: {usuario.NomeCandidato}\nNome Social: {usuario.NomeSocial}\nTelefone: {usuario.Telefone}\nVaga: {usuario.TituloVaga}";
                MessageBox.Show(informacoes);
            }
            else
            {
                MessageBox.Show("Usuário não encontrado.");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Gestao gestao = new Gestao();
            gestao.Show();
            this.Hide();
        }
    }
}
