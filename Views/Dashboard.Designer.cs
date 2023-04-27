namespace CareerConnect.Views
{
    partial class Dashboard
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
            this.PainelSidebar = new System.Windows.Forms.Panel();
            this.btnSair = new FontAwesome.Sharp.IconButton();
            this.btnOpcoes = new FontAwesome.Sharp.IconButton();
            this.btnChat = new FontAwesome.Sharp.IconButton();
            this.btnOportunidades = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.PainelLogo = new System.Windows.Forms.Panel();
            this.PainelNavbar = new System.Windows.Forms.Panel();
            this.painelShadow = new System.Windows.Forms.Panel();
            this.painelDesktop = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.PainelSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PainelSidebar
            // 
            this.PainelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.PainelSidebar.Controls.Add(this.iconButton1);
            this.PainelSidebar.Controls.Add(this.btnSair);
            this.PainelSidebar.Controls.Add(this.btnOpcoes);
            this.PainelSidebar.Controls.Add(this.btnChat);
            this.PainelSidebar.Controls.Add(this.btnOportunidades);
            this.PainelSidebar.Controls.Add(this.btnDashboard);
            this.PainelSidebar.Controls.Add(this.PainelLogo);
            this.PainelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PainelSidebar.Location = new System.Drawing.Point(0, 0);
            this.PainelSidebar.Name = "PainelSidebar";
            this.PainelSidebar.Size = new System.Drawing.Size(220, 838);
            this.PainelSidebar.TabIndex = 0;
            this.PainelSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.PainelSidebar_Paint);
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSair.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnSair.IconColor = System.Drawing.Color.White;
            this.btnSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSair.IconSize = 32;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(0, 778);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSair.Size = new System.Drawing.Size(220, 60);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // btnOpcoes
            // 
            this.btnOpcoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpcoes.FlatAppearance.BorderSize = 0;
            this.btnOpcoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpcoes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOpcoes.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.btnOpcoes.IconColor = System.Drawing.Color.White;
            this.btnOpcoes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOpcoes.IconSize = 32;
            this.btnOpcoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpcoes.Location = new System.Drawing.Point(0, 320);
            this.btnOpcoes.Name = "btnOpcoes";
            this.btnOpcoes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnOpcoes.Size = new System.Drawing.Size(220, 60);
            this.btnOpcoes.TabIndex = 4;
            this.btnOpcoes.Text = "Opções";
            this.btnOpcoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpcoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpcoes.UseVisualStyleBackColor = true;
            this.btnOpcoes.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // btnChat
            // 
            this.btnChat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChat.FlatAppearance.BorderSize = 0;
            this.btnChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChat.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnChat.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.btnChat.IconColor = System.Drawing.Color.White;
            this.btnChat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChat.IconSize = 32;
            this.btnChat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChat.Location = new System.Drawing.Point(0, 260);
            this.btnChat.Name = "btnChat";
            this.btnChat.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnChat.Size = new System.Drawing.Size(220, 60);
            this.btnChat.TabIndex = 3;
            this.btnChat.Text = "Bate-papo";
            this.btnChat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChat.UseVisualStyleBackColor = true;
            this.btnChat.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // btnOportunidades
            // 
            this.btnOportunidades.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOportunidades.FlatAppearance.BorderSize = 0;
            this.btnOportunidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOportunidades.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOportunidades.IconChar = FontAwesome.Sharp.IconChar.Briefcase;
            this.btnOportunidades.IconColor = System.Drawing.Color.White;
            this.btnOportunidades.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOportunidades.IconSize = 32;
            this.btnOportunidades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOportunidades.Location = new System.Drawing.Point(0, 200);
            this.btnOportunidades.Name = "btnOportunidades";
            this.btnOportunidades.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnOportunidades.Size = new System.Drawing.Size(220, 60);
            this.btnOportunidades.TabIndex = 2;
            this.btnOportunidades.Text = "Oportunidades";
            this.btnOportunidades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOportunidades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOportunidades.UseVisualStyleBackColor = true;
            this.btnOportunidades.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnDashboard.IconColor = System.Drawing.Color.White;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 32;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 140);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDashboard.Size = new System.Drawing.Size(220, 60);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // PainelLogo
            // 
            this.PainelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PainelLogo.Location = new System.Drawing.Point(0, 0);
            this.PainelLogo.Name = "PainelLogo";
            this.PainelLogo.Size = new System.Drawing.Size(220, 140);
            this.PainelLogo.TabIndex = 0;
            this.PainelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.PainelLogo_Paint);
            // 
            // PainelNavbar
            // 
            this.PainelNavbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.PainelNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PainelNavbar.Location = new System.Drawing.Point(220, 0);
            this.PainelNavbar.Name = "PainelNavbar";
            this.PainelNavbar.Size = new System.Drawing.Size(1660, 80);
            this.PainelNavbar.TabIndex = 1;
            this.PainelNavbar.Paint += new System.Windows.Forms.PaintEventHandler(this.PainelNavbar_Paint);
            // 
            // painelShadow
            // 
            this.painelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.painelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelShadow.Location = new System.Drawing.Point(220, 80);
            this.painelShadow.Name = "painelShadow";
            this.painelShadow.Size = new System.Drawing.Size(1660, 9);
            this.painelShadow.TabIndex = 2;
            // 
            // painelDesktop
            // 
            this.painelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.painelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelDesktop.Location = new System.Drawing.Point(220, 89);
            this.painelDesktop.Name = "painelDesktop";
            this.painelDesktop.Size = new System.Drawing.Size(1660, 749);
            this.painelDesktop.TabIndex = 3;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 380);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Size = new System.Drawing.Size(220, 60);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.Text = "Painel Administrativo";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1880, 838);
            this.Controls.Add(this.painelDesktop);
            this.Controls.Add(this.painelShadow);
            this.Controls.Add(this.PainelNavbar);
            this.Controls.Add(this.PainelSidebar);
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.PainelSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PainelSidebar;
        private System.Windows.Forms.Panel PainelLogo;
        private FontAwesome.Sharp.IconButton btnSair;
        private FontAwesome.Sharp.IconButton btnOpcoes;
        private FontAwesome.Sharp.IconButton btnChat;
        private FontAwesome.Sharp.IconButton btnOportunidades;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private System.Windows.Forms.Panel PainelNavbar;
        private System.Windows.Forms.Panel painelShadow;
        private System.Windows.Forms.Panel painelDesktop;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}