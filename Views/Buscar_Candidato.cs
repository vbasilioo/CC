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
    public partial class Buscar_Candidato : Form{

        private Usuario usuario;

        public Buscar_Candidato(Usuario usuarioEncontrado){
            InitializeComponent();
            usuario = usuarioEncontrado;
            PreencherCampos();
        }

        private void PreencherCampos(){
            campoNomeBC.Text = usuario.Nome;
            campoEmailBC.Text = usuario.Email;
            campoIdadeBC.Text = usuario.DataNascimento.ToString();
            campoEnderecoBC.Text = usuario.Endereco;
        }

        private void btnOK_Click(object sender, EventArgs e){
            this.Hide();
        }
    }
}
