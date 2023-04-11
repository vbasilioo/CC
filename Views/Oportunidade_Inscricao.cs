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
                try{
                    Oportunidade oportunidade = Oportunidade.BuscarOportunidadePorIdOuTitulo(campoNomeEmpresa.Text);
                    Candidatura.AdicionarVagaInscrita(oportunidade.ID, campoNomeSocial.Text, telefone, campoComentarios.Text);
                    this.Hide();
                }catch(System.NullReferenceException){
                    MessageBox.Show("exceçao no cadastrar");
                }
            }else{
                MessageBox.Show("Insira apenas números para o seu telefone.");
            }
        }

        private void btnRetornar_Click(object sender, EventArgs e){
            this.Hide();
        }

        private void campoNomeEmpresa_TextChanged(object sender, EventArgs e){}
    }
}
