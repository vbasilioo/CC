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
            this.btnIniciarConversa = new System.Windows.Forms.Button();
            this.listaContatos = new System.Windows.Forms.ListBox();
            this.btnEnviarMensagem = new System.Windows.Forms.Button();
            this.campoMensagem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listaMensagens = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnIniciarConversa
            // 
            this.btnIniciarConversa.Location = new System.Drawing.Point(13, 26);
            this.btnIniciarConversa.Name = "btnIniciarConversa";
            this.btnIniciarConversa.Size = new System.Drawing.Size(471, 23);
            this.btnIniciarConversa.TabIndex = 0;
            this.btnIniciarConversa.Text = "Iniciar conversa";
            this.btnIniciarConversa.UseVisualStyleBackColor = true;
            this.btnIniciarConversa.Click += new System.EventHandler(this.btnIniciarConversa_Click);
            // 
            // listaContatos
            // 
            this.listaContatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaContatos.FormattingEnabled = true;
            this.listaContatos.ItemHeight = 20;
            this.listaContatos.Location = new System.Drawing.Point(13, 57);
            this.listaContatos.Name = "listaContatos";
            this.listaContatos.Size = new System.Drawing.Size(471, 584);
            this.listaContatos.TabIndex = 1;
            // 
            // btnEnviarMensagem
            // 
            this.btnEnviarMensagem.Location = new System.Drawing.Point(1424, 623);
            this.btnEnviarMensagem.Name = "btnEnviarMensagem";
            this.btnEnviarMensagem.Size = new System.Drawing.Size(63, 23);
            this.btnEnviarMensagem.TabIndex = 2;
            this.btnEnviarMensagem.Text = "Enviar";
            this.btnEnviarMensagem.UseVisualStyleBackColor = true;
            this.btnEnviarMensagem.Click += new System.EventHandler(this.btnEnviarMensagem_Click);
            // 
            // campoMensagem
            // 
            this.campoMensagem.Location = new System.Drawing.Point(611, 626);
            this.campoMensagem.Name = "campoMensagem";
            this.campoMensagem.Size = new System.Drawing.Size(807, 20);
            this.campoMensagem.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(611, 607);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mensagem";
            // 
            // listaMensagens
            // 
            this.listaMensagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaMensagens.FormattingEnabled = true;
            this.listaMensagens.ItemHeight = 20;
            this.listaMensagens.Location = new System.Drawing.Point(611, 57);
            this.listaMensagens.Name = "listaMensagens";
            this.listaMensagens.Size = new System.Drawing.Size(876, 524);
            this.listaMensagens.TabIndex = 5;
            // 
            // Bate_papo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1499, 674);
            this.Controls.Add(this.listaMensagens);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.campoMensagem);
            this.Controls.Add(this.btnEnviarMensagem);
            this.Controls.Add(this.listaContatos);
            this.Controls.Add(this.btnIniciarConversa);
            this.Name = "Bate_papo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bate-papo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarConversa;
        private System.Windows.Forms.ListBox listaContatos;
        private System.Windows.Forms.Button btnEnviarMensagem;
        private System.Windows.Forms.TextBox campoMensagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listaMensagens;
    }
}