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
    /// Lógica interna para Oportunidade_Inscricao.xaml
    /// </summary>
    public partial class Oportunidade_Inscricao : Window
    {
        private int id = -1;

        public Oportunidade_Inscricao(int ID)
        {
            InitializeComponent();
            id = ID;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(txtTelefone.Text, out int telefone))
            {
                if(txtNomeSocial.Text == "") txtNomeSocial.Text = "N/A";
                if(txtComentarios.Text == "") txtComentarios.Text = "N/A";

                Oportunidade oportunidade = Oportunidade.BuscarOportunidadePorId(id);
                Candidato.AdicionarVaga(oportunidade.ID, txtNomeSocial.Text, telefone, txtComentarios.Text);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Candidatura candidatura = new Candidatura();
            candidatura.Show();
            this.Hide();
        }
    }
}
