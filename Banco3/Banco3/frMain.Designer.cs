namespace Banco3
{
    partial class frMain
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
            this.btnCadTrm = new System.Windows.Forms.Button();
            this.btnCadPfe = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTerminalCadastrado = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acessoAoBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periféricosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadTrm
            // 
            this.btnCadTrm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCadTrm.Location = new System.Drawing.Point(76, 166);
            this.btnCadTrm.Name = "btnCadTrm";
            this.btnCadTrm.Size = new System.Drawing.Size(70, 70);
            this.btnCadTrm.TabIndex = 1;
            this.btnCadTrm.Text = "&Terminais";
            this.btnCadTrm.UseVisualStyleBackColor = true;
            this.btnCadTrm.Click += new System.EventHandler(this.btnCadTrm_Click);
            // 
            // btnCadPfe
            // 
            this.btnCadPfe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCadPfe.Location = new System.Drawing.Point(0, 166);
            this.btnCadPfe.Name = "btnCadPfe";
            this.btnCadPfe.Size = new System.Drawing.Size(70, 70);
            this.btnCadPfe.TabIndex = 0;
            this.btnCadPfe.Text = "&Periféricos";
            this.btnCadPfe.UseVisualStyleBackColor = true;
            this.btnCadPfe.Click += new System.EventHandler(this.btnCadPfe_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTerminalCadastrado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelTerminalCadastrado
            // 
            this.toolStripStatusLabelTerminalCadastrado.Name = "toolStripStatusLabelTerminalCadastrado";
            this.toolStripStatusLabelTerminalCadastrado.Size = new System.Drawing.Size(85, 17);
            this.toolStripStatusLabelTerminalCadastrado.Text = "Terminal: xxxxx";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.configuraçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.periféricosToolStripMenuItem,
            this.terminaisToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acessoAoBDToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // acessoAoBDToolStripMenuItem
            // 
            this.acessoAoBDToolStripMenuItem.Name = "acessoAoBDToolStripMenuItem";
            this.acessoAoBDToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.acessoAoBDToolStripMenuItem.Text = "Acesso ao BD";
            this.acessoAoBDToolStripMenuItem.Click += new System.EventHandler(this.acessoAoBDToolStripMenuItem_Click);
            // 
            // periféricosToolStripMenuItem
            // 
            this.periféricosToolStripMenuItem.Name = "periféricosToolStripMenuItem";
            this.periféricosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.periféricosToolStripMenuItem.Text = "Periféricos";
            this.periféricosToolStripMenuItem.Click += new System.EventHandler(this.periféricosToolStripMenuItem_Click);
            // 
            // terminaisToolStripMenuItem
            // 
            this.terminaisToolStripMenuItem.Name = "terminaisToolStripMenuItem";
            this.terminaisToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.terminaisToolStripMenuItem.Text = "Terminais";
            this.terminaisToolStripMenuItem.Click += new System.EventHandler(this.terminaisToolStripMenuItem_Click);
            // 
            // frMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnCadPfe);
            this.Controls.Add(this.btnCadTrm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "frMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadTrm;
        private System.Windows.Forms.Button btnCadPfe;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTerminalCadastrado;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem periféricosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acessoAoBDToolStripMenuItem;
    }
}