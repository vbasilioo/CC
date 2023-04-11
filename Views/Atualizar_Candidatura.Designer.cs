namespace CareerConnect.Views
{
    partial class Atualizar_Candidatura
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
            this.campoNomeSocial = new System.Windows.Forms.TextBox();
            this.campoTelefone = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.campoComentario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.campoID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // campoNomeSocial
            // 
            this.campoNomeSocial.Location = new System.Drawing.Point(294, 63);
            this.campoNomeSocial.Name = "campoNomeSocial";
            this.campoNomeSocial.Size = new System.Drawing.Size(309, 20);
            this.campoNomeSocial.TabIndex = 1;
            // 
            // campoTelefone
            // 
            this.campoTelefone.Location = new System.Drawing.Point(294, 131);
            this.campoTelefone.Name = "campoTelefone";
            this.campoTelefone.Size = new System.Drawing.Size(309, 20);
            this.campoTelefone.TabIndex = 2;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(294, 280);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(309, 23);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(294, 319);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(309, 23);
            this.btnRetornar.TabIndex = 4;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(294, 44);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(67, 13);
            this.labelTelefone.TabIndex = 6;
            this.labelTelefone.Text = "Nome Social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefone";
            // 
            // campoComentario
            // 
            this.campoComentario.Location = new System.Drawing.Point(297, 207);
            this.campoComentario.Name = "campoComentario";
            this.campoComentario.Size = new System.Drawing.Size(306, 20);
            this.campoComentario.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Comentários";
            // 
            // campoID
            // 
            this.campoID.Enabled = false;
            this.campoID.Location = new System.Drawing.Point(294, 4);
            this.campoID.Name = "campoID";
            this.campoID.Size = new System.Drawing.Size(49, 20);
            this.campoID.TabIndex = 10;
            this.campoID.Visible = false;
            this.campoID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Atualizar_Candidatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 379);
            this.Controls.Add(this.campoID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.campoComentario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.campoTelefone);
            this.Controls.Add(this.campoNomeSocial);
            this.Name = "Atualizar_Candidatura";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar Candidatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox campoNomeSocial;
        private System.Windows.Forms.TextBox campoTelefone;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox campoComentario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox campoID;
    }
}