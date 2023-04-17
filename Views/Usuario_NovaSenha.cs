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
    public partial class Usuario_NovaSenha : Form{
        public Usuario_NovaSenha(){
            InitializeComponent();
            campoSenha.Visible = false;
            labelSenha.Visible = false;
            campoNovaSenha.Visible = false;
            labelNovaSenha.Visible = false;
            btnConfirmar2.Visible = false;
            btnConfirmar3.Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e){
            if(campoSenhaAntiga.Text == Usuario.usuarioLogado.Senha){
                campoSenhaAntiga.Visible = false;
                label1.Visible = false;
                campoSenha.Visible = true;
                labelSenha.Visible = true;
                btnEditar.Visible = false;
                btnConfirmar2.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e){
            this.Hide();
        }

        private void btnConfirmar2_MouseClick(object sender, MouseEventArgs e){
            btnEditar.Visible = false;
            btnConfirmar2.Visible = false;
            campoNovaSenha.Visible = true;
            labelNovaSenha.Visible = true;
            btnConfirmar3.Visible = true;
        }

        private void btnConfirmar3_MouseClick(object sender, MouseEventArgs e){
            if(campoSenha.Text == campoNovaSenha.Text){
                Usuario.usuarioLogado.Senha = campoNovaSenha.Text;
                MessageBox.Show("Sua senha foi alterada com sucesso!");
            }else if(campoSenha.Text != campoNovaSenha.Text) MessageBox.Show("Os dois campos não coincidem.");
            else MessageBox.Show("Os campos estao vazios.");
        }
    }
}
