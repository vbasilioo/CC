namespace CareerConnect.Views
{
    partial class Vagas
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
            this.btnCadastrarVaga = new System.Windows.Forms.Button();
            this.GridOportunidades = new System.Windows.Forms.DataGridView();
            this.btnEditarVaga = new System.Windows.Forms.Button();
            this.btnDeletarVaga = new System.Windows.Forms.Button();
            this.btnListarCandidatos = new System.Windows.Forms.Button();
            this.btnBuscarCandidato = new System.Windows.Forms.Button();
            this.btnAssociarCandidato = new System.Windows.Forms.Button();
            this.btnDesassociarCandidato = new System.Windows.Forms.Button();
            this.btnListarEmpresas = new System.Windows.Forms.Button();
            this.btnCandidatar = new System.Windows.Forms.Button();
            this.btnAttCandidatura = new System.Windows.Forms.Button();
            this.btnExcluirCandidatura = new System.Windows.Forms.Button();
            this.btnListarCandidaturas = new System.Windows.Forms.Button();
            this.campoPesquisarEmpresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridOportunidades)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrarVaga
            // 
            this.btnCadastrarVaga.Location = new System.Drawing.Point(12, 38);
            this.btnCadastrarVaga.Name = "btnCadastrarVaga";
            this.btnCadastrarVaga.Size = new System.Drawing.Size(117, 23);
            this.btnCadastrarVaga.TabIndex = 0;
            this.btnCadastrarVaga.Text = "Cadastrar vaga";
            this.btnCadastrarVaga.UseVisualStyleBackColor = true;
            this.btnCadastrarVaga.Click += new System.EventHandler(this.btnCadastrarVaga_Click);
            // 
            // GridOportunidades
            // 
            this.GridOportunidades.AllowUserToOrderColumns = true;
            this.GridOportunidades.BackgroundColor = System.Drawing.Color.White;
            this.GridOportunidades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridOportunidades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.GridOportunidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridOportunidades.GridColor = System.Drawing.Color.White;
            this.GridOportunidades.Location = new System.Drawing.Point(168, 47);
            this.GridOportunidades.Name = "GridOportunidades";
            this.GridOportunidades.Size = new System.Drawing.Size(1362, 630);
            this.GridOportunidades.TabIndex = 3;
            this.GridOportunidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridOportunidades_CellContentClick);
            this.GridOportunidades.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridOportunidades_RowValidated);
            // 
            // btnEditarVaga
            // 
            this.btnEditarVaga.Location = new System.Drawing.Point(12, 67);
            this.btnEditarVaga.Name = "btnEditarVaga";
            this.btnEditarVaga.Size = new System.Drawing.Size(117, 23);
            this.btnEditarVaga.TabIndex = 4;
            this.btnEditarVaga.Text = "Editar vaga";
            this.btnEditarVaga.UseVisualStyleBackColor = true;
            this.btnEditarVaga.Click += new System.EventHandler(this.btnEditarVaga_Click);
            this.btnEditarVaga.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnEditarVaga_MouseClick);
            // 
            // btnDeletarVaga
            // 
            this.btnDeletarVaga.Location = new System.Drawing.Point(12, 96);
            this.btnDeletarVaga.Name = "btnDeletarVaga";
            this.btnDeletarVaga.Size = new System.Drawing.Size(117, 23);
            this.btnDeletarVaga.TabIndex = 5;
            this.btnDeletarVaga.Text = "Excluir vaga";
            this.btnDeletarVaga.UseVisualStyleBackColor = true;
            this.btnDeletarVaga.Click += new System.EventHandler(this.btnDeletarVaga_Click);
            // 
            // btnListarCandidatos
            // 
            this.btnListarCandidatos.Location = new System.Drawing.Point(12, 205);
            this.btnListarCandidatos.Name = "btnListarCandidatos";
            this.btnListarCandidatos.Size = new System.Drawing.Size(117, 23);
            this.btnListarCandidatos.TabIndex = 6;
            this.btnListarCandidatos.Text = "Listar Candidatos";
            this.btnListarCandidatos.UseVisualStyleBackColor = true;
            // 
            // btnBuscarCandidato
            // 
            this.btnBuscarCandidato.Location = new System.Drawing.Point(12, 235);
            this.btnBuscarCandidato.Name = "btnBuscarCandidato";
            this.btnBuscarCandidato.Size = new System.Drawing.Size(117, 23);
            this.btnBuscarCandidato.TabIndex = 7;
            this.btnBuscarCandidato.Text = "Buscar Candidato";
            this.btnBuscarCandidato.UseVisualStyleBackColor = true;
            this.btnBuscarCandidato.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAssociarCandidato
            // 
            this.btnAssociarCandidato.Location = new System.Drawing.Point(12, 264);
            this.btnAssociarCandidato.Name = "btnAssociarCandidato";
            this.btnAssociarCandidato.Size = new System.Drawing.Size(117, 23);
            this.btnAssociarCandidato.TabIndex = 8;
            this.btnAssociarCandidato.Text = "Associar Candidato";
            this.btnAssociarCandidato.UseVisualStyleBackColor = true;
            // 
            // btnDesassociarCandidato
            // 
            this.btnDesassociarCandidato.Location = new System.Drawing.Point(12, 294);
            this.btnDesassociarCandidato.Name = "btnDesassociarCandidato";
            this.btnDesassociarCandidato.Size = new System.Drawing.Size(117, 23);
            this.btnDesassociarCandidato.TabIndex = 9;
            this.btnDesassociarCandidato.Text = "Desassociar Candidato";
            this.btnDesassociarCandidato.UseVisualStyleBackColor = true;
            // 
            // btnListarEmpresas
            // 
            this.btnListarEmpresas.Location = new System.Drawing.Point(12, 324);
            this.btnListarEmpresas.Name = "btnListarEmpresas";
            this.btnListarEmpresas.Size = new System.Drawing.Size(117, 23);
            this.btnListarEmpresas.TabIndex = 10;
            this.btnListarEmpresas.Text = "Listar Empresas";
            this.btnListarEmpresas.UseVisualStyleBackColor = true;
            // 
            // btnCandidatar
            // 
            this.btnCandidatar.Location = new System.Drawing.Point(13, 417);
            this.btnCandidatar.Name = "btnCandidatar";
            this.btnCandidatar.Size = new System.Drawing.Size(116, 23);
            this.btnCandidatar.TabIndex = 11;
            this.btnCandidatar.Text = "Candidatar-se";
            this.btnCandidatar.UseVisualStyleBackColor = true;
            // 
            // btnAttCandidatura
            // 
            this.btnAttCandidatura.Location = new System.Drawing.Point(13, 446);
            this.btnAttCandidatura.Name = "btnAttCandidatura";
            this.btnAttCandidatura.Size = new System.Drawing.Size(116, 23);
            this.btnAttCandidatura.TabIndex = 12;
            this.btnAttCandidatura.Text = "Atualizar Candidatura";
            this.btnAttCandidatura.UseVisualStyleBackColor = true;
            // 
            // btnExcluirCandidatura
            // 
            this.btnExcluirCandidatura.Location = new System.Drawing.Point(12, 475);
            this.btnExcluirCandidatura.Name = "btnExcluirCandidatura";
            this.btnExcluirCandidatura.Size = new System.Drawing.Size(116, 23);
            this.btnExcluirCandidatura.TabIndex = 13;
            this.btnExcluirCandidatura.Text = "Excluir Candidatura";
            this.btnExcluirCandidatura.UseVisualStyleBackColor = true;
            // 
            // btnListarCandidaturas
            // 
            this.btnListarCandidaturas.Location = new System.Drawing.Point(12, 504);
            this.btnListarCandidaturas.Name = "btnListarCandidaturas";
            this.btnListarCandidaturas.Size = new System.Drawing.Size(116, 23);
            this.btnListarCandidaturas.TabIndex = 14;
            this.btnListarCandidaturas.Text = "Listar Candidaturas";
            this.btnListarCandidaturas.UseVisualStyleBackColor = true;
            // 
            // campoPesquisarEmpresa
            // 
            this.campoPesquisarEmpresa.Location = new System.Drawing.Point(1074, 15);
            this.campoPesquisarEmpresa.Name = "campoPesquisarEmpresa";
            this.campoPesquisarEmpresa.Size = new System.Drawing.Size(291, 20);
            this.campoPesquisarEmpresa.TabIndex = 15;
            this.campoPesquisarEmpresa.TextChanged += new System.EventHandler(this.campoPesquisarEmpresa_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(971, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Pesquisar Empresa";
            // 
            // Vagas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1542, 709);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.campoPesquisarEmpresa);
            this.Controls.Add(this.btnListarCandidaturas);
            this.Controls.Add(this.btnExcluirCandidatura);
            this.Controls.Add(this.btnAttCandidatura);
            this.Controls.Add(this.btnCandidatar);
            this.Controls.Add(this.btnListarEmpresas);
            this.Controls.Add(this.btnDesassociarCandidato);
            this.Controls.Add(this.btnAssociarCandidato);
            this.Controls.Add(this.btnBuscarCandidato);
            this.Controls.Add(this.btnListarCandidatos);
            this.Controls.Add(this.btnDeletarVaga);
            this.Controls.Add(this.btnEditarVaga);
            this.Controls.Add(this.GridOportunidades);
            this.Controls.Add(this.btnCadastrarVaga);
            this.Name = "Vagas";
            this.ShowIcon = false;
            this.Text = "Vagas";
            ((System.ComponentModel.ISupportInitialize)(this.GridOportunidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarVaga;
        private System.Windows.Forms.DataGridView GridOportunidades;
        private System.Windows.Forms.Button btnEditarVaga;
        private System.Windows.Forms.Button btnDeletarVaga;
        private System.Windows.Forms.Button btnListarCandidatos;
        private System.Windows.Forms.Button btnBuscarCandidato;
        private System.Windows.Forms.Button btnAssociarCandidato;
        private System.Windows.Forms.Button btnDesassociarCandidato;
        private System.Windows.Forms.Button btnListarEmpresas;
        private System.Windows.Forms.Button btnCandidatar;
        private System.Windows.Forms.Button btnAttCandidatura;
        private System.Windows.Forms.Button btnExcluirCandidatura;
        private System.Windows.Forms.Button btnListarCandidaturas;
        private System.Windows.Forms.TextBox campoPesquisarEmpresa;
        private System.Windows.Forms.Label label1;
    }
}