using CareerConnect.Controller;
using CareerConnect.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace CareerConnect{
    public partial class Login : KryptonForm{
        public Login(){
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void btnEsqueciMinhaSenha_Paint(object sender, PaintEventArgs e){}

        private void btnEntrar_Click(object sender, EventArgs e){
            if(Usuario.FazerLogin(campoEmail.Text, campoSenha.Text)){
                this.Hide();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e){
            Login_CadastrarUsuario lcu = new Login_CadastrarUsuario();
            lcu.Show();
            this.Hide();
        }

        private void btnSair_Click_1(object sender, EventArgs e){
            Environment.Exit(0);
        }

        private void btnEsqueciMinhaSenha_Click(object sender, EventArgs e)
        {
            Login_EsqueciSenha les = new Login_EsqueciSenha();
            les.Show();
            this.Hide();
        }

        private void btnEntrar_MouseEnter(object sender, EventArgs e){}

        private void btnEntrar_MouseLeave(object sender, EventArgs e){}

        private void btnEntrar_MouseHover(object sender, EventArgs e){}
    }
}
