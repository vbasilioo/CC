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
    public partial class Cadastrar_Oportunidade : Form{

        private static List<Oportunidade> listaDeOportunidades = new List<Oportunidade>();
        public static Vagas FormVagas { get; set; }
        private Usuario usuario;

        public Cadastrar_Oportunidade(){
            InitializeComponent();
        }

        private void btnRetornar_Click(object sender, EventArgs e){
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void BotaoCadastrarVaga_Click(object sender, EventArgs e){
            string salarioString = campoSalario.Text;
            double salario;

            if(Usuario.usuarioLogado.Cargo == "Empresa"){
                if(Usuario.usuarioLogado.CNPJEmpresa == campoCNPJ.Text){
                    if(double.TryParse(salarioString, out salario)) {
                        Oportunidade.CadastrarOportunidadeNova(campoTitulo.Text, campoDesc.Text, salario, campoNomeFantasia.Text, campoCNPJ.Text);
                        this.Close();
                    }else{
                        MessageBox.Show("Salário inválido, por favor insira um valor numérico.");
                    }
                }else{
                    MessageBox.Show("CNPJ inválido");
                    return;
                } 
            }
        }
    }
}
