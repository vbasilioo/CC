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

namespace CareerConnect.Views{
    public partial class Usuario_Configuracoes : Form{
        public Usuario_Configuracoes(){
            InitializeComponent();
            campoCNPJ.Visible = false;
            labelCNPJ.Visible = false;
            campoNome.Text = Usuario.usuarioLogado.Nome;
            campoEmail.Text = Usuario.usuarioLogado.Email;
            campoEndereco.Text=  Usuario.usuarioLogado.Endereco;
            campoCargo.Text = Usuario.usuarioLogado.Cargo;
            campoDataNascimento.Value = Usuario.ObterDataNascimento(Usuario.usuarioLogado.DataNascimento);
            if(Usuario.usuarioLogado.Cargo == "Empresa"){
                campoCNPJ.Text = Usuario.usuarioLogado.CNPJEmpresa;
                campoCNPJ.Visible = true;
                labelCNPJ.Visible = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e){
            Usuario usuarioLogado = Usuario.usuarioLogado;
            Usuario.EditarUsuario(usuarioLogado, campoNome.Text, campoEmail.Text, campoCargo.Text, campoDataNascimento.Value, campoEndereco.Text, campoCNPJ.Text);
        }

        private void btnEditarSenha_Click(object sender, EventArgs e){
            Usuario_NovaSenha novasenha = new Usuario_NovaSenha();
            novasenha.Show();
            this.Hide();
        }
    }
}
