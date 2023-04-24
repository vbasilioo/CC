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

        private int idUsuario;

        public Bate_papo(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;

            List<int> conversasIniciadas = Chat.ObterConversasIniciadas(idUsuario);

            foreach(int idConversa in conversasIniciadas)
            {
                int idDestinatario = ObterIDDestinatario(idConversa);
                string nomeDestinatario = ObterNomeUsuario(idDestinatario);
                listaContatos.Items.Add(nomeDestinatario);
            }

            listaContatos.SelectedIndexChanged += listaContatos_SelectedIndexChanged;

            Chat.NovaMensagemRecebida += AtualizarMensagens;
            Chat.NovaMensagemEnviada += AtualizarMensagens;
        }

        private int ObterIDDestinatario(int indice)
        {
            List<int> conversasIniciadas = Chat.ObterConversasIniciadas(idUsuario);
            int idConversa = conversasIniciadas[indice];
            int idDestinatario;

            if (idConversa.ToString().StartsWith(idUsuario.ToString()))
            {
                idDestinatario = int.Parse(idConversa.ToString().Substring(idUsuario.ToString().Length));
            }
            else
            {
                idDestinatario = int.Parse(idConversa.ToString().Substring(0, idUsuario.ToString().Length));
            }

            return idDestinatario;
        }

        private string ObterNomeUsuario(int idUsuario)
        {
            Usuario usuario = Usuario.ObterUsuarioPorID(idUsuario);

            if(usuario != null)
            {
                return usuario.Nome;
            }

            return "";
        }

        private void btnIniciarConversa_Click(object sender, EventArgs e){
            string remetente = Microsoft.VisualBasic.Interaction.InputBox("Insira o ID do remetente: ");
            int idRemetente = int.Parse(remetente);
            string idDestinatarioStr = Microsoft.VisualBasic.Interaction.InputBox("Insira o ID do usuário destinatário:");
            int idDestinatario = int.Parse(idDestinatarioStr);

            Chat.IniciarConversa(idRemetente, idDestinatario);
        }

        private void btnEnviarMensagem_Click(object sender, EventArgs e){
            string remetente = Microsoft.VisualBasic.Interaction.InputBox("Insira o ID do remetente: ");
            int idRemetente = int.Parse(remetente);
            
            string texto = campoMensagem.Text;
            
            Chat.EnviarMensagem(idRemetente, texto);
        }

        private void listaContatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            listaMensagens.Items.Clear();
            int idDestinatario = ObterIDDestinatario(listaContatos.SelectedIndex);

            Queue<Mensagem> mensagens = Chat.ObterMensagensDaConversa(Chat.GerarIdConversa(idUsuario, idDestinatario));;

            if(mensagens != null)
            {
                foreach(Mensagem mensagem in mensagens)
                {
                    string nomeRemetente = ObterNomeUsuario(mensagem.IDRemetente);  
                    listaMensagens.Items.Add(nomeRemetente + ": " + mensagem.Texto);
                }
            }
        }

        private void Bate_papo_Load(object sender, EventArgs e)
        {
            
        }

        private void AtualizarMensagens(int idConversa, Mensagem mensagem)
        {
            int idDestinatario = ObterIDDestinatario(listaContatos.SelectedIndex);
            if (idDestinatario == mensagem.IDDesteinatario || idDestinatario == mensagem.IDRemetente){
                Queue<Mensagem> mensagens = Chat.ObterMensagensDaConversa(idConversa);

                if(mensagens != null)
                {
                    mensagens.Enqueue(mensagem);
                }
                else
                {
                    mensagens = new Queue<Mensagem>();
                    mensagens.Enqueue(mensagem);
                }

                listaMensagens.DataSource = mensagens.ToList();
            }
        }

    }
}
