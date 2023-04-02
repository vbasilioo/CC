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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CareerConnect.Views{
    public partial class Login_EsqueciSenha : Form{
        public Login_EsqueciSenha(){
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void botaoRecuperar_Click(object sender, EventArgs e){
            string numero = campoNumeroEsqueciSenha.Text;
            string email = campoEmail.Text;

            Usuario.enviarWhatsApp(numero, email);

            campoNumeroEsqueciSenha.Text = "";
            campoEmail.Text = "";
        }

        private void botaoRetornar_Click(object sender, EventArgs e){
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
