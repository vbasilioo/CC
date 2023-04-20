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
    public partial class Bate_papo : Form{

        public Bate_papo(){
            InitializeComponent();
        }

        private void AtualizarMensagens(int idDestinatario, int idRemetente){
            List<Mensagem> mensagens = Chat.ObterMensagens(Usuario.usuarioLogado.ID, idDestinatario);
            listaMensagens.Items.Clear();
            string nomeRemetente = Usuario.ObterUsuarioPorID(idRemetente)?.Nome ?? "Desconhecido";

            foreach(Mensagem mensagem in mensagens){
                string textoMensagem = $"[{mensagem.DataHora}] {nomeRemetente}: {mensagem.Conteudo}";
                listaMensagens.Items.Add(textoMensagem);
            }
        }

        public void NovaMensagemRecebida(int idRemetente, int idDestinatario)
        {
            NovaMensagemRecebida(idRemetente, idDestinatario);
            AtualizarMensagens(idDestinatario, idRemetente);
        }

        private void btnIniciarConversa_Click(object sender, EventArgs e){
            int idRemetente = Usuario.usuarioLogado.ID;
            string idDestinatarioStr = Microsoft.VisualBasic.Interaction.InputBox("Insira o ID do usuário destinatário:");
            
            if(Int32.TryParse(idDestinatarioStr, out int idDestinatario)){
                int idConversa = Chat.GerarIDConversa(idRemetente, idDestinatario);
                string nomeDestinatario = Usuario.ObterUsuarioPorID(idDestinatario)?.Nome ?? "Desconhecido";
                Chat.IniciarConversa(idRemetente, idDestinatario);
                listaContatos.Items.Insert(0, $"ID MENSAGEM: {idConversa}\n Você está falando com: {nomeDestinatario}");
            }
        }

        private void btnEnviarMensagem_Click(object sender, EventArgs e){
            int idRemetente = Usuario.usuarioLogado.ID;
            string idDestinatarioStr = Microsoft.VisualBasic.Interaction.InputBox("Insira o ID do usuário destinatário:");
            string mensagem = campoMensagem.Text;

            if(Int32.TryParse(idDestinatarioStr, out int idDestinatario)){
                Chat.EnviarMensagem(idRemetente, idDestinatario, mensagem, this);
                campoMensagem.Text = "";
                AtualizarMensagens(idDestinatario, idRemetente);
            }
        }
    }
}
