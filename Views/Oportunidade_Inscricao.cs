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
    public partial class Oportunidade_Inscricao : Form{
        public Oportunidade_Inscricao(){
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e){
            Usuario usuario = Usuario.usuarioLogado;
            Candidato candidato = new Candidato(usuario.Nome, usuario.Endereco, usuario.DataNascimento, usuario.Email, campoNomeSocial.Text, campoTelefone.Text, campoComentarios.Text);
            //Console.WriteLine("" + candidato.Nome + "" + candidato.NomeSocial + "" + candidato.Telefone + "" + candidato.ComentariosInscricao);
        }

        private void btnRetornar_Click(object sender, EventArgs e){
            this.Hide();
        }
    }
}
