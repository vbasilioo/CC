namespace CareerConnect.Views
{
    partial class Usuario_NovaSenha
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
            this.campoSenhaAntiga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.campoSenha = new System.Windows.Forms.TextBox();
            this.campoNovaSenha = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelNovaSenha = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnConfirmar2 = new System.Windows.Forms.Button();
            this.btnConfirmar3 = new System.Windows.Forms.Button();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // campoSenhaAntiga
            // 
            this.campoSenhaAntiga.Location = new System.Drawing.Point(262, 85);
            this.campoSenhaAntiga.Name = "campoSenhaAntiga";
            this.campoSenhaAntiga.PasswordChar = '*';
            this.campoSenhaAntiga.Size = new System.Drawing.Size(212, 20);
            this.campoSenhaAntiga.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insira sua senha atual";
            // 
            // campoSenha
            // 
            this.campoSenha.Location = new System.Drawing.Point(262, 159);
            this.campoSenha.Name = "campoSenha";
            this.campoSenha.PasswordChar = '*';
            this.campoSenha.Size = new System.Drawing.Size(212, 20);
            this.campoSenha.TabIndex = 2;
            // 
            // campoNovaSenha
            // 
            this.campoNovaSenha.Location = new System.Drawing.Point(262, 244);
            this.campoNovaSenha.Name = "campoNovaSenha";
            this.campoNovaSenha.PasswordChar = '*';
            this.campoNovaSenha.Size = new System.Drawing.Size(212, 20);
            this.campoNovaSenha.TabIndex = 3;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(262, 140);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(111, 13);
            this.labelSenha.TabIndex = 4;
            this.labelSenha.Text = "Insira sua nova senha";
            // 
            // labelNovaSenha
            // 
            this.labelNovaSenha.AutoSize = true;
            this.labelNovaSenha.Location = new System.Drawing.Point(262, 225);
            this.labelNovaSenha.Name = "labelNovaSenha";
            this.labelNovaSenha.Size = new System.Drawing.Size(156, 13);
            this.labelNovaSenha.TabIndex = 5;
            this.labelNovaSenha.Text = "Insira novamente a nova senha";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(262, 300);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(212, 23);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Confirmar (1)";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnConfirmar2
            // 
            this.btnConfirmar2.Location = new System.Drawing.Point(262, 330);
            this.btnConfirmar2.Name = "btnConfirmar2";
            this.btnConfirmar2.Size = new System.Drawing.Size(212, 23);
            this.btnConfirmar2.TabIndex = 7;
            this.btnConfirmar2.Text = "Confirmar (2)";
            this.btnConfirmar2.UseVisualStyleBackColor = true;
            this.btnConfirmar2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnConfirmar2_MouseClick);
            // 
            // btnConfirmar3
            // 
            this.btnConfirmar3.Location = new System.Drawing.Point(262, 360);
            this.btnConfirmar3.Name = "btnConfirmar3";
            this.btnConfirmar3.Size = new System.Drawing.Size(212, 23);
            this.btnConfirmar3.TabIndex = 8;
            this.btnConfirmar3.Text = "Confirmar (3)";
            this.btnConfirmar3.UseVisualStyleBackColor = true;
            this.btnConfirmar3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnConfirmar3_MouseClick);
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(262, 390);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(212, 23);
            this.btnRetornar.TabIndex = 9;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Usuario_NovaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 491);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.btnConfirmar3);
            this.Controls.Add(this.btnConfirmar2);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.labelNovaSenha);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.campoNovaSenha);
            this.Controls.Add(this.campoSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.campoSenhaAntiga);
            this.Name = "Usuario_NovaSenha";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox campoSenhaAntiga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox campoSenha;
        private System.Windows.Forms.TextBox campoNovaSenha;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelNovaSenha;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnConfirmar2;
        private System.Windows.Forms.Button btnConfirmar3;
        private System.Windows.Forms.Button btnRetornar;
    }
}