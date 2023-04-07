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
using System.Windows.Forms.VisualStyles;

namespace CareerConnect.Views{
    public partial class Editar_Oportunidade : Form{
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

                //preenche o combobox
                ComboboxStatus.DataSource = EnumItem.GetStatusVaga();
            }else{
                MessageBox.Show("A vaga não foi encontrada.");
                this.Close(); // fecha a tela de edição caso não encontre a vaga
            }
        }

        private void campoTituloVaga_TextChanged(object sender, EventArgs e){ }

        private void btnEditar_Click(object sender, EventArgs e){
            int id = int.Parse(campoID.Text);
            string status = ComboboxStatus.Text;

            if (Oportunidade.EditarVaga(id, campoTituloVaga.Text, campoDescricao.Text, double.Parse(campoSalario.Text), campoEmpresa.Text, campoCNPJ.Text, status)){
                MessageBox.Show("Vaga editada com sucesso!");
                this.Close();
            }else{
                MessageBox.Show("Não foi possível editar a vaga.");
            }
        }

        private void btnRetornar_Click(object sender, EventArgs e){
            this.Hide();
        }
    }
}
