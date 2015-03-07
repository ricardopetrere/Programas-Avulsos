namespace Banco1
{
    partial class frCad_Pes
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
            this.txtPes_nom = new System.Windows.Forms.TextBox();
            this.numPes_ida = new System.Windows.Forms.NumericUpDown();
            this.lblPes_nom = new System.Windows.Forms.Label();
            this.lblPes_ida = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.grpEndereco = new System.Windows.Forms.GroupBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPes_ida)).BeginInit();
            this.grpEndereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPes_nom
            // 
            this.txtPes_nom.Location = new System.Drawing.Point(107, 12);
            this.txtPes_nom.Name = "txtPes_nom";
            this.txtPes_nom.Size = new System.Drawing.Size(100, 20);
            this.txtPes_nom.TabIndex = 0;
            // 
            // numPes_ida
            // 
            this.numPes_ida.Location = new System.Drawing.Point(377, 12);
            this.numPes_ida.Name = "numPes_ida";
            this.numPes_ida.Size = new System.Drawing.Size(120, 20);
            this.numPes_ida.TabIndex = 1;
            // 
            // lblPes_nom
            // 
            this.lblPes_nom.AutoSize = true;
            this.lblPes_nom.Location = new System.Drawing.Point(13, 13);
            this.lblPes_nom.Name = "lblPes_nom";
            this.lblPes_nom.Size = new System.Drawing.Size(43, 13);
            this.lblPes_nom.TabIndex = 2;
            this.lblPes_nom.Tag = "2";
            this.lblPes_nom.Text = "Nomex:";
            // 
            // lblPes_ida
            // 
            this.lblPes_ida.AutoSize = true;
            this.lblPes_ida.Location = new System.Drawing.Point(258, 13);
            this.lblPes_ida.Name = "lblPes_ida";
            this.lblPes_ida.Size = new System.Drawing.Size(42, 13);
            this.lblPes_ida.TabIndex = 3;
            this.lblPes_ida.Tag = "3";
            this.lblPes_ida.Text = "Idadex:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(531, 291);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvarx";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // grpEndereco
            // 
            this.grpEndereco.Controls.Add(this.txtCEP);
            this.grpEndereco.Controls.Add(this.txtComplemento);
            this.grpEndereco.Controls.Add(this.txtBairro);
            this.grpEndereco.Controls.Add(this.txtNumero);
            this.grpEndereco.Controls.Add(this.txtRua);
            this.grpEndereco.Controls.Add(this.cbCidade);
            this.grpEndereco.Controls.Add(this.cbEstado);
            this.grpEndereco.Controls.Add(this.lblCEP);
            this.grpEndereco.Controls.Add(this.lblBairro);
            this.grpEndereco.Controls.Add(this.lblComplemento);
            this.grpEndereco.Controls.Add(this.lblNumero);
            this.grpEndereco.Controls.Add(this.lblRua);
            this.grpEndereco.Controls.Add(this.lblCidade);
            this.grpEndereco.Controls.Add(this.lblEstado);
            this.grpEndereco.Location = new System.Drawing.Point(16, 55);
            this.grpEndereco.Name = "grpEndereco";
            this.grpEndereco.Size = new System.Drawing.Size(590, 230);
            this.grpEndereco.TabIndex = 2;
            this.grpEndereco.TabStop = false;
            this.grpEndereco.Text = "Endereçox:";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(325, 100);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(100, 20);
            this.txtCEP.TabIndex = 13;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(423, 64);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(100, 20);
            this.txtComplemento.TabIndex = 11;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(55, 100);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(100, 20);
            this.txtBairro.TabIndex = 12;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(219, 64);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 10;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(48, 64);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(100, 20);
            this.txtRua.TabIndex = 9;
            // 
            // cbCidade
            // 
            this.cbCidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Location = new System.Drawing.Point(340, 17);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(243, 21);
            this.cbCidade.TabIndex = 8;
            // 
            // cbEstado
            // 
            this.cbEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(61, 17);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(170, 21);
            this.cbEstado.TabIndex = 7;
            this.cbEstado.SelectedValueChanged += new System.EventHandler(this.cbEstado_SelectedValueChanged);
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(283, 103);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(36, 13);
            this.lblCEP.TabIndex = 6;
            this.lblCEP.Text = "CEPx:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(7, 103);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(42, 13);
            this.lblBairro.TabIndex = 5;
            this.lblBairro.Text = "Bairrox:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(338, 67);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(79, 13);
            this.lblComplemento.TabIndex = 4;
            this.lblComplemento.Text = "Complementox:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(161, 67);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(52, 13);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Númerox:";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(7, 67);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(35, 13);
            this.lblRua.TabIndex = 2;
            this.lblRua.Text = "Ruax:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(286, 20);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(48, 13);
            this.lblCidade.TabIndex = 1;
            this.lblCidade.Text = "Cidadex:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(7, 20);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(48, 13);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "Estadox:";
            // 
            // frCad_Pes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 326);
            this.Controls.Add(this.grpEndereco);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblPes_ida);
            this.Controls.Add(this.lblPes_nom);
            this.Controls.Add(this.numPes_ida);
            this.Controls.Add(this.txtPes_nom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frCad_Pes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "1";
            this.Text = "Cadastro de Pessoax:";
            this.Load += new System.EventHandler(this.frCad_Pes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPes_ida)).EndInit();
            this.grpEndereco.ResumeLayout(false);
            this.grpEndereco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPes_nom;
        private System.Windows.Forms.NumericUpDown numPes_ida;
        private System.Windows.Forms.Label lblPes_nom;
        private System.Windows.Forms.Label lblPes_ida;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox grpEndereco;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEstado;
    }
}

