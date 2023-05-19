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
    /// <summary>
    /// Lógica interna para CandidatoInformacoes.xaml
    /// </summary>
    public partial class CandidatoInformacoes : Window
    {

        private string empresa;
        public Candidato Candidato { get; set; }

        public CandidatoInformacoes(string nome, string empresa)
        {
            InitializeComponent();

            this.empresa = empresa; 
            var usuario = Candidato.ListarInscritos().FirstOrDefault(u => u.NomeCandidato == nome);

            if (usuario != null)
            {
                txtNomesocial.Text = usuario.NomeSocial;
                txtComentarios.Text = usuario.Comentarios;
                txtTelefone.Text = usuario.Telefone.ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(txtTelefone.Text, out int telefone))
            {
                if(txtComentarios.Text == "") txtComentarios.Text = "N/A";

                Oportunidade oportunidade = Oportunidade.BuscarOportunidadePorIdOuTitulo(empresa);
                Candidato.AdicionarInformacoesCandidato(Candidato.IDCandidato, txtNomesocial.Text, int.Parse(txtTelefone.Text), txtComentarios.Text);
                MessageBox.Show("adiciono as innfo");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
