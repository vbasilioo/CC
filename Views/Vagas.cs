using CareerConnect.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace CareerConnect.Views{
    public partial class Vagas : Form{

        List<Oportunidade> oportunidadesFiltradas = Oportunidade.ListarOportunidades();

        public Vagas(){
            InitializeComponent();
            AtualizarGridView(); // atualiza a GridView no construtor
            VerificacaoCargo(); //verifica o cargo do usuario logado para mostrar ou nao X botoes
        }

        private void btnCadastrarVaga_Click(object sender, EventArgs e){
            Cadastrar_Oportunidade cop = new Cadastrar_Oportunidade();
            Cadastrar_Oportunidade.FormVagas = this; // ref ao form vagas
            cop.Show();
        }

        private void GridOportunidades_CellContentClick(object sender, DataGridViewCellEventArgs e){
            AtualizarGridView(); // atualiza a GridView
        }

        public void VerificacaoCargo(){
            if(Usuario.VerificarCargoUsuario() == "Candidato"){
                btnListarCandidatos.Visible = false;
                btnEditarVaga.Visible = false;
                btnDesassociarCandidato.Visible = false;
                btnDeletarVaga.Visible = false;
                btnCadastrarVaga.Visible = false;
                btnBuscarCandidato.Visible = false;
                btnAssociarCandidato.Visible = false;
                btnListarEmpresas.Visible = false;
                btnVerAssociados.Visible = false;
            }else if(Usuario.VerificarCargoUsuario() == "Coordenador"){
                btnDeletarVaga.Visible = false;
                btnCadastrarVaga.Visible = false;
                btnEditarVaga.Visible = false;
                btnCandidatar.Visible = false;
                btnAttCandidatura.Visible = false;
                btnListarCandidaturas.Visible = false;
                btnExcluirCandidatura.Visible = false;
                btnVerAssociados.Visible = false;
                label1.Visible = false;
                campoPesquisarEmpresa.Visible = false;
            }else if(Usuario.VerificarCargoUsuario() == "Empresa"){
                btnBuscarCandidato.Visible = false;
                btnAssociarCandidato.Visible = false;
                btnDesassociarCandidato.Visible = false;
                btnListarCandidatos.Visible = false;
                btnListarEmpresas.Visible = false;
                btnCandidatar.Visible = false;
                btnAttCandidatura.Visible = false;
                btnListarCandidaturas.Visible = false;
                btnExcluirCandidatura.Visible = false;
                label1.Visible = false;
                campoPesquisarEmpresa.Visible = false;
            }
        }

        public void AtualizarGridView(){
            GridOportunidades.DataSource = oportunidadesFiltradas;
            GridOportunidades.ReadOnly = true;
            GridOportunidades.DefaultCellStyle.Padding = new Padding(0, 10, 0, 10);
            GridOportunidades.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GridOportunidades.RowTemplate.Height = 45;
            GridOportunidades.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            GridOportunidades.Columns[0].HeaderText = "ID";
            GridOportunidades.Columns[0].Width = 40;
            GridOportunidades.Columns[0].HeaderCell.Style.Font = new Font("Arial", 12, FontStyle.Bold);
            GridOportunidades.Columns[1].HeaderText = "Título da Vaga";
            GridOportunidades.Columns[1].Width = 250;
            GridOportunidades.Columns[1].HeaderCell.Style.Font = new Font("Arial", 12, FontStyle.Bold);
            GridOportunidades.Columns[2].HeaderText = "Descrição da Vaga";
            GridOportunidades.Columns[2].Width = 450;
            GridOportunidades.Columns[2].HeaderCell.Style.Font = new Font("Arial", 12, FontStyle.Bold);
            GridOportunidades.Columns[3].HeaderText = "Salário";
            GridOportunidades.Columns[3].Width = 80;
            GridOportunidades.Columns[3].HeaderCell.Style.Font = new Font("Arial", 12, FontStyle.Bold);
            GridOportunidades.Columns[4].HeaderText = "Classificação";
            GridOportunidades.Columns[4].Width = 130;
            GridOportunidades.Columns[4].HeaderCell.Style.Font = new Font("Arial", 12, FontStyle.Bold);
            GridOportunidades.Columns[5].HeaderText = "Empresa";
            GridOportunidades.Columns[5].Width = 120;
            GridOportunidades.Columns[5].HeaderCell.Style.Font = new Font("Arial", 12, FontStyle.Bold);
            GridOportunidades.Columns[6].HeaderText = "CNPJ";
            GridOportunidades.Columns[6].Width = 150;
            GridOportunidades.Columns[6].HeaderCell.Style.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnAttVaga_Click(object sender, EventArgs e){
            Vagas vagas = new Vagas();
            vagas.Show();
            this.Hide();
        }

        private void btnEditarVaga_Click(object sender, EventArgs e){
            string idOuNome = Microsoft.VisualBasic.Interaction.InputBox("Insira o ID ou o nome da vaga que você quer editar:", "Editar vaga", "");
            Oportunidade.EditarVagaNaTela(idOuNome);
        }

        private void btnEditarVaga_MouseClick(object sender, MouseEventArgs e){}

        private void GridOportunidades_RowValidated(object sender, DataGridViewCellEventArgs e){}

        private void btnDeletarVaga_Click(object sender, EventArgs e){
            string idOuNome = Microsoft.VisualBasic.Interaction.InputBox("Insira o ID ou o nome da vaga que você quer excluir:", "Excluir vaga", "");
            Oportunidade.DeletarVagaNaTela(idOuNome);
        }

        private void button2_Click(object sender, EventArgs e){
            string idOuEmail = Microsoft.VisualBasic.Interaction.InputBox("Insira o ID ou o nome do candidato que você quer encontrar:");
            Usuario.BuscarUsuarioNaGrid(idOuEmail);
        }

        private void campoPesquisarEmpresa_TextChanged(object sender, EventArgs e){
            if(campoPesquisarEmpresa.Text == ""){
                oportunidadesFiltradas = Oportunidade.ListarOportunidades();
            }else{
                oportunidadesFiltradas = Oportunidade.ProcurarEmpresaPorNome(campoPesquisarEmpresa.Text, oportunidadesFiltradas);
            }
            AtualizarGridView();
        }

        private void btnListarCandidatos_Click(object sender, EventArgs e){
            List<Usuario> candidatos = Usuario.BuscarCandidatos();
            GridOportunidades.DataSource = candidatos;
            GridOportunidades.ReadOnly = true;
            GridOportunidades.DefaultCellStyle.Padding = new Padding(0, 10, 0, 10);
            GridOportunidades.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GridOportunidades.RowTemplate.Height = 25;
            GridOportunidades.Columns["Senha"].Visible = false;
            GridOportunidades.Columns["Cargo"].Visible = false;
            GridOportunidades.Columns["ID"].HeaderText = "ID";
            GridOportunidades.Columns["ID"].Width = 40;
            GridOportunidades.Columns["ID"].HeaderCell.Style.Font = new Font("Arial", 12, FontStyle.Bold);
            GridOportunidades.Columns["Nome"].HeaderText = "Nome";
            GridOportunidades.Columns["Nome"].Width = 250;
            GridOportunidades.Columns["Nome"].HeaderCell.Style.Font = new Font("Arial", 12, FontStyle.Bold);
            GridOportunidades.Columns["Email"].HeaderText = "E-mail";
            GridOportunidades.Columns["Email"].Width = 300;
            GridOportunidades.Columns["Email"].HeaderCell.Style.Font = new Font("Arial", 12, FontStyle.Bold);
            GridOportunidades.Columns["DataNascimento"].HeaderText = "Idade";
            GridOportunidades.Columns["DataNascimento"].Width = 80;
            GridOportunidades.Columns["DataNascimento"].HeaderCell.Style.Font = new Font("Arial", 12, FontStyle.Bold);
            GridOportunidades.Columns["Endereco"].HeaderText = "Endereço";
            GridOportunidades.Columns["Endereco"].Width = 300;
            GridOportunidades.Columns["Endereco"].HeaderCell.Style.Font = new Font("Arial", 12, FontStyle.Bold);
        }
    }
}
