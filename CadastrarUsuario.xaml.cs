using CC.Controller;
using System.Windows;
using System.Windows.Input;
using BCrypt.Net;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace CC
{
    public partial class CadastrarUsuario : Window
    {
        public string[] Cargos = { "Candidato", "Empresa" };

        public CadastrarUsuario()
        {
            InitializeComponent();
            txtCargo.DataContext = Cargos;
            LabelSucesso.Visibility = Visibility.Collapsed;
            LabelErro.Visibility = Visibility.Collapsed;
            txtCNPJ.Visibility = Visibility.Collapsed;
           TxtBlockCNPJ.Visibility = Visibility.Collapsed;
            txtCurso.Visibility = Visibility.Collapsed;
            txtBlockCurso.Visibility = Visibility.Collapsed;


        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left){
                this.DragMove();
            }
        }

       
   

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string senha = txtSenha.Password;
            string senhaCriptografada = BCrypt.Net.BCrypt.HashPassword(senha);
            string nome = txtNome.Text;

            string dataNascimentoString = txtIdade.Text;
            DateTime dataNascimento;
            //

            if (nome.Contains(" "))
            {
                if (DateTime.TryParseExact(dataNascimentoString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataNascimento))
                {
                    int idade = Usuario.CalcularIdade(dataNascimento);

                    Usuario novoUsuario = new Usuario
                    {
                        Nome = txtNome.Text,
                        Email = txtEmail.Text,
                        Senha = senha,
                        SenhaCriptografada = senhaCriptografada,
                        Cargo = txtCargo.Text,
                        Curso = txtCurso.Text,
                        DataNascimento = idade,
                        Endereco = txtResidencia.Text,
                        CNPJEmpresa = txtCNPJ.Text,

                    };

                    Usuario.AdicionarUsuario(novoUsuario);
                   LabelSucesso.Visibility = Visibility.Visible;
                   LabelErro.Visibility = Visibility.Collapsed;                 
                }
            }
            else
            {
                LabelSucesso.Visibility = Visibility.Collapsed;
                LabelErro.Visibility = Visibility.Visible;
            }
           

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow login = new MainWindow();
            login.Show();
            this.Hide();

        }

        private void txtCargo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedCargo = comboBox.SelectedItem as ComboBoxItem;

           if (selectedCargo != null)
            {
                string selecionado= selectedCargo.Content.ToString();
                if(selecionado == "Empresa")
                {
                    txtCNPJ.Visibility = Visibility.Visible;
                    TxtBlockCNPJ.Visibility = Visibility.Visible;
                    txtCurso.Visibility = Visibility.Collapsed;
                    txtBlockCurso.Visibility = Visibility.Collapsed;
                    
                }else if(selecionado == "Candidato")
                {
                    txtCNPJ.Visibility= Visibility.Collapsed;
                    TxtBlockCNPJ.Visibility = Visibility.Collapsed;
                    txtBlockCurso.Visibility = Visibility.Visible;
                    txtCurso.Visibility = Visibility.Visible;
                    
                }
            }

        }
    }
}
