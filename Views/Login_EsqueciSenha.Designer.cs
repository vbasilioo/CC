namespace CareerConnect.Views
{
    partial class Login_EsqueciSenha
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
            this.BotaoRecuperar = new System.Windows.Forms.Button();
            this.campoNumeroEsqueciSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BotaoRetornar = new System.Windows.Forms.Button();
            this.campoEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BotaoRecuperar
            // 
            this.BotaoRecuperar.Location = new System.Drawing.Point(1124, 418);
            this.BotaoRecuperar.Name = "BotaoRecuperar";
            this.BotaoRecuperar.Size = new System.Drawing.Size(100, 23);
            this.BotaoRecuperar.TabIndex = 0;
            this.BotaoRecuperar.Text = "Recuperar";
            this.BotaoRecuperar.UseVisualStyleBackColor = true;
            this.BotaoRecuperar.Click += new System.EventHandler(this.botaoRecuperar_Click);
            // 
            // campoNumeroEsqueciSenha
            // 
            this.campoNumeroEsqueciSenha.Location = new System.Drawing.Point(1124, 292);
            this.campoNumeroEsqueciSenha.Name = "campoNumeroEsqueciSenha";
            this.campoNumeroEsqueciSenha.Size = new System.Drawing.Size(100, 20);
            this.campoNumeroEsqueciSenha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1014, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número";
            // 
            // BotaoRetornar
            // 
            this.BotaoRetornar.Location = new System.Drawing.Point(1124, 474);
            this.BotaoRetornar.Name = "BotaoRetornar";
            this.BotaoRetornar.Size = new System.Drawing.Size(100, 23);
            this.BotaoRetornar.TabIndex = 3;
            this.BotaoRetornar.Text = "Retornar";
            this.BotaoRetornar.UseVisualStyleBackColor = true;
            this.BotaoRetornar.Click += new System.EventHandler(this.botaoRetornar_Click);
            // 
            // campoEmail
            // 
            this.campoEmail.Location = new System.Drawing.Point(1124, 341);
            this.campoEmail.Name = "campoEmail";
            this.campoEmail.Size = new System.Drawing.Size(100, 20);
            this.campoEmail.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1017, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "E-mail";
            // 
            // Login_EsqueciSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 663);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.campoEmail);
            this.Controls.Add(this.BotaoRetornar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.campoNumeroEsqueciSenha);
            this.Controls.Add(this.BotaoRecuperar);
            this.Name = "Login_EsqueciSenha";
            this.Text = "Login_EsqueciSenha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotaoRecuperar;
        private System.Windows.Forms.TextBox campoNumeroEsqueciSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotaoRetornar;
        private System.Windows.Forms.TextBox campoEmail;
        private System.Windows.Forms.Label label2;
    }
}