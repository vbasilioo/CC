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
    public partial class Editar_Vaga : Window
    {
        private int IDvaga = -1;

        public Editar_Vaga(int id)
        {
            InitializeComponent();
            IDvaga = id;
            CarregarDados();
        }

        private void CarregarDados()
        {
            Oportunidade oportunidade = Oportunidade.BuscarOportunidadePorId(IDvaga);

            if(oportunidade != null )
            {
                txtTitulo.Text = oportunidade.TituloVaga;
                txtDescricao.Text = oportunidade.DescricaoVaga;
                txtSalario.Text = oportunidade.SalarioVaga.ToString();
                txtRequisitos.Text = oportunidade.Requisitos;
                txtNomeempresa.Text = oportunidade.NomeFantasia;
                txtStatus.Text = oportunidade.StatusVaga;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Oportunidade.EditarVaga(IDvaga.ToString(), txtTitulo.Text, txtDescricao.Text, double.Parse(txtSalario.Text), txtRequisitos.Text, txtNomeempresa.Text, Usuario.UsuarioLogado.CNPJEmpresa, txtStatus.Text);
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
