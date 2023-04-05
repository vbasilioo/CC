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
            this.campoNome = new System.Windows.Forms.TextBox();
            this.campoCadastrarEmail1 = new System.Windows.Forms.TextBox();
            this.campoCadastrarSenha = new System.Windows.Forms.TextBox();
            this.ComboboxCargo = new System.Windows.Forms.ComboBox();
            this.campoEndereco = new System.Windows.Forms.TextBox();
            this.BotaoCadastrar = new System.Windows.Forms.Button();
            this.BotaoRetornar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.campoCNPJCadastrar = new System.Windows.Forms.TextBox();
            this.labelCNPJ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // campoNome
            // 
            this.campoNome.Location = new System.Drawing.Point(625, 161);
            this.campoNome.Name = "campoNome";
            this.campoNome.Size = new System.Drawing.Size(205, 20);
            this.campoNome.TabIndex = 1;
            // 
            // campoCadastrarEmail1
            // 
            this.campoCadastrarEmail1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoCadastrarEmail1.Location = new System.Drawing.Point(625, 280);
            this.campoCadastrarEmail1.Name = "campoCadastrarEmail1";
            this.campoCadastrarEmail1.Size = new System.Drawing.Size(205, 20);
            this.campoCadastrarEmail1.TabIndex = 3;
            // 
            // campoCadastrarSenha
            // 
            this.campoCadastrarSenha.Location = new System.Drawing.Point(625, 390);
            this.campoCadastrarSenha.Name = "campoCadastrarSenha";
            this.campoCadastrarSenha.PasswordChar = '*';
            this.campoCadastrarSenha.Size = new System.Drawing.Size(205, 20);
            this.campoCadastrarSenha.TabIndex = 9;
            // 
            // ComboboxCargo
            // 
            this.ComboboxCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboboxCargo.FormattingEnabled = true;
            this.ComboboxCargo.Location = new System.Drawing.Point(1003, 275);
            this.ComboboxCargo.Name = "ComboboxCargo";
            this.ComboboxCargo.Size = new System.Drawing.Size(184, 21);
            this.ComboboxCargo.TabIndex = 15;
            this.ComboboxCargo.SelectedIndexChanged += new System.EventHandler(this.ComboboxCargo_SelectedIndexChanged);
            // 
            // campoEndereco
            // 
            this.campoEndereco.Location = new System.Drawing.Point(1003, 161);
            this.campoEndereco.Name = "campoEndereco";
            this.campoEndereco.Size = new System.Drawing.Size(184, 20);
            this.campoEndereco.TabIndex = 21;
            // 
            // BotaoCadastrar
            // 
            this.BotaoCadastrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BotaoCadastrar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoCadastrar.ForeColor = System.Drawing.SystemColors.Control;
            this.BotaoCadastrar.Location = new System.Drawing.Point(656, 557);
            this.BotaoCadastrar.Name = "BotaoCadastrar";
            this.BotaoCadastrar.Size = new System.Drawing.Size(480, 50);
            this.BotaoCadastrar.TabIndex = 22;
            this.BotaoCadastrar.Text = "Cadastrar";
            this.BotaoCadastrar.UseVisualStyleBackColor = false;
            this.BotaoCadastrar.Click += new System.EventHandler(this.BotaoCadastrar_Click);
            // 
            // BotaoRetornar
            // 
            this.BotaoRetornar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BotaoRetornar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoRetornar.ForeColor = System.Drawing.SystemColors.Control;
            this.BotaoRetornar.Location = new System.Drawing.Point(1048, 47);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(1003, 384);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(184, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nome Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(581, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(886, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Data de Nascimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(955, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Cargo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(937, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Endereço";
            // 
            // campoCNPJCadastrar
            // 
            this.campoCNPJCadastrar.Location = new System.Drawing.Point(625, 468);
            this.campoCNPJCadastrar.Name = "campoCNPJCadastrar";
            this.campoCNPJCadastrar.Size = new System.Drawing.Size(205, 20);
            this.campoCNPJCadastrar.TabIndex = 31;
            // 
            // labelCNPJ
            // 
            this.labelCNPJ.AutoSize = true;
            this.labelCNPJ.Location = new System.Drawing.Point(585, 471);
            this.labelCNPJ.Name = "labelCNPJ";
            this.labelCNPJ.Size = new System.Drawing.Size(34, 13);
            this.labelCNPJ.TabIndex = 32;
            this.labelCNPJ.Text = "CNPJ";
            // 
            // Login_CadastrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1229, 659);
            this.Controls.Add(this.labelCNPJ);
            this.Controls.Add(this.campoCNPJCadastrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_CadastrarUsuario";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox campoCNPJCadastrar;
        private System.Windows.Forms.Label labelCNPJ;
    }
}