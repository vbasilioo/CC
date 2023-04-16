namespace CareerConnect.Views
{
    partial class Desassociar_Candidato
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
            this.GridOportunidades = new System.Windows.Forms.DataGridView();
            this.campoNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDesassociar = new System.Windows.Forms.Button();
            this.btnRetornar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridOportunidades)).BeginInit();
            this.SuspendLayout();
            // 
            // GridOportunidades
            // 
            this.GridOportunidades.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridOportunidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridOportunidades.GridColor = System.Drawing.SystemColors.Control;
            this.GridOportunidades.Location = new System.Drawing.Point(361, 12);
            this.GridOportunidades.Name = "GridOportunidades";
            this.GridOportunidades.Size = new System.Drawing.Size(1427, 639);
            this.GridOportunidades.TabIndex = 0;
            // 
            // campoNome
            // 
            this.campoNome.Location = new System.Drawing.Point(12, 72);
            this.campoNome.Name = "campoNome";
            this.campoNome.Size = new System.Drawing.Size(326, 20);
            this.campoNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite o ID que deseja desassociar";
            // 
            // btnDesassociar
            // 
            this.btnDesassociar.Location = new System.Drawing.Point(15, 443);
            this.btnDesassociar.Name = "btnDesassociar";
            this.btnDesassociar.Size = new System.Drawing.Size(323, 23);
            this.btnDesassociar.TabIndex = 3;
            this.btnDesassociar.Text = "Desassociar";
            this.btnDesassociar.UseVisualStyleBackColor = true;
            this.btnDesassociar.Click += new System.EventHandler(this.btnDesassociar_Click);
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(15, 473);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(323, 23);
            this.btnRetornar.TabIndex = 4;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // Desassociar_Candidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 663);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.btnDesassociar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.campoNome);
            this.Controls.Add(this.GridOportunidades);
            this.Name = "Desassociar_Candidato";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desassociar Candidato";
            ((System.ComponentModel.ISupportInitialize)(this.GridOportunidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridOportunidades;
        private System.Windows.Forms.TextBox campoNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDesassociar;
        private System.Windows.Forms.Button btnRetornar;
    }
}