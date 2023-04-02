namespace CareerConnect
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.campoEmail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.campoSenha = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnEsqueciMinhaSenha = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnEntrar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCadastrar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSair = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(105, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(105, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Senha";
            // 
            // campoEmail
            // 
            this.campoEmail.Location = new System.Drawing.Point(109, 209);
            this.campoEmail.Name = "campoEmail";
            this.campoEmail.Size = new System.Drawing.Size(379, 33);
            this.campoEmail.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.campoEmail.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.campoEmail.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.campoEmail.StateCommon.Border.Rounding = 20;
            this.campoEmail.StateCommon.Border.Width = 1;
            this.campoEmail.StateCommon.Content.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoEmail.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.campoEmail.TabIndex = 20;
            // 
            // campoSenha
            // 
            this.campoSenha.Location = new System.Drawing.Point(109, 288);
            this.campoSenha.Name = "campoSenha";
            this.campoSenha.PasswordChar = '*';
            this.campoSenha.Size = new System.Drawing.Size(379, 33);
            this.campoSenha.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.campoSenha.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.campoSenha.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.campoSenha.StateCommon.Border.Rounding = 20;
            this.campoSenha.StateCommon.Border.Width = 1;
            this.campoSenha.StateCommon.Content.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoSenha.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.campoSenha.TabIndex = 21;
            // 
            // btnEsqueciMinhaSenha
            // 
            this.btnEsqueciMinhaSenha.Location = new System.Drawing.Point(109, 327);
            this.btnEsqueciMinhaSenha.Name = "btnEsqueciMinhaSenha";
            this.btnEsqueciMinhaSenha.Size = new System.Drawing.Size(250, 21);
            this.btnEsqueciMinhaSenha.StateCommon.ShortText.Color1 = System.Drawing.Color.DarkGreen;
            this.btnEsqueciMinhaSenha.StateCommon.ShortText.Color2 = System.Drawing.Color.DarkGreen;
            this.btnEsqueciMinhaSenha.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsqueciMinhaSenha.TabIndex = 22;
            this.btnEsqueciMinhaSenha.Values.Text = "Esqueceu sua senha? Clique aqui!";
            this.btnEsqueciMinhaSenha.Click += new System.EventHandler(this.btnEsqueciMinhaSenha_Click);
            this.btnEsqueciMinhaSenha.Paint += new System.Windows.Forms.PaintEventHandler(this.btnEsqueciMinhaSenha_Paint);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(109, 373);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnEntrar.Size = new System.Drawing.Size(218, 43);
            this.btnEntrar.StateCommon.Border.Color1 = System.Drawing.Color.Gold;
            this.btnEntrar.StateCommon.Border.Color2 = System.Drawing.Color.Gold;
            this.btnEntrar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEntrar.StateCommon.Border.Rounding = 20;
            this.btnEntrar.StateCommon.Border.Width = 1;
            this.btnEntrar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.StatePressed.Back.Color1 = System.Drawing.Color.Gold;
            this.btnEntrar.StatePressed.Back.Color2 = System.Drawing.Color.Gold;
            this.btnEntrar.StatePressed.Back.ColorAngle = 135F;
            this.btnEntrar.StatePressed.Border.Color1 = System.Drawing.Color.DarkRed;
            this.btnEntrar.StatePressed.Border.Color2 = System.Drawing.Color.DarkRed;
            this.btnEntrar.StatePressed.Border.ColorAngle = 135F;
            this.btnEntrar.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEntrar.StatePressed.Border.Rounding = 20;
            this.btnEntrar.StatePressed.Border.Width = 1;
            this.btnEntrar.StateTracking.Back.Color1 = System.Drawing.Color.Gold;
            this.btnEntrar.StateTracking.Back.Color2 = System.Drawing.Color.Gold;
            this.btnEntrar.StateTracking.Border.Color1 = System.Drawing.Color.DarkRed;
            this.btnEntrar.StateTracking.Border.Color2 = System.Drawing.Color.DarkRed;
            this.btnEntrar.StateTracking.Border.ColorAngle = 45F;
            this.btnEntrar.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEntrar.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnEntrar.TabIndex = 23;
            this.btnEntrar.Values.Text = "Entrar";
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            this.btnEntrar.MouseEnter += new System.EventHandler(this.btnEntrar_MouseEnter);
            this.btnEntrar.MouseLeave += new System.EventHandler(this.btnEntrar_MouseLeave);
            this.btnEntrar.MouseHover += new System.EventHandler(this.btnEntrar_MouseHover);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(333, 373);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnCadastrar.Size = new System.Drawing.Size(155, 43);
            this.btnCadastrar.StateCommon.Border.Color1 = System.Drawing.Color.Gold;
            this.btnCadastrar.StateCommon.Border.Color2 = System.Drawing.Color.Gold;
            this.btnCadastrar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCadastrar.StateCommon.Border.Rounding = 20;
            this.btnCadastrar.StateCommon.Border.Width = 1;
            this.btnCadastrar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnCadastrar.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnCadastrar.StatePressed.Back.ColorAngle = 135F;
            this.btnCadastrar.StatePressed.Border.Color1 = System.Drawing.Color.DarkRed;
            this.btnCadastrar.StatePressed.Border.Color2 = System.Drawing.Color.DarkRed;
            this.btnCadastrar.StatePressed.Border.ColorAngle = 135F;
            this.btnCadastrar.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCadastrar.StatePressed.Border.Rounding = 20;
            this.btnCadastrar.StatePressed.Border.Width = 1;
            this.btnCadastrar.StateTracking.Back.Color1 = System.Drawing.Color.Gold;
            this.btnCadastrar.StateTracking.Back.Color2 = System.Drawing.Color.Gold;
            this.btnCadastrar.StateTracking.Border.Color1 = System.Drawing.Color.DarkRed;
            this.btnCadastrar.StateTracking.Border.Color2 = System.Drawing.Color.DarkRed;
            this.btnCadastrar.StateTracking.Border.ColorAngle = 45F;
            this.btnCadastrar.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCadastrar.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCadastrar.TabIndex = 24;
            this.btnCadastrar.Values.Text = "Cadastrar";
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            this.btnCadastrar.MouseEnter += new System.EventHandler(this.btnEntrar_MouseEnter);
            this.btnCadastrar.MouseLeave += new System.EventHandler(this.btnEntrar_MouseLeave);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(109, 428);
            this.btnSair.Name = "btnSair";
            this.btnSair.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnSair.Size = new System.Drawing.Size(379, 43);
            this.btnSair.StateCommon.Border.Color1 = System.Drawing.Color.Gold;
            this.btnSair.StateCommon.Border.Color2 = System.Drawing.Color.Gold;
            this.btnSair.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSair.StateCommon.Border.Rounding = 20;
            this.btnSair.StateCommon.Border.Width = 1;
            this.btnSair.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnSair.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnSair.StatePressed.Back.ColorAngle = 135F;
            this.btnSair.StatePressed.Border.Color1 = System.Drawing.Color.DarkRed;
            this.btnSair.StatePressed.Border.Color2 = System.Drawing.Color.DarkRed;
            this.btnSair.StatePressed.Border.ColorAngle = 135F;
            this.btnSair.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSair.StatePressed.Border.Rounding = 20;
            this.btnSair.StatePressed.Border.Width = 1;
            this.btnSair.StateTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnSair.StateTracking.Back.Color2 = System.Drawing.Color.Red;
            this.btnSair.StateTracking.Border.Color1 = System.Drawing.Color.DarkRed;
            this.btnSair.StateTracking.Border.Color2 = System.Drawing.Color.DarkRed;
            this.btnSair.StateTracking.Border.ColorAngle = 45F;
            this.btnSair.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSair.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSair.TabIndex = 25;
            this.btnSair.Values.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1266, 690);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.btnEsqueciMinhaSenha);
            this.Controls.Add(this.campoSenha);
            this.Controls.Add(this.campoEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Login";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox campoEmail;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox campoSenha;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel btnEsqueciMinhaSenha;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEntrar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCadastrar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSair;
    }
}

