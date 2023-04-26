using CareerConnect.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CareerConnect.Views{
    public partial class Login_CadastrarUsuario : Form{

        private List<Usuario> usuarios = new List<Usuario>();

        public Login_CadastrarUsuario(){
            InitializeComponent();
            ComboboxCargo.DataSource = EnumItem.GetCargos();
            VerificarCargoCombobox();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void BotaoCadastrar_Click(object sender, EventArgs e){

            ComboboxCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            var dataNascimento = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            DateTime dataNascimentoConvertida = DateTime.ParseExact(dataNascimento, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            if(ComboboxCargo.SelectedItem.ToString() == "Selecione"){
                MessageBox.Show("Selecione um cargo válido.");
            }else{
            Usuario novoUsuario = new Usuario{
                Nome = campoNome.Text,
                Email = campoCadastrarEmail1.Text,
                Senha = campoCadastrarSenha.Text,
                Cargo = ComboboxCargo.SelectedItem.ToString(),
                DataNascimento = Usuario.CalcularIdade(dataNascimentoConvertida), //calculando idade
                Endereco = campoEndereco.Text,
                CNPJEmpresa = campoCNPJCadastrar.Text
            };

                //verificando se email existe, pra nao cadastra 2 contas cm msm email
                if(Usuario.VerificarEmailExiste(campoCadastrarEmail1.Text)){
                    MessageBox.Show("E-mail já cadastrado.");
                }else if(string.IsNullOrEmpty(campoNome.Text) || string.IsNullOrEmpty(campoCadastrarEmail1.Text) || string.IsNullOrEmpty(campoCadastrarSenha.Text)
                 || string.IsNullOrEmpty(campoEndereco.Text)){
                    MessageBox.Show("Há um campo não preenchido.");
                }else if(ComboboxCargo.Text == "Empresa"){
                    if(Usuario.VerificarCNPJExiste(campoCNPJCadastrar.Text)){
                        MessageBox.Show("Este CNPJ já está cadastrado.");
                    }else{
                    // cadastrando usuario caso ele aind nao exista
                    Usuario.AdicionarUsuario(novoUsuario);
                    MessageBox.Show("Usuário cadastrado com sucesso!");

                    campoNome.Clear();
                    campoCadastrarEmail1.Clear();
                    campoCadastrarSenha.Clear();
                    campoEndereco.Clear();

                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }
                }else{
                    // cadastrando usuario caso ele aind nao exista
                    Usuario.AdicionarUsuario(novoUsuario);
                    MessageBox.Show("Usuário cadastrado com sucesso!");

                    campoNome.Clear();
                    campoCadastrarEmail1.Clear();
                    campoCadastrarSenha.Clear();
                    campoEndereco.Clear();

                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }
            }
        }

        private void BotaoRetornar_Click(object sender, EventArgs e){
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        //pra verificar qual item selecionad no combobox é o empresa pra aparecer o CNPJ ou nao
        //pra cadastra cnpj direto no cadastro
        private void VerificarCargoCombobox(){
            if(ComboboxCargo.Text == "Empresa"){ 
                campoCNPJCadastrar.Visible = true; 
            }
            else{ 
                campoCNPJCadastrar.Visible = false; 
            }
        }

        private void ComboboxCargo_SelectedIndexChanged(object sender, EventArgs e){
            VerificarCargoCombobox();
        }
    }
}
