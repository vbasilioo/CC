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
    public partial class AssociarCandidato : Window
    {
        public AssociarCandidato(string nome)
        {
            InitializeComponent();  
            
            var usuario = Candidato.ListarInscritos().FirstOrDefault(u => u.NomeCandidato == nome);

            if (usuario != null)
            {
                txtNome.Text = usuario.NomeCandidato;
                txtNomesocial.Text = usuario.NomeSocial;
                txtComentarios.Text = usuario.Comentarios;
                txtTelefone.Text = usuario.Telefone.ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(txtTelefone.Text, out int telefone))
            {
                if(txtNome.Text == "") txtNome.Text = "N/A";
                if(txtComentarios.Text == "") txtComentarios.Text = "N/A";

                Oportunidade oportunidade = Oportunidade.BuscarOportunidadePorIdOuTitulo(txtNomeEmpresa.Text);
                Candidato.AssociarCandidato(oportunidade.ID, txtNome.Text, txtNomesocial.Text, int.Parse(txtTelefone.Text), txtComentarios.Text);
            }
        }
    }
}
