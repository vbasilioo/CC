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
    public partial class Editar_Oportunidade : Form{

        private Oportunidade _oportunidade;
        private Vagas _vagas;

        public Editar_Oportunidade(string idOuTitulo){
            InitializeComponent();

            //carregando infos da vaga procurada
            Oportunidade oportunidade = Oportunidade.BuscarOportunidadePorIdOuTitulo(idOuTitulo);
            if (oportunidade != null){
                campoID.Text = oportunidade.ID.ToString(); 
                campoTituloVaga.Text = oportunidade.TituloVaga;
                campoDescricao.Text = oportunidade.DescricaoVaga;
                campoSalario.Text = oportunidade.SalarioVaga.ToString();
                campoEmpresa.Text = oportunidade.NomeFantasia;
                campoCNPJ.Text = oportunidade.CNPJ;
            }else{
                MessageBox.Show("A vaga não foi encontrada.");
                this.Close(); // fecha a tela de edição caso não encontre a vaga
            }
        }

        private void campoTituloVaga_TextChanged(object sender, EventArgs e){ }

        private void btnEditar_Click(object sender, EventArgs e){
            int id;
            bool parsed = int.TryParse(campoID.Text, out id);

            if(parsed){
                Oportunidade.EditarVaga(id.ToString(), campoTituloVaga.Text, campoDescricao.Text, double.Parse(campoSalario.Text), campoEmpresa.Text, campoCNPJ.Text);
                this.Close();
            }else{
                Oportunidade.EditarVaga(campoID.Text, campoTituloVaga.Text, campoDescricao.Text, double.Parse(campoSalario.Text), campoEmpresa.Text, campoCNPJ.Text);
                this.Close();
            }
        }
    }
}
