namespace CareerConnect.Views
{
    partial class Cadastrar_Oportunidade
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
            this.campoTitulo = new System.Windows.Forms.TextBox();
            this.campoDesc = new System.Windows.Forms.TextBox();
            this.campoSalario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.campoNomeFantasia = new System.Windows.Forms.TextBox();
            this.campoCNPJ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BotaoCadastrarVaga = new System.Windows.Forms.Button();
            this.ComboboxStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // campoTitulo
            // 
            this.campoTitulo.Location = new System.Drawing.Point(373, 74);
            this.campoTitulo.Name = "campoTitulo";
            this.campoTitulo.Size = new System.Drawing.Size(173, 20);
            this.campoTitulo.TabIndex = 0;
            // 
            // campoDesc
            // 
            this.campoDesc.Location = new System.Drawing.Point(373, 123);
            this.campoDesc.Name = "campoDesc";
            this.campoDesc.Size = new System.Drawing.Size(173, 20);
            this.campoDesc.TabIndex = 1;
            // 
            // campoSalario
            // 
            this.campoSalario.Location = new System.Drawing.Point(373, 186);
            this.campoSalario.Name = "campoSalario";
            this.campoSalario.Size = new System.Drawing.Size(173, 20);
            this.campoSalario.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Título da Vaga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Salário";
            // 
            // campoNomeFantasia
            // 
            this.campoNomeFantasia.Location = new System.Drawing.Point(373, 237);
            this.campoNomeFantasia.Name = "campoNomeFantasia";
            this.campoNomeFantasia.Size = new System.Drawing.Size(173, 20);
            this.campoNomeFantasia.TabIndex = 7;
            // 
            // campoCNPJ
            // 
            this.campoCNPJ.Location = new System.Drawing.Point(373, 289);
            this.campoCNPJ.Name = "campoCNPJ";
            this.campoCNPJ.ReadOnly = true;
            this.campoCNPJ.Size = new System.Drawing.Size(173, 20);
            this.campoCNPJ.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nome da Empresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "CNPJ";
            // 
            // BotaoCadastrarVaga
            // 
            this.BotaoCadastrarVaga.Location = new System.Drawing.Point(373, 416);
            this.BotaoCadastrarVaga.Name = "BotaoCadastrarVaga";
            this.BotaoCadastrarVaga.Size = new System.Drawing.Size(173, 23);
            this.BotaoCadastrarVaga.TabIndex = 11;
            this.BotaoCadastrarVaga.Text = "Cadastrar";
            this.BotaoCadastrarVaga.UseVisualStyleBackColor = true;
            this.BotaoCadastrarVaga.Click += new System.EventHandler(this.BotaoCadastrarVaga_Click);
            // 
            // ComboboxStatus
            // 
            this.ComboboxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboboxStatus.FormattingEnabled = true;
            this.ComboboxStatus.Location = new System.Drawing.Point(373, 350);
            this.ComboboxStatus.Name = "ComboboxStatus";
            this.ComboboxStatus.Size = new System.Drawing.Size(173, 21);
            this.ComboboxStatus.TabIndex = 12;
            this.ComboboxStatus.SelectedIndexChanged += new System.EventHandler(this.ComboboxStatus_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(313, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Status";
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(373, 446);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(173, 23);
            this.btnRetornar.TabIndex = 14;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click_1);
            // 
            // Cadastrar_Oportunidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 520);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ComboboxStatus);
            this.Controls.Add(this.BotaoCadastrarVaga);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.campoCNPJ);
            this.Controls.Add(this.campoNomeFantasia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.campoSalario);
            this.Controls.Add(this.campoDesc);
            this.Controls.Add(this.campoTitulo);
            this.Name = "Cadastrar_Oportunidade";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Oportunidade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox campoTitulo;
        private System.Windows.Forms.TextBox campoDesc;
        private System.Windows.Forms.TextBox campoSalario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox campoNomeFantasia;
        private System.Windows.Forms.TextBox campoCNPJ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BotaoCadastrarVaga;
        private System.Windows.Forms.ComboBox ComboboxStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRetornar;
    }
}