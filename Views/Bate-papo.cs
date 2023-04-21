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

        private int idDestinatarioSelecionado;

        public Bate_papo(){
            InitializeComponent();
            PreencherListaContatos();
        }

        private void PreencherListaContatos()
        {
            listaContatos.Items.Clear();

            foreach(var conversa in Chat.conversas)
            {
                if(conversa.Value.Any(u => u.IDRemetente == Usuario.usuarioLogado.ID || u.IDDestinatario == Usuario.usuarioLogado.ID))
                {
                    int idConversa = conversa.Key;
                    var ultimaMensagem = conversa.Value.LastOrDefault();

                    if (ultimaMensagem != null)
                    {
                        int idOutroUsuario = ultimaMensagem.IDRemetente == Usuario.usuarioLogado.ID ? ultimaMensagem.IDDestinatario : ultimaMensagem.IDRemetente;
                        string nomeOutroUsuario = Usuario.ObterUsuarioPorID(idOutroUsuario)?.Nome ?? "Desconhecido";
                        listaContatos.Items.Add($"ID: {idConversa}");
                        listaContatos.Items.Add(nomeOutroUsuario);
                    }
                }
            }
        }

        private void AtualizarMensagens(int idDestinatario, int idRemetente){
            List<Mensagem> mensagens = Chat.ObterMensagens(Usuario.usuarioLogado.ID, idDestinatario);
            listaMensagens.Items.Clear();
            Usuario remetente = Usuario.ObterUsuarioPorID(idRemetente);
            string nomeRemetente = remetente?.Nome ?? "Desconhecido";

            foreach(Mensagem mensagem in mensagens){
                string textoMensagem = $"[{mensagem.DataHora}] {nomeRemetente}: {mensagem.Conteudo}";
                listaMensagens.Items.Add(textoMensagem);
            }
        }

        private void btnIniciarConversa_Click(object sender, EventArgs e){
            string remetente = Microsoft.VisualBasic.Interaction.InputBox("Insira o ID do remetente: ");
            int idRemetente = int.Parse(remetente);
            string idDestinatarioStr = Microsoft.VisualBasic.Interaction.InputBox("Insira o ID do usuário destinatário:");
            
            if(Int32.TryParse(idDestinatarioStr, out int idDestinatario)){
                idDestinatarioSelecionado = idDestinatario;
                int idConversa = Chat.GerarIDConversa(idRemetente, idDestinatario);
                string nomeDestinatario = Usuario.ObterUsuarioPorID(idDestinatario)?.Nome ?? "Desconhecido";
                Chat.IniciarConversa(idRemetente, idDestinatario);
                listaContatos.Items.Insert(0, $"ID: {idConversa}");
                listaContatos.Items.Insert(1, $"{nomeDestinatario}");
            }
        }

        private void btnEnviarMensagem_Click(object sender, EventArgs e){
            int idRemetente = Usuario.usuarioLogado.ID;
            string mensagem = campoMensagem.Text;

            Chat.EnviarMensagem(idRemetente, idDestinatarioSelecionado, mensagem, this);
            campoMensagem.Text = "";
            AtualizarMensagens(idDestinatarioSelecionado, idRemetente);
            
        }

        private void listaContatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemSelecionado = listaContatos.SelectedItem.ToString();
            int posicaoSeparador = itemSelecionado.IndexOf(":");
            string idDestinatarioStr = itemSelecionado.Substring(posicaoSeparador + 1).Trim();
            
            if(int.TryParse(idDestinatarioStr, out int idDestinatario)){
                listaMensagens.Items.Clear();
                idDestinatarioSelecionado = idDestinatario;
                AtualizarMensagens(idDestinatarioSelecionado, Usuario.usuarioLogado.ID);
            }else MessageBox.Show("Teste de erro");
        }
    }
}
