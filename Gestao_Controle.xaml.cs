using CC.Controller;
using System;
using System.Security.Cryptography;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;

namespace CC
{
    public partial class Gestao_Controle : Window
    {
        public Gestao_Controle()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ClickCount == 2)
            {
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                this.WindowState = WindowState.Normal;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string titulo = txtTitulo.Text;
            string descricao = txtDescricao.Text;
            string cnpj = txtCNPJ.Text;
            string requisitos = txtRequisitos.Text;
            string empresa = txtNomeempresa.Text;
            string status = txtStatus.Text;

            if(Usuario.UsuarioLogado.Cargo == "Empresa")
            {
                if(Usuario.UsuarioLogado.CNPJEmpresa == cnpj)
                {
                    if (Double.TryParse(txtSalario.Text, out double salario)) 
                    {
                        Oportunidade.CadastrarOportunidadeNova(titulo, descricao, salario, requisitos, empresa, cnpj, status);
                        lblSucessoCadastro.Visibility = Visibility.Visible;
                        lblDetalhes.Visibility = Visibility.Collapsed;
                    }
                    else
                    {
                    }
                }
                else
                {
                    return;
                }
            }
        }
    }
}
