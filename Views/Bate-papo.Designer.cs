namespace CareerConnect.Views
{
    partial class Bate_papo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnEnviarMensagem = new System.Windows.Forms.Button();
            this.campoMensagem = new System.Windows.Forms.TextBox();
            this.listaMensagens = new System.Windows.Forms.ListBox();
            this.btnAtualizarMensagens = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listaContatos = new System.Windows.Forms.ListBox();
            this.btnIniciarConversa = new System.Windows.Forms.Button();
            this.campoDestinatario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEnviarMensagem
            // 
            this.btnEnviarMensagem.Location = new System.Drawing.Point(373, 13);
            this.btnEnviarMensagem.Name = "btnEnviarMensagem";
            this.btnEnviarMensagem.Size = new System.Drawing.Size(113, 23);
            this.btnEnviarMensagem.TabIndex = 0;
            this.btnEnviarMensagem.Text = "Enviar";
            this.btnEnviarMensagem.UseVisualStyleBackColor = true;
            this.btnEnviarMensagem.Click += new System.EventHandler(this.btnEnviarMensagem_Click_1);
            // 
            // campoMensagem
            // 
            this.campoMensagem.Location = new System.Drawing.Point(13, 13);
            this.campoMensagem.Name = "campoMensagem";
            this.campoMensagem.Size = new System.Drawing.Size(354, 20);
            this.campoMensagem.TabIndex = 1;
            // 
            // listaMensagens
            // 
            this.listaMensagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaMensagens.FormattingEnabled = true;
            this.listaMensagens.ItemHeight = 20;
            this.listaMensagens.Location = new System.Drawing.Point(13, 70);
            this.listaMensagens.Name = "listaMensagens";
            this.listaMensagens.Size = new System.Drawing.Size(473, 584);
            this.listaMensagens.TabIndex = 2;
            this.listaMensagens.SelectedIndexChanged += new System.EventHandler(this.listaMensagens_SelectedIndexChanged);
            // 
            // btnAtualizarMensagens
            // 
            this.btnAtualizarMensagens.Location = new System.Drawing.Point(661, 155);
            this.btnAtualizarMensagens.Name = "btnAtualizarMensagens";
            this.btnAtualizarMensagens.Size = new System.Drawing.Size(306, 23);
            this.btnAtualizarMensagens.TabIndex = 3;
            this.btnAtualizarMensagens.Text = "Atualizar";
            this.btnAtualizarMensagens.UseVisualStyleBackColor = true;
            this.btnAtualizarMensagens.Click += new System.EventHandler(this.btnAtualizarMensagens_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listaContatos
            // 
            this.listaContatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaContatos.FormattingEnabled = true;
            this.listaContatos.ItemHeight = 20;
            this.listaContatos.Location = new System.Drawing.Point(1128, 115);
            this.listaContatos.Name = "listaContatos";
            this.listaContatos.Size = new System.Drawing.Size(263, 244);
            this.listaContatos.TabIndex = 4;
            this.listaContatos.SelectedIndexChanged += new System.EventHandler(this.listaContatos_SelectedIndexChanged_1);
            // 
            // btnIniciarConversa
            // 
            this.btnIniciarConversa.Location = new System.Drawing.Point(1128, 37);
            this.btnIniciarConversa.Name = "btnIniciarConversa";
            this.btnIniciarConversa.Size = new System.Drawing.Size(263, 23);
            this.btnIniciarConversa.TabIndex = 5;
            this.btnIniciarConversa.Text = "Iniciar conversa";
            this.btnIniciarConversa.UseVisualStyleBackColor = true;
            this.btnIniciarConversa.Click += new System.EventHandler(this.btnIniciarConversa_Click);
            // 
            // campoDestinatario
            // 
            this.campoDestinatario.Location = new System.Drawing.Point(1128, 70);
            this.campoDestinatario.Name = "campoDestinatario";
            this.campoDestinatario.Size = new System.Drawing.Size(263, 20);
            this.campoDestinatario.TabIndex = 6;
            // 
            // Bate_papo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1499, 674);
            this.Controls.Add(this.campoDestinatario);
            this.Controls.Add(this.btnIniciarConversa);
            this.Controls.Add(this.listaContatos);
            this.Controls.Add(this.btnAtualizarMensagens);
            this.Controls.Add(this.listaMensagens);
            this.Controls.Add(this.campoMensagem);
            this.Controls.Add(this.btnEnviarMensagem);
            this.Name = "Bate_papo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bate-papo";
            this.Load += new System.EventHandler(this.Bate_papo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviarMensagem;
        private System.Windows.Forms.TextBox campoMensagem;
        private System.Windows.Forms.ListBox listaMensagens;
        private System.Windows.Forms.Button btnAtualizarMensagens;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listaContatos;
        private System.Windows.Forms.Button btnIniciarConversa;
        private System.Windows.Forms.TextBox campoDestinatario;
    }
}