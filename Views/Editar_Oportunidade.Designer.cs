namespace CareerConnect.Views
{
    partial class Editar_Oportunidade
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
            this.campoTituloVaga = new System.Windows.Forms.TextBox();
            this.campoDescricao = new System.Windows.Forms.TextBox();
            this.campoSalario = new System.Windows.Forms.TextBox();
            this.campoEmpresa = new System.Windows.Forms.TextBox();
            this.campoCNPJ = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.campoID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboboxStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // campoTituloVaga
            // 
            this.campoTituloVaga.Location = new System.Drawing.Point(452, 90);
            this.campoTituloVaga.Name = "campoTituloVaga";
            this.campoTituloVaga.Size = new System.Drawing.Size(270, 20);
            this.campoTituloVaga.TabIndex = 0;
            this.campoTituloVaga.TextChanged += new System.EventHandler(this.campoTituloVaga_TextChanged);
            // 
            // campoDescricao
            // 
            this.campoDescricao.Location = new System.Drawing.Point(452, 134);
            this.campoDescricao.Name = "campoDescricao";
            this.campoDescricao.Size = new System.Drawing.Size(270, 20);
            this.campoDescricao.TabIndex = 1;
            // 
            // campoSalario
            // 
            this.campoSalario.Location = new System.Drawing.Point(452, 177);
            this.campoSalario.Name = "campoSalario";
            this.campoSalario.Size = new System.Drawing.Size(270, 20);
            this.campoSalario.TabIndex = 2;
            // 
            // campoEmpresa
            // 
            this.campoEmpresa.Location = new System.Drawing.Point(452, 218);
            this.campoEmpresa.Name = "campoEmpresa";
            this.campoEmpresa.Size = new System.Drawing.Size(270, 20);
            this.campoEmpresa.TabIndex = 4;
            // 
            // campoCNPJ
            // 
            this.campoCNPJ.Location = new System.Drawing.Point(452, 258);
            this.campoCNPJ.Name = "campoCNPJ";
            this.campoCNPJ.ReadOnly = true;
            this.campoCNPJ.Size = new System.Drawing.Size(270, 20);
            this.campoCNPJ.TabIndex = 5;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(452, 378);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(270, 23);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(452, 416);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(270, 23);
            this.btnRetornar.TabIndex = 7;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Título da Vaga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Salário";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Empresa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "CNPJ";
            // 
            // campoID
            // 
            this.campoID.Location = new System.Drawing.Point(452, 47);
            this.campoID.Name = "campoID";
            this.campoID.ReadOnly = true;
            this.campoID.Size = new System.Drawing.Size(59, 20);
            this.campoID.TabIndex = 14;
            this.campoID.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "ID";
            this.label4.Visible = false;
            // 
            // ComboboxStatus
            // 
            this.ComboboxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboboxStatus.FormattingEnabled = true;
            this.ComboboxStatus.Location = new System.Drawing.Point(452, 311);
            this.ComboboxStatus.Name = "ComboboxStatus";
            this.ComboboxStatus.Size = new System.Drawing.Size(270, 21);
            this.ComboboxStatus.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(398, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Status";
            // 
            // Editar_Oportunidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 597);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ComboboxStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.campoID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.campoCNPJ);
            this.Controls.Add(this.campoEmpresa);
            this.Controls.Add(this.campoSalario);
            this.Controls.Add(this.campoDescricao);
            this.Controls.Add(this.campoTituloVaga);
            this.Name = "Editar_Oportunidade";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vagas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox campoTituloVaga;
        private System.Windows.Forms.TextBox campoDescricao;
        private System.Windows.Forms.TextBox campoSalario;
        private System.Windows.Forms.TextBox campoEmpresa;
        private System.Windows.Forms.TextBox campoCNPJ;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox campoID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboboxStatus;
        private System.Windows.Forms.Label label7;
    }
}