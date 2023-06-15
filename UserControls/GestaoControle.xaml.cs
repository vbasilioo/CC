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

namespace CC.UserControls
{
    /// <summary>
    /// Interação lógica para GestaoControle.xam
    /// </summary>
    public partial class GestaoControle : UserControl
    {
        public GestaoControle()
        {
            InitializeComponent();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string titulo = txtTitulo.Text;
            string descricao = txtDescricao.Text;
            string requisitos = txtRequisitos.Text;
            string empresa = txtNomeempresa.Text;
            string status = txtStatus.Text;

            bool hasError = !double.TryParse(txtSalario.Text, out double salario);

            if (hasError)
            {
                lblErroSalario.Visibility = Visibility.Visible;
            }
            else
            {
                lblErroSalario.Visibility= Visibility.Collapsed;

                if (txtStatus.Text == "Aberta" || txtStatus.Text == "Fechada")
                {
                    Oportunidade.CadastrarOportunidadeNova(titulo, descricao, salario, requisitos, empresa, Usuario.UsuarioLogado.CNPJEmpresa, status);
                    lblSucessoCadastro.Visibility = Visibility.Visible;
                    lblDetalhes.Visibility = Visibility.Collapsed;
                }
                else
                {
                    MessageBox.Show("ERRO: Digite novamente se a vaga está 'Aberta' ou 'Fechada'");
                }
            }
        }
        
    }
 }
    

