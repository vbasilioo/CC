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
    public partial class Atualizar_Candidatura : Form{
        public Atualizar_Candidatura(string idOuTitulo){
            InitializeComponent();
            Candidatura candidatura = Candidatura.BuscarInscricao(idOuTitulo);
            
            if(candidatura != null){
                campoID.Text = candidatura.ID.ToString();
                campoNomeSocial.Text = candidatura.NomeSocial;
                campoTelefone.Text = candidatura.Telefone.ToString();
                campoComentario.Text = candidatura.Comentarios;
            }else{
                MessageBox.Show("A inscrição não foi encontrada.");
                this.Close();
            }
        }

        private void btnRetornar_Click(object sender, EventArgs e){
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e){
            if(int.TryParse(campoID.Text, out int id)){
                Candidatura.EditarVagaInscrita(id.ToString(), campoNomeSocial.Text, int.Parse(campoTelefone.Text), campoComentario.Text);
            }else{
                Candidatura.EditarVagaInscrita(campoID.Text, campoNomeSocial.Text, int.Parse(campoTelefone.Text), campoComentario.Text);
            }
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e){}
    }
}
