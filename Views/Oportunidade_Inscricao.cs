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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CareerConnect.Views{
    public partial class Oportunidade_Inscricao : Form{
        public Oportunidade_Inscricao(){
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e){
            //Candidato.AdicionarInscricao(campoNomeSocial.Text, campoTelefone.Text, campoComentarios.Text, campoNomeEmpresa.Text);
            //MessageBox.Show("Inscrição feita");
            //Candidato.ListarCandidatosInscritos();
            int telefone;

            if(int.TryParse(campoTelefone.Text, out telefone)){
                Candidatura.AdicionarVagaInscrita(campoNomeSocial.Text, telefone, campoComentarios.Text);
            }
        }

        private void btnRetornar_Click(object sender, EventArgs e){
            this.Hide();
        }
    }
}
