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
    public partial class Associar_Candidato : Form{
        public Associar_Candidato(string idOuNome){
            InitializeComponent();

            Usuario usuario = Usuario.BuscarUsuarioEmailOuID(idOuNome);
            
            if(usuario != null){
                campoUsuario.Text = usuario.Nome.ToString();
                campoEmail.Text = usuario.Email.ToString();
            }
        }

        private void btnAssociar_Click(object sender, EventArgs e){
            if(int.TryParse(campoTelefone.Text, out int telefone)){
                if(campoComentarios.Text == "" || campoNomeSocial.Text == "" || campoComentarios.Text == "" && campoNomeSocial.Text == ""){
                    
                    campoComentarios.Text = "-";
                    campoNomeSocial.Text = "-";

                    try{
                        Oportunidade oportunidade = Oportunidade.BuscarOportunidadePorIdOuTitulo(campoNomeEmpresa.Text);
                        Candidatura.AdicionarVagaInscrita(oportunidade.ID, campoNomeSocial.Text, telefone, campoComentarios.Text);
                        MessageBox.Show("Candidato associado com sucesso!");
                        this.Hide();
                    }catch(System.NullReferenceException){
                        MessageBox.Show("exceçao no cadastrar");
                    }
                }else{
                    try{
                        Oportunidade oportunidade = Oportunidade.BuscarOportunidadePorIdOuTitulo(campoNomeEmpresa.Text);
                        Candidatura.AdicionarVagaInscrita(oportunidade.ID, campoNomeSocial.Text, telefone, campoComentarios.Text);
                        MessageBox.Show("Candidato associado com sucesso!");
                        this.Hide();
                    }catch(System.NullReferenceException){
                        MessageBox.Show("exceçao no cadastrar");
                    }
                }
            }else{
                MessageBox.Show("Insira apenas números para o seu telefone.");
            }
        }

        private void btnRetornar_Click(object sender, EventArgs e){
            this.Hide();
        }
    }
}
