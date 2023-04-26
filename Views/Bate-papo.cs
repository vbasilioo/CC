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
    public partial class Bate_papo : Form{

        private Usuario usuario;
        private string nomeUsuarioDestino;

        public Bate_papo(string nomeUsuarioDestino)
        {
            this.nomeUsuarioDestino = nomeUsuarioDestino;
            InitializeComponent();
        }

        public void ListarMensagens(string nomeUsuarioDestino)
        {
            listaMensagens.Items.Clear();

            var mensagens = Chat.ObterMensagens();

            foreach (var mensagem in mensagens)
            {
                if (mensagem is Chat chat && (chat.NomeRemetente == nomeUsuarioDestino || chat.NomeDestinatario == nomeUsuarioDestino))
                {
                    listaMensagens.Items.Add(chat);
                }
                else if (mensagem != null && mensagem.ToString() is string texto)
                {
                    listaMensagens.Items.Add(texto);
                }
            }
        }



        private void listaContatos_SelectedIndexChanged(object sender, EventArgs e){}

        private void Bate_papo_Load(object sender, EventArgs e){}

        private void listaMensagens_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAtualizarMensagens_Click(object sender, EventArgs e)
        {
            var mensagens = Chat.ObterMensagens();
            string hora = DateTime.Now.ToString("HH:mm");

            if(mensagens != null)
            {
                int ultimoID = listaMensagens.Items.Count > 0 ? ((Chat)listaMensagens.Items[listaMensagens.Items.Count - 1]).ID : 0;

                foreach(var mensagem in mensagens)
                {
                    if(mensagem.ID > ultimoID)
                    {
                        if(mensagem is Chat chat)
                        {
                            listaMensagens.Items.Add(chat);
                        }
                        else
                        {
                            listaMensagens.Items.Add(mensagem.ToString());
                        }
                    }
                }
            }

            listaMensagens.Visible = true;
        }

        private void btnEnviarMensagem_Click_1(object sender, EventArgs e)
        {
            string mensagem = campoMensagem.Text;
            string remetente = Usuario.usuarioLogado.Nome;

            if(!string.IsNullOrEmpty(mensagem)){
                Chat.EnviarNovaMensagem(remetente, mensagem);
                campoMensagem.Text = "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void listaContatos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

        private void btnIniciarConversa_Click(object sender, EventArgs e)
        {
            int destinatario = int.Parse(campoDestinatario.Text);
            Chat.IniciarConversa(Usuario.usuarioLogado.ID, destinatario, listaContatos, this);
        }
    }
}
