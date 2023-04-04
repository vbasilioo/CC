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
            }else if(Usuario.VerificarCargoUsuario() == "Coordenador"){
                btnDeletarVaga.Visible = false;
                btnCadastrarVaga.Visible = false;
                btnEditarVaga.Visible = false;
                btnCandidatar.Visible = false;
                btnAttCandidatura.Visible = false;
                btnListarCandidaturas.Visible = false;
                btnExcluirCandidatura.Visible = false;
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
            GridOportunidades.Columns[0].HeaderText = "ID";
            GridOportunidades.Columns[0].Width = 40;
            GridOportunidades.Columns[0].HeaderCell.Style.Font = new Font("Arial", 10, FontStyle.Bold);
            GridOportunidades.Columns[1].HeaderText = "Título da Vaga";
            GridOportunidades.Columns[1].Width = 250;
            GridOportunidades.Columns[1].HeaderCell.Style.Font = new Font("Arial", 10, FontStyle.Bold);
            GridOportunidades.Columns[2].HeaderText = "Descrição da Vaga";
            GridOportunidades.Columns[2].Width = 450;
            GridOportunidades.Columns[2].HeaderCell.Style.Font = new Font("Arial", 10, FontStyle.Bold);
            GridOportunidades.Columns[3].HeaderText = "Salário";
            GridOportunidades.Columns[3].Width = 80;
            GridOportunidades.Columns[3].HeaderCell.Style.Font = new Font("Arial", 10, FontStyle.Bold);
            GridOportunidades.Columns[4].HeaderText = "Classificação";
            GridOportunidades.Columns[4].Width = 110;
            GridOportunidades.Columns[4].HeaderCell.Style.Font = new Font("Arial", 10, FontStyle.Bold);
            GridOportunidades.Columns[5].HeaderText = "Empresa";
            GridOportunidades.Columns[5].Width = 120;
            GridOportunidades.Columns[5].HeaderCell.Style.Font = new Font("Arial", 10, FontStyle.Bold);
            GridOportunidades.Columns[6].HeaderText = "CNPJ";
            GridOportunidades.Columns[6].Width = 150;
            GridOportunidades.Columns[6].HeaderCell.Style.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void btnAttVaga_Click(object sender, EventArgs e){
            Vagas vagas = new Vagas();
            vagas.Show();
            this.Hide();
        }

        private void btnEditarVaga_Click(object sender, EventArgs e){
            string idOuNome = Microsoft.VisualBasic.Interaction.InputBox("Insira o ID ou o nome da vaga que você quer editar:", "Editar vaga", "");
            int id;

            if(int.TryParse(idOuNome, out id)){ //verificando se o informado é INT ou STRING
                Oportunidade oportunidade = Oportunidade.BuscarOportunidadePorId(id); //buscando a oportunidade caso for ID
                if(oportunidade != null){ //se encontrar algo, abre a tela aq
                    Editar_Oportunidade edo = new Editar_Oportunidade(idOuNome);
                    edo.Show();
                }else{
                    MessageBox.Show("A vaga não foi encontrada.");
                }
            }else{
                Oportunidade oportunidade = Oportunidade.BuscarOportunidadePorTitulo(idOuNome);
                if(oportunidade != null){ 
                    Editar_Oportunidade edo = new Editar_Oportunidade(idOuNome);
                    edo.Show();
                }else{
                    MessageBox.Show("A vaga não foi encontrada.");
                }
            }
        }

        private void btnEditarVaga_MouseClick(object sender, MouseEventArgs e){}

        private void GridOportunidades_RowValidated(object sender, DataGridViewCellEventArgs e){}

        private void btnDeletarVaga_Click(object sender, EventArgs e){
            string idOuNome = Microsoft.VisualBasic.Interaction.InputBox("Insira o ID ou o nome da vaga que você quer excluir:", "Excluir vaga", "");
            int id;

            if(int.TryParse(idOuNome, out id)){ //verificando se o informado é INT ou STRING
                Oportunidade oportunidade = Oportunidade.BuscarOportunidadePorId(id); //buscando a oportunidade caso for ID
                if(oportunidade != null){ //se encontrar algo, abre a tela aq
                    string opcao = Microsoft.VisualBasic.Interaction.InputBox("Certeza que deseja excluir essa vaga? (sim ou nao)");
                    if(opcao.ToLower() == "sim") Oportunidade.RemoverOportunidade(oportunidade);
                    else MessageBox.Show("A ação foi cancelada.");
                }else{
                    MessageBox.Show("A vaga não foi encontrada.");
                }
            }else{
                Oportunidade oportunidade = Oportunidade.BuscarOportunidadePorTitulo(idOuNome);
                if(oportunidade != null){ 
                    string opcao = Microsoft.VisualBasic.Interaction.InputBox("Certeza que deseja excluir essa vaga? (sim ou nao)");
                    if(opcao.ToLower() == "sim") Oportunidade.RemoverOportunidade(oportunidade);
                    else MessageBox.Show("A ação foi cancelada.");
                }else{
                    MessageBox.Show("A vaga não foi encontrada.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e){
            string idOuEmail = Microsoft.VisualBasic.Interaction.InputBox("Insira o ID ou o nome do candidato que você quer encontrar:");
            int id;

            if(int.TryParse(idOuEmail, out id)){ //verificando se o informado é INT ou STRING
                Usuario usuario = Usuario.BuscarUsuarioEmailOuID(idOuEmail); //buscando a oportunidade caso for ID
                if(usuario != null){ //se encontrar algo, abre a tela aq
                    MessageBox.Show("Usuário encontrado, agr tem que relacionar com o cargo de candidatos :p");
                }else{
                    MessageBox.Show("O usuário não foi encontrada.");
                }
            }else{
                Usuario usuario = Usuario.BuscarUsuarioEmailOuID(idOuEmail);
                if(usuario != null){ 
                    MessageBox.Show("Usuário encontrado, agr tem que relacionar com o cargo de candidatos :p");
                }else{
                    MessageBox.Show("O usuário não foi encontrada.");
                }
            }
        }

        private void campoPesquisarEmpresa_TextChanged(object sender, EventArgs e){
            if(campoPesquisarEmpresa.Text == ""){
                oportunidadesFiltradas = Oportunidade.ListarOportunidades();
            }else{
                /*// filtra oportunidades de acordo com nome da empresa
                if (!string.IsNullOrEmpty(campoPesquisarEmpresa.Text)){
                    oportunidadesFiltradas = oportunidadesFiltradas
                        .Where(oportunidade => oportunidade.NomeFantasia.ToLower().StartsWith(campoPesquisarEmpresa.Text.ToLower())).ToList();
                }

                // atualiza a grid com as oportunidade q o usuario pesquisou
                GridOportunidades.DataSource = oportunidadesFiltradas;*/
                oportunidadesFiltradas = Oportunidade.ProcurarEmpresaPorNome(campoPesquisarEmpresa.Text, oportunidadesFiltradas);
            }
            AtualizarGridView();
        }

        private void btnListarCandidatos_Click(object sender, EventArgs e){
            List<Usuario> candidatos = Usuario.BuscarCandidatos();
            GridOportunidades.DataSource = candidatos;
            
            GridOportunidades.Columns["Senha"].Visible = false;
            GridOportunidades.Columns["Cargo"].Visible = false;
            GridOportunidades.Columns["ID"].HeaderText = "ID";
            GridOportunidades.Columns["ID"].Width = 40;
            GridOportunidades.Columns["ID"].HeaderCell.Style.Font = new Font("Arial", 10, FontStyle.Bold);
            GridOportunidades.Columns["Nome"].HeaderText = "Nome";
            GridOportunidades.Columns["Nome"].Width = 250;
            GridOportunidades.Columns["Nome"].HeaderCell.Style.Font = new Font("Arial", 10, FontStyle.Bold);
            GridOportunidades.Columns["Email"].HeaderText = "E-mail";
            GridOportunidades.Columns["Email"].Width = 300;
            GridOportunidades.Columns["Email"].HeaderCell.Style.Font = new Font("Arial", 10, FontStyle.Bold);
            GridOportunidades.Columns["DataNascimento"].HeaderText = "Idade";
            GridOportunidades.Columns["DataNascimento"].Width = 80;
            GridOportunidades.Columns["DataNascimento"].HeaderCell.Style.Font = new Font("Arial", 10, FontStyle.Bold);
            GridOportunidades.Columns["Endereco"].HeaderText = "Endereço";
            GridOportunidades.Columns["Endereco"].Width = 300;
            GridOportunidades.Columns["Endereco"].HeaderCell.Style.Font = new Font("Arial", 10, FontStyle.Bold);
        }
    }
}
