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
    public partial class Desassociar_Candidato : Form{
        public Desassociar_Candidato(){
            InitializeComponent();
            ListarCandidaturas();
        }

        private void ListarCandidaturas(){
            GridOportunidades.Columns.Clear();
            GridOportunidades.DataSource = Candidatura.ListarInscritos();
            GridOportunidades.ReadOnly = true;
            GridOportunidades.DefaultCellStyle.Padding = new Padding(0, 10, 0, 10);
            GridOportunidades.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GridOportunidades.RowTemplate.Height = 45;
            GridOportunidades.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            GridOportunidades.Columns["ID"].HeaderText = "ID";
            GridOportunidades.Columns["ID"].Width = 100;
            GridOportunidades.Columns["ID"].HeaderCell.Style.Font = new Font("Arial", 12, FontStyle.Bold);
            GridOportunidades.Columns["Nome"].HeaderText = "Nome";
            GridOportunidades.Columns["Nome"].Width = 200;
            GridOportunidades.Columns["Nome"].HeaderCell.Style.Font = new Font("Arial", 12, FontStyle.Bold);
            GridOportunidades.Columns["NomeSocial"].HeaderText = "Nome Social";
            GridOportunidades.Columns["NomeSocial"].Width = 120;
            GridOportunidades.Columns["NomeSocial"].HeaderCell.Style.Font = new Font("Arial", 12, FontStyle.Bold);
            GridOportunidades.Columns["Telefone"].HeaderText = "Telefone";
            GridOportunidades.Columns["Telefone"].Width = 90;
            GridOportunidades.Columns["Telefone"].HeaderCell.Style.Font = new Font("Arial", 12, FontStyle.Bold);
            GridOportunidades.Columns["Comentarios"].HeaderText = "Comentários";
            GridOportunidades.Columns["Comentarios"].Width = 200;
            GridOportunidades.Columns["Comentarios"].HeaderCell.Style.Font = new Font("Arial", 12, FontStyle.Bold);
            GridOportunidades.Columns["TituloVaga"].HeaderText = "Título";
            GridOportunidades.Columns["TituloVaga"].Width = 200;
            GridOportunidades.Columns["TituloVaga"].HeaderCell.Style.Font = new Font("Arial", 12, FontStyle.Bold);
            GridOportunidades.Columns["CNPJ"].HeaderText = "CNPJ";
            GridOportunidades.Columns["CNPJ"].Width = 120;
            GridOportunidades.Columns["CNPJ"].HeaderCell.Style.Font = new Font("Arial", 12, FontStyle.Bold);
            GridOportunidades.Columns["NomeFantasia"].HeaderText = "Empresa";
            GridOportunidades.Columns["NomeFantasia"].Width = 200;
            GridOportunidades.Columns["NomeFantasia"].HeaderCell.Style.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnDesassociar_Click(object sender, EventArgs e){
            Usuario usuario = Usuario.BuscarUsuarioEmailOuID(campoNome.Text);

            if(usuario == null) MessageBox.Show("Esse usuário não está na tabela");
            else{ 
                Candidatura.DessasociarCandidato(campoNome.Text); 
                MessageBox.Show("Usuário desassociado com sucesso");
            }
        }

        private void btnRetornar_Click(object sender, EventArgs e){
            this.Hide();
        }
    }
}
