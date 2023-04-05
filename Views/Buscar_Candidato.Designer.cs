namespace CareerConnect.Views
{
    partial class Buscar_Candidato
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
            this.campoNomeBC = new System.Windows.Forms.TextBox();
            this.campoEmailBC = new System.Windows.Forms.TextBox();
            this.campoIdadeBC = new System.Windows.Forms.TextBox();
            this.campoEnderecoBC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // campoNomeBC
            // 
            this.campoNomeBC.Enabled = false;
            this.campoNomeBC.Location = new System.Drawing.Point(96, 41);
            this.campoNomeBC.Name = "campoNomeBC";
            this.campoNomeBC.Size = new System.Drawing.Size(274, 20);
            this.campoNomeBC.TabIndex = 0;
            // 
            // campoEmailBC
            // 
            this.campoEmailBC.Enabled = false;
            this.campoEmailBC.Location = new System.Drawing.Point(96, 85);
            this.campoEmailBC.Name = "campoEmailBC";
            this.campoEmailBC.Size = new System.Drawing.Size(274, 20);
            this.campoEmailBC.TabIndex = 1;
            // 
            // campoIdadeBC
            // 
            this.campoIdadeBC.Enabled = false;
            this.campoIdadeBC.Location = new System.Drawing.Point(96, 130);
            this.campoIdadeBC.Name = "campoIdadeBC";
            this.campoIdadeBC.Size = new System.Drawing.Size(274, 20);
            this.campoIdadeBC.TabIndex = 2;
            // 
            // campoEnderecoBC
            // 
            this.campoEnderecoBC.Enabled = false;
            this.campoEnderecoBC.Location = new System.Drawing.Point(96, 175);
            this.campoEnderecoBC.Name = "campoEnderecoBC";
            this.campoEnderecoBC.Size = new System.Drawing.Size(274, 20);
            this.campoEnderecoBC.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Idade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Endereço";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(25, 288);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(345, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Buscar_Candidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 367);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.campoEnderecoBC);
            this.Controls.Add(this.campoIdadeBC);
            this.Controls.Add(this.campoEmailBC);
            this.Controls.Add(this.campoNomeBC);
            this.Name = "Buscar_Candidato";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Candidato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox campoNomeBC;
        private System.Windows.Forms.TextBox campoEmailBC;
        private System.Windows.Forms.TextBox campoIdadeBC;
        private System.Windows.Forms.TextBox campoEnderecoBC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOK;
    }
}