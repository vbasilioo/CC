namespace CareerConnect.Views
{
    partial class Login_CadastrarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_CadastrarUsuario));
            this.campoNome = new System.Windows.Forms.TextBox();
            this.campoCadastrarEmail1 = new System.Windows.Forms.TextBox();
            this.campoCadastrarSenha = new System.Windows.Forms.TextBox();
            this.ComboboxCargo = new System.Windows.Forms.ComboBox();
            this.campoEndereco = new System.Windows.Forms.TextBox();
            this.BotaoCadastrar = new System.Windows.Forms.Button();
            this.BotaoRetornar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.campoCNPJCadastrar = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // campoNome
            // 
            this.campoNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(98)))), ((int)(((byte)(103)))));
            this.campoNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoNome.Location = new System.Drawing.Point(511, 180);
            this.campoNome.Multiline = true;
            this.campoNome.Name = "campoNome";
            this.campoNome.Size = new System.Drawing.Size(302, 49);
            this.campoNome.TabIndex = 1;
            // 
            // campoCadastrarEmail1
            // 
            this.campoCadastrarEmail1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(98)))), ((int)(((byte)(103)))));
            this.campoCadastrarEmail1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoCadastrarEmail1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoCadastrarEmail1.Location = new System.Drawing.Point(511, 292);
            this.campoCadastrarEmail1.Multiline = true;
            this.campoCadastrarEmail1.Name = "campoCadastrarEmail1";
            this.campoCadastrarEmail1.Size = new System.Drawing.Size(302, 46);
            this.campoCadastrarEmail1.TabIndex = 3;
            // 
            // campoCadastrarSenha
            // 
            this.campoCadastrarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(98)))), ((int)(((byte)(103)))));
            this.campoCadastrarSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoCadastrarSenha.Location = new System.Drawing.Point(511, 402);
            this.campoCadastrarSenha.Multiline = true;
            this.campoCadastrarSenha.Name = "campoCadastrarSenha";
            this.campoCadastrarSenha.PasswordChar = '*';
            this.campoCadastrarSenha.Size = new System.Drawing.Size(302, 45);
            this.campoCadastrarSenha.TabIndex = 9;
            // 
            // ComboboxCargo
            // 
            this.ComboboxCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(98)))), ((int)(((byte)(103)))));
            this.ComboboxCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.ComboboxCargo.FormattingEnabled = true;
            this.ComboboxCargo.IntegralHeight = false;
            this.ComboboxCargo.ItemHeight = 13;
            this.ComboboxCargo.Location = new System.Drawing.Point(879, 292);
            this.ComboboxCargo.Name = "ComboboxCargo";
            this.ComboboxCargo.Size = new System.Drawing.Size(308, 47);
            this.ComboboxCargo.TabIndex = 15;
            this.ComboboxCargo.Visible = false;
            this.ComboboxCargo.SelectedIndexChanged += new System.EventHandler(this.ComboboxCargo_SelectedIndexChanged);
            // 
            // campoEndereco
            // 
            this.campoEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(98)))), ((int)(((byte)(103)))));
            this.campoEndereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoEndereco.Location = new System.Drawing.Point(879, 185);
            this.campoEndereco.Multiline = true;
            this.campoEndereco.Name = "campoEndereco";
            this.campoEndereco.Size = new System.Drawing.Size(308, 48);
            this.campoEndereco.TabIndex = 21;
            // 
            // BotaoCadastrar
            // 
            this.BotaoCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(128)))), ((int)(((byte)(59)))));
            this.BotaoCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotaoCadastrar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoCadastrar.ForeColor = System.Drawing.SystemColors.Control;
            this.BotaoCadastrar.Location = new System.Drawing.Point(704, 521);
            this.BotaoCadastrar.Name = "BotaoCadastrar";
            this.BotaoCadastrar.Size = new System.Drawing.Size(247, 77);
            this.BotaoCadastrar.TabIndex = 22;
            this.BotaoCadastrar.Text = "Cadastrar";
            this.BotaoCadastrar.UseVisualStyleBackColor = false;
            this.BotaoCadastrar.Click += new System.EventHandler(this.BotaoCadastrar_Click);
            // 
            // BotaoRetornar
            // 
            this.BotaoRetornar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(128)))), ((int)(((byte)(59)))));
            this.BotaoRetornar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoRetornar.ForeColor = System.Drawing.SystemColors.Control;
            this.BotaoRetornar.Location = new System.Drawing.Point(1047, 41);
            this.BotaoRetornar.Name = "BotaoRetornar";
            this.BotaoRetornar.Size = new System.Drawing.Size(131, 42);
            this.BotaoRetornar.TabIndex = 23;
            this.BotaoRetornar.Text = "Logar";
            this.BotaoRetornar.UseVisualStyleBackColor = false;
            this.BotaoRetornar.Click += new System.EventHandler(this.BotaoRetornar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(99, 578);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(184, 20);
            this.dateTimePicker1.TabIndex = 24;
            this.dateTimePicker1.Visible = false;
            // 
            // campoCNPJCadastrar
            // 
            this.campoCNPJCadastrar.Location = new System.Drawing.Point(78, 604);
            this.campoCNPJCadastrar.Name = "campoCNPJCadastrar";
            this.campoCNPJCadastrar.Size = new System.Drawing.Size(205, 20);
            this.campoCNPJCadastrar.TabIndex = 31;
            this.campoCNPJCadastrar.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(98)))), ((int)(((byte)(103)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(879, 402);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 45);
            this.textBox1.TabIndex = 32;
            // 
            // Login_CadastrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1229, 659);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.campoCNPJCadastrar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.BotaoRetornar);
            this.Controls.Add(this.BotaoCadastrar);
            this.Controls.Add(this.campoEndereco);
            this.Controls.Add(this.ComboboxCargo);
            this.Controls.Add(this.campoCadastrarSenha);
            this.Controls.Add(this.campoCadastrarEmail1);
            this.Controls.Add(this.campoNome);
            this.DoubleBuffered = true;
            this.Name = "Login_CadastrarUsuario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox campoNome;
        private System.Windows.Forms.TextBox campoCadastrarEmail1;
        private System.Windows.Forms.TextBox campoCadastrarSenha;
        private System.Windows.Forms.ComboBox ComboboxCargo;
        private System.Windows.Forms.TextBox campoEndereco;
        private System.Windows.Forms.Button BotaoCadastrar;
        private System.Windows.Forms.Button BotaoRetornar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox campoCNPJCadastrar;
        private System.Windows.Forms.TextBox textBox1;
    }
}