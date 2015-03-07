namespace Banco3
{
    partial class frCadTrm
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTerminais1 = new System.Windows.Forms.TabPage();
            this.btnPageTerminaisProximo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTrm_Tip = new System.Windows.Forms.ComboBox();
            this.txtTrm_Dmn = new System.Windows.Forms.TextBox();
            this.txtTrm_Nom = new System.Windows.Forms.TextBox();
            this.txtTrm_Idt = new System.Windows.Forms.TextBox();
            this.tabTerminais2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPageTerminaisAnterior = new System.Windows.Forms.Button();
            this.btnTestarCOM8 = new System.Windows.Forms.Button();
            this.cbPeriferico8 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbTipoPeriferico8 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnTestarCOM7 = new System.Windows.Forms.Button();
            this.cbPeriferico7 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbTipoPeriferico7 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnTestarCOM6 = new System.Windows.Forms.Button();
            this.cbPeriferico6 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbTipoPeriferico6 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnTestarCOM5 = new System.Windows.Forms.Button();
            this.cbPeriferico5 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbTipoPeriferico5 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnTestarCOM4 = new System.Windows.Forms.Button();
            this.cbPeriferico4 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbTipoPeriferico4 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnTestarCOM3 = new System.Windows.Forms.Button();
            this.cbPeriferico3 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbTipoPeriferico3 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnTestarCOM2 = new System.Windows.Forms.Button();
            this.cbPeriferico2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTipoPeriferico2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTestarCOM1 = new System.Windows.Forms.Button();
            this.cbPeriferico1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTipoPeriferico1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabTerminalPeriferico = new System.Windows.Forms.TabPage();
            this.gridAssociados = new System.Windows.Forms.DataGridView();
            this.gridDesassociados = new System.Windows.Forms.DataGridView();
            this.btnDesassociarTodos = new System.Windows.Forms.Button();
            this.btnDesassociarUm = new System.Windows.Forms.Button();
            this.btnAssociarUm = new System.Windows.Forms.Button();
            this.btnAssociarTodos = new System.Windows.Forms.Button();
            this.gridTerminais = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabTerminais1.SuspendLayout();
            this.tabTerminais2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabTerminalPeriferico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAssociados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDesassociados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTerminais)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPort1_ErrorReceived);
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnSair);
            this.splitContainer1.Panel2.Controls.Add(this.button7);
            this.splitContainer1.Panel2.Controls.Add(this.btnPesquisar);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel2.Controls.Add(this.btnCopiar);
            this.splitContainer1.Panel2.Controls.Add(this.btnRemover);
            this.splitContainer1.Panel2.Controls.Add(this.btnAlterar);
            this.splitContainer1.Panel2.Controls.Add(this.btnIncluir);
            this.splitContainer1.Size = new System.Drawing.Size(784, 561);
            this.splitContainer1.SplitterDistance = 487;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gridTerminais);
            this.splitContainer2.Size = new System.Drawing.Size(784, 487);
            this.splitContainer2.SplitterDistance = 261;
            this.splitContainer2.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTerminais1);
            this.tabControl1.Controls.Add(this.tabTerminais2);
            this.tabControl1.Controls.Add(this.tabTerminalPeriferico);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 261);
            this.tabControl1.TabIndex = 1;
            // 
            // tabTerminais1
            // 
            this.tabTerminais1.Controls.Add(this.btnPageTerminaisProximo);
            this.tabTerminais1.Controls.Add(this.label3);
            this.tabTerminais1.Controls.Add(this.label4);
            this.tabTerminais1.Controls.Add(this.label2);
            this.tabTerminais1.Controls.Add(this.label1);
            this.tabTerminais1.Controls.Add(this.cbTrm_Tip);
            this.tabTerminais1.Controls.Add(this.txtTrm_Dmn);
            this.tabTerminais1.Controls.Add(this.txtTrm_Nom);
            this.tabTerminais1.Controls.Add(this.txtTrm_Idt);
            this.tabTerminais1.Location = new System.Drawing.Point(4, 22);
            this.tabTerminais1.Name = "tabTerminais1";
            this.tabTerminais1.Padding = new System.Windows.Forms.Padding(3);
            this.tabTerminais1.Size = new System.Drawing.Size(776, 235);
            this.tabTerminais1.TabIndex = 0;
            this.tabTerminais1.Text = "Terminais";
            this.tabTerminais1.UseVisualStyleBackColor = true;
            // 
            // btnPageTerminaisProximo
            // 
            this.btnPageTerminaisProximo.Location = new System.Drawing.Point(570, 199);
            this.btnPageTerminaisProximo.Name = "btnPageTerminaisProximo";
            this.btnPageTerminaisProximo.Size = new System.Drawing.Size(60, 30);
            this.btnPageTerminaisProximo.TabIndex = 9;
            this.btnPageTerminaisProximo.Text = ">";
            this.btnPageTerminaisProximo.UseVisualStyleBackColor = true;
            this.btnPageTerminaisProximo.Click += new System.EventHandler(this.btnPageTerminaisProximo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "IP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código:";
            // 
            // cbTrm_Tip
            // 
            this.cbTrm_Tip.FormattingEnabled = true;
            this.cbTrm_Tip.Location = new System.Drawing.Point(403, 66);
            this.cbTrm_Tip.Name = "cbTrm_Tip";
            this.cbTrm_Tip.Size = new System.Drawing.Size(121, 21);
            this.cbTrm_Tip.TabIndex = 3;
            // 
            // txtTrm_Dmn
            // 
            this.txtTrm_Dmn.Location = new System.Drawing.Point(68, 66);
            this.txtTrm_Dmn.Name = "txtTrm_Dmn";
            this.txtTrm_Dmn.Size = new System.Drawing.Size(100, 20);
            this.txtTrm_Dmn.TabIndex = 2;
            // 
            // txtTrm_Nom
            // 
            this.txtTrm_Nom.Location = new System.Drawing.Point(403, 23);
            this.txtTrm_Nom.Name = "txtTrm_Nom";
            this.txtTrm_Nom.Size = new System.Drawing.Size(100, 20);
            this.txtTrm_Nom.TabIndex = 1;
            // 
            // txtTrm_Idt
            // 
            this.txtTrm_Idt.Location = new System.Drawing.Point(68, 23);
            this.txtTrm_Idt.Name = "txtTrm_Idt";
            this.txtTrm_Idt.Size = new System.Drawing.Size(100, 20);
            this.txtTrm_Idt.TabIndex = 0;
            // 
            // tabTerminais2
            // 
            this.tabTerminais2.Controls.Add(this.groupBox1);
            this.tabTerminais2.Location = new System.Drawing.Point(4, 22);
            this.tabTerminais2.Name = "tabTerminais2";
            this.tabTerminais2.Padding = new System.Windows.Forms.Padding(3);
            this.tabTerminais2.Size = new System.Drawing.Size(776, 235);
            this.tabTerminais2.TabIndex = 2;
            this.tabTerminais2.Text = "Terminais";
            this.tabTerminais2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPageTerminaisAnterior);
            this.groupBox1.Controls.Add(this.btnTestarCOM8);
            this.groupBox1.Controls.Add(this.cbPeriferico8);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.cbTipoPeriferico8);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.btnTestarCOM7);
            this.groupBox1.Controls.Add(this.cbPeriferico7);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.cbTipoPeriferico7);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.btnTestarCOM6);
            this.groupBox1.Controls.Add(this.cbPeriferico6);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.cbTipoPeriferico6);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.btnTestarCOM5);
            this.groupBox1.Controls.Add(this.cbPeriferico5);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cbTipoPeriferico5);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.btnTestarCOM4);
            this.groupBox1.Controls.Add(this.cbPeriferico4);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cbTipoPeriferico4);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnTestarCOM3);
            this.groupBox1.Controls.Add(this.cbPeriferico3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbTipoPeriferico3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnTestarCOM2);
            this.groupBox1.Controls.Add(this.cbPeriferico2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbTipoPeriferico2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnTestarCOM1);
            this.groupBox1.Controls.Add(this.cbPeriferico1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbTipoPeriferico1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 229);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comunicação Serial";
            // 
            // btnPageTerminaisAnterior
            // 
            this.btnPageTerminaisAnterior.Location = new System.Drawing.Point(570, 199);
            this.btnPageTerminaisAnterior.Name = "btnPageTerminaisAnterior";
            this.btnPageTerminaisAnterior.Size = new System.Drawing.Size(60, 30);
            this.btnPageTerminaisAnterior.TabIndex = 40;
            this.btnPageTerminaisAnterior.Text = "<";
            this.btnPageTerminaisAnterior.UseVisualStyleBackColor = true;
            this.btnPageTerminaisAnterior.Click += new System.EventHandler(this.btnPageTerminaisAnterior_Click);
            // 
            // btnTestarCOM8
            // 
            this.btnTestarCOM8.Location = new System.Drawing.Point(488, 200);
            this.btnTestarCOM8.Name = "btnTestarCOM8";
            this.btnTestarCOM8.Size = new System.Drawing.Size(75, 23);
            this.btnTestarCOM8.TabIndex = 39;
            this.btnTestarCOM8.Text = "Testar";
            this.btnTestarCOM8.UseVisualStyleBackColor = true;
            this.btnTestarCOM8.Click += new System.EventHandler(this.btnTestarCOM1_Click);
            // 
            // cbPeriferico8
            // 
            this.cbPeriferico8.FormattingEnabled = true;
            this.cbPeriferico8.Location = new System.Drawing.Point(320, 202);
            this.cbPeriferico8.Name = "cbPeriferico8";
            this.cbPeriferico8.Size = new System.Drawing.Size(121, 21);
            this.cbPeriferico8.TabIndex = 38;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(243, 205);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 13);
            this.label19.TabIndex = 37;
            this.label19.Text = "Periférico:";
            // 
            // cbTipoPeriferico8
            // 
            this.cbTipoPeriferico8.FormattingEnabled = true;
            this.cbTipoPeriferico8.Location = new System.Drawing.Point(55, 202);
            this.cbTipoPeriferico8.Name = "cbTipoPeriferico8";
            this.cbTipoPeriferico8.Size = new System.Drawing.Size(121, 21);
            this.cbTipoPeriferico8.TabIndex = 36;
            this.cbTipoPeriferico8.SelectedIndexChanged += new System.EventHandler(this.cbTipoPeriferico1_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 205);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 13);
            this.label20.TabIndex = 35;
            this.label20.Text = "COM8:";
            // 
            // btnTestarCOM7
            // 
            this.btnTestarCOM7.Location = new System.Drawing.Point(488, 173);
            this.btnTestarCOM7.Name = "btnTestarCOM7";
            this.btnTestarCOM7.Size = new System.Drawing.Size(75, 23);
            this.btnTestarCOM7.TabIndex = 34;
            this.btnTestarCOM7.Text = "Testar";
            this.btnTestarCOM7.UseVisualStyleBackColor = true;
            this.btnTestarCOM7.Click += new System.EventHandler(this.btnTestarCOM1_Click);
            // 
            // cbPeriferico7
            // 
            this.cbPeriferico7.FormattingEnabled = true;
            this.cbPeriferico7.Location = new System.Drawing.Point(320, 175);
            this.cbPeriferico7.Name = "cbPeriferico7";
            this.cbPeriferico7.Size = new System.Drawing.Size(121, 21);
            this.cbPeriferico7.TabIndex = 33;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(243, 178);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Periférico:";
            // 
            // cbTipoPeriferico7
            // 
            this.cbTipoPeriferico7.FormattingEnabled = true;
            this.cbTipoPeriferico7.Location = new System.Drawing.Point(55, 175);
            this.cbTipoPeriferico7.Name = "cbTipoPeriferico7";
            this.cbTipoPeriferico7.Size = new System.Drawing.Size(121, 21);
            this.cbTipoPeriferico7.TabIndex = 31;
            this.cbTipoPeriferico7.SelectedIndexChanged += new System.EventHandler(this.cbTipoPeriferico1_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 178);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 13);
            this.label18.TabIndex = 30;
            this.label18.Text = "COM7:";
            // 
            // btnTestarCOM6
            // 
            this.btnTestarCOM6.Location = new System.Drawing.Point(488, 146);
            this.btnTestarCOM6.Name = "btnTestarCOM6";
            this.btnTestarCOM6.Size = new System.Drawing.Size(75, 23);
            this.btnTestarCOM6.TabIndex = 29;
            this.btnTestarCOM6.Text = "Testar";
            this.btnTestarCOM6.UseVisualStyleBackColor = true;
            this.btnTestarCOM6.Click += new System.EventHandler(this.btnTestarCOM1_Click);
            // 
            // cbPeriferico6
            // 
            this.cbPeriferico6.FormattingEnabled = true;
            this.cbPeriferico6.Location = new System.Drawing.Point(320, 148);
            this.cbPeriferico6.Name = "cbPeriferico6";
            this.cbPeriferico6.Size = new System.Drawing.Size(121, 21);
            this.cbPeriferico6.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(243, 151);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Periférico:";
            // 
            // cbTipoPeriferico6
            // 
            this.cbTipoPeriferico6.FormattingEnabled = true;
            this.cbTipoPeriferico6.Location = new System.Drawing.Point(55, 148);
            this.cbTipoPeriferico6.Name = "cbTipoPeriferico6";
            this.cbTipoPeriferico6.Size = new System.Drawing.Size(121, 21);
            this.cbTipoPeriferico6.TabIndex = 26;
            this.cbTipoPeriferico6.SelectedIndexChanged += new System.EventHandler(this.cbTipoPeriferico1_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 151);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "COM6:";
            // 
            // btnTestarCOM5
            // 
            this.btnTestarCOM5.Location = new System.Drawing.Point(488, 119);
            this.btnTestarCOM5.Name = "btnTestarCOM5";
            this.btnTestarCOM5.Size = new System.Drawing.Size(75, 23);
            this.btnTestarCOM5.TabIndex = 24;
            this.btnTestarCOM5.Text = "Testar";
            this.btnTestarCOM5.UseVisualStyleBackColor = true;
            this.btnTestarCOM5.Click += new System.EventHandler(this.btnTestarCOM1_Click);
            // 
            // cbPeriferico5
            // 
            this.cbPeriferico5.FormattingEnabled = true;
            this.cbPeriferico5.Location = new System.Drawing.Point(320, 121);
            this.cbPeriferico5.Name = "cbPeriferico5";
            this.cbPeriferico5.Size = new System.Drawing.Size(121, 21);
            this.cbPeriferico5.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(243, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Periférico:";
            // 
            // cbTipoPeriferico5
            // 
            this.cbTipoPeriferico5.FormattingEnabled = true;
            this.cbTipoPeriferico5.Location = new System.Drawing.Point(55, 121);
            this.cbTipoPeriferico5.Name = "cbTipoPeriferico5";
            this.cbTipoPeriferico5.Size = new System.Drawing.Size(121, 21);
            this.cbTipoPeriferico5.TabIndex = 21;
            this.cbTipoPeriferico5.SelectedIndexChanged += new System.EventHandler(this.cbTipoPeriferico1_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 124);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "COM5:";
            // 
            // btnTestarCOM4
            // 
            this.btnTestarCOM4.Location = new System.Drawing.Point(488, 92);
            this.btnTestarCOM4.Name = "btnTestarCOM4";
            this.btnTestarCOM4.Size = new System.Drawing.Size(75, 23);
            this.btnTestarCOM4.TabIndex = 19;
            this.btnTestarCOM4.Text = "Testar";
            this.btnTestarCOM4.UseVisualStyleBackColor = true;
            this.btnTestarCOM4.Click += new System.EventHandler(this.btnTestarCOM1_Click);
            // 
            // cbPeriferico4
            // 
            this.cbPeriferico4.FormattingEnabled = true;
            this.cbPeriferico4.Location = new System.Drawing.Point(320, 94);
            this.cbPeriferico4.Name = "cbPeriferico4";
            this.cbPeriferico4.Size = new System.Drawing.Size(121, 21);
            this.cbPeriferico4.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(243, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Periférico:";
            // 
            // cbTipoPeriferico4
            // 
            this.cbTipoPeriferico4.FormattingEnabled = true;
            this.cbTipoPeriferico4.Location = new System.Drawing.Point(55, 94);
            this.cbTipoPeriferico4.Name = "cbTipoPeriferico4";
            this.cbTipoPeriferico4.Size = new System.Drawing.Size(121, 21);
            this.cbTipoPeriferico4.TabIndex = 16;
            this.cbTipoPeriferico4.SelectedIndexChanged += new System.EventHandler(this.cbTipoPeriferico1_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "COM4:";
            // 
            // btnTestarCOM3
            // 
            this.btnTestarCOM3.Location = new System.Drawing.Point(488, 65);
            this.btnTestarCOM3.Name = "btnTestarCOM3";
            this.btnTestarCOM3.Size = new System.Drawing.Size(75, 23);
            this.btnTestarCOM3.TabIndex = 14;
            this.btnTestarCOM3.Text = "Testar";
            this.btnTestarCOM3.UseVisualStyleBackColor = true;
            this.btnTestarCOM3.Click += new System.EventHandler(this.btnTestarCOM1_Click);
            // 
            // cbPeriferico3
            // 
            this.cbPeriferico3.FormattingEnabled = true;
            this.cbPeriferico3.Location = new System.Drawing.Point(320, 67);
            this.cbPeriferico3.Name = "cbPeriferico3";
            this.cbPeriferico3.Size = new System.Drawing.Size(121, 21);
            this.cbPeriferico3.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(243, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Periférico:";
            // 
            // cbTipoPeriferico3
            // 
            this.cbTipoPeriferico3.FormattingEnabled = true;
            this.cbTipoPeriferico3.Location = new System.Drawing.Point(55, 67);
            this.cbTipoPeriferico3.Name = "cbTipoPeriferico3";
            this.cbTipoPeriferico3.Size = new System.Drawing.Size(121, 21);
            this.cbTipoPeriferico3.TabIndex = 11;
            this.cbTipoPeriferico3.SelectedIndexChanged += new System.EventHandler(this.cbTipoPeriferico1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "COM3:";
            // 
            // btnTestarCOM2
            // 
            this.btnTestarCOM2.Location = new System.Drawing.Point(488, 38);
            this.btnTestarCOM2.Name = "btnTestarCOM2";
            this.btnTestarCOM2.Size = new System.Drawing.Size(75, 23);
            this.btnTestarCOM2.TabIndex = 9;
            this.btnTestarCOM2.Text = "Testar";
            this.btnTestarCOM2.UseVisualStyleBackColor = true;
            this.btnTestarCOM2.Click += new System.EventHandler(this.btnTestarCOM1_Click);
            // 
            // cbPeriferico2
            // 
            this.cbPeriferico2.FormattingEnabled = true;
            this.cbPeriferico2.Location = new System.Drawing.Point(320, 40);
            this.cbPeriferico2.Name = "cbPeriferico2";
            this.cbPeriferico2.Size = new System.Drawing.Size(121, 21);
            this.cbPeriferico2.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(243, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Periférico:";
            // 
            // cbTipoPeriferico2
            // 
            this.cbTipoPeriferico2.FormattingEnabled = true;
            this.cbTipoPeriferico2.Location = new System.Drawing.Point(55, 40);
            this.cbTipoPeriferico2.Name = "cbTipoPeriferico2";
            this.cbTipoPeriferico2.Size = new System.Drawing.Size(121, 21);
            this.cbTipoPeriferico2.TabIndex = 6;
            this.cbTipoPeriferico2.SelectedIndexChanged += new System.EventHandler(this.cbTipoPeriferico1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "COM2:";
            // 
            // btnTestarCOM1
            // 
            this.btnTestarCOM1.Location = new System.Drawing.Point(488, 11);
            this.btnTestarCOM1.Name = "btnTestarCOM1";
            this.btnTestarCOM1.Size = new System.Drawing.Size(75, 23);
            this.btnTestarCOM1.TabIndex = 4;
            this.btnTestarCOM1.Text = "Testar";
            this.btnTestarCOM1.UseVisualStyleBackColor = true;
            this.btnTestarCOM1.Click += new System.EventHandler(this.btnTestarCOM1_Click);
            // 
            // cbPeriferico1
            // 
            this.cbPeriferico1.FormattingEnabled = true;
            this.cbPeriferico1.Location = new System.Drawing.Point(320, 13);
            this.cbPeriferico1.Name = "cbPeriferico1";
            this.cbPeriferico1.Size = new System.Drawing.Size(121, 21);
            this.cbPeriferico1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Periférico:";
            // 
            // cbTipoPeriferico1
            // 
            this.cbTipoPeriferico1.FormattingEnabled = true;
            this.cbTipoPeriferico1.Location = new System.Drawing.Point(55, 13);
            this.cbTipoPeriferico1.Name = "cbTipoPeriferico1";
            this.cbTipoPeriferico1.Size = new System.Drawing.Size(121, 21);
            this.cbTipoPeriferico1.TabIndex = 1;
            this.cbTipoPeriferico1.SelectedIndexChanged += new System.EventHandler(this.cbTipoPeriferico1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "COM1:";
            // 
            // tabTerminalPeriferico
            // 
            this.tabTerminalPeriferico.Controls.Add(this.gridAssociados);
            this.tabTerminalPeriferico.Controls.Add(this.gridDesassociados);
            this.tabTerminalPeriferico.Controls.Add(this.btnDesassociarTodos);
            this.tabTerminalPeriferico.Controls.Add(this.btnDesassociarUm);
            this.tabTerminalPeriferico.Controls.Add(this.btnAssociarUm);
            this.tabTerminalPeriferico.Controls.Add(this.btnAssociarTodos);
            this.tabTerminalPeriferico.Location = new System.Drawing.Point(4, 22);
            this.tabTerminalPeriferico.Name = "tabTerminalPeriferico";
            this.tabTerminalPeriferico.Padding = new System.Windows.Forms.Padding(3);
            this.tabTerminalPeriferico.Size = new System.Drawing.Size(776, 235);
            this.tabTerminalPeriferico.TabIndex = 1;
            this.tabTerminalPeriferico.Text = "Terminal X Periférico";
            this.tabTerminalPeriferico.UseVisualStyleBackColor = true;
            // 
            // gridAssociados
            // 
            this.gridAssociados.AllowUserToAddRows = false;
            this.gridAssociados.AllowUserToDeleteRows = false;
            this.gridAssociados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAssociados.Location = new System.Drawing.Point(414, 7);
            this.gridAssociados.Name = "gridAssociados";
            this.gridAssociados.ReadOnly = true;
            this.gridAssociados.Size = new System.Drawing.Size(278, 225);
            this.gridAssociados.TabIndex = 7;
            this.gridAssociados.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridDesassociados_CellMouseDoubleClick);
            // 
            // gridDesassociados
            // 
            this.gridDesassociados.AllowUserToAddRows = false;
            this.gridDesassociados.AllowUserToDeleteRows = false;
            this.gridDesassociados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDesassociados.Location = new System.Drawing.Point(8, 7);
            this.gridDesassociados.Name = "gridDesassociados";
            this.gridDesassociados.ReadOnly = true;
            this.gridDesassociados.Size = new System.Drawing.Size(278, 225);
            this.gridDesassociados.TabIndex = 6;
            this.gridDesassociados.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridDesassociados_CellMouseDoubleClick);
            // 
            // btnDesassociarTodos
            // 
            this.btnDesassociarTodos.Location = new System.Drawing.Point(323, 175);
            this.btnDesassociarTodos.Name = "btnDesassociarTodos";
            this.btnDesassociarTodos.Size = new System.Drawing.Size(50, 50);
            this.btnDesassociarTodos.TabIndex = 5;
            this.btnDesassociarTodos.Text = "<<";
            this.btnDesassociarTodos.UseVisualStyleBackColor = true;
            this.btnDesassociarTodos.Click += new System.EventHandler(this.btnDesassociarTodos_Click);
            // 
            // btnDesassociarUm
            // 
            this.btnDesassociarUm.Location = new System.Drawing.Point(323, 119);
            this.btnDesassociarUm.Name = "btnDesassociarUm";
            this.btnDesassociarUm.Size = new System.Drawing.Size(50, 50);
            this.btnDesassociarUm.TabIndex = 4;
            this.btnDesassociarUm.Text = "<";
            this.btnDesassociarUm.UseVisualStyleBackColor = true;
            this.btnDesassociarUm.Click += new System.EventHandler(this.btnDesassociarUm_Click);
            // 
            // btnAssociarUm
            // 
            this.btnAssociarUm.Location = new System.Drawing.Point(323, 63);
            this.btnAssociarUm.Name = "btnAssociarUm";
            this.btnAssociarUm.Size = new System.Drawing.Size(50, 50);
            this.btnAssociarUm.TabIndex = 3;
            this.btnAssociarUm.Text = ">";
            this.btnAssociarUm.UseVisualStyleBackColor = true;
            this.btnAssociarUm.Click += new System.EventHandler(this.btnAssociarUm_Click);
            // 
            // btnAssociarTodos
            // 
            this.btnAssociarTodos.Location = new System.Drawing.Point(323, 7);
            this.btnAssociarTodos.Name = "btnAssociarTodos";
            this.btnAssociarTodos.Size = new System.Drawing.Size(50, 50);
            this.btnAssociarTodos.TabIndex = 2;
            this.btnAssociarTodos.Text = ">>";
            this.btnAssociarTodos.UseVisualStyleBackColor = true;
            this.btnAssociarTodos.Click += new System.EventHandler(this.btnAssociarTodos_Click);
            // 
            // gridTerminais
            // 
            this.gridTerminais.AllowUserToAddRows = false;
            this.gridTerminais.AllowUserToDeleteRows = false;
            this.gridTerminais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTerminais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTerminais.Location = new System.Drawing.Point(0, 0);
            this.gridTerminais.Name = "gridTerminais";
            this.gridTerminais.ReadOnly = true;
            this.gridTerminais.Size = new System.Drawing.Size(784, 222);
            this.gridTerminais.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(525, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(70, 70);
            this.btnSair.TabIndex = 16;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(450, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 70);
            this.button7.TabIndex = 15;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(375, 0);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(70, 70);
            this.btnPesquisar.TabIndex = 14;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(300, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(70, 70);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(225, 0);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(70, 70);
            this.btnCopiar.TabIndex = 12;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(150, 0);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(70, 70);
            this.btnRemover.TabIndex = 11;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(75, 0);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(70, 70);
            this.btnAlterar.TabIndex = 10;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(0, 0);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(70, 70);
            this.btnIncluir.TabIndex = 9;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // frCadTrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frCadTrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Terminais";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabTerminais1.ResumeLayout(false);
            this.tabTerminais1.PerformLayout();
            this.tabTerminais2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabTerminalPeriferico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAssociados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDesassociados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTerminais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTerminais1;
        private System.Windows.Forms.TabPage tabTerminalPeriferico;
        private System.Windows.Forms.DataGridView gridTerminais;
        private System.Windows.Forms.TextBox txtTrm_Dmn;
        private System.Windows.Forms.TextBox txtTrm_Nom;
        private System.Windows.Forms.TextBox txtTrm_Idt;
        private System.Windows.Forms.ComboBox cbTrm_Tip;
        private System.Windows.Forms.Button btnPageTerminaisProximo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabTerminais2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTestarCOM8;
        private System.Windows.Forms.ComboBox cbPeriferico8;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbTipoPeriferico8;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnTestarCOM7;
        private System.Windows.Forms.ComboBox cbPeriferico7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbTipoPeriferico7;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnTestarCOM6;
        private System.Windows.Forms.ComboBox cbPeriferico6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbTipoPeriferico6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnTestarCOM5;
        private System.Windows.Forms.ComboBox cbPeriferico5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbTipoPeriferico5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnTestarCOM4;
        private System.Windows.Forms.ComboBox cbPeriferico4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbTipoPeriferico4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnTestarCOM3;
        private System.Windows.Forms.ComboBox cbPeriferico3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbTipoPeriferico3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnTestarCOM2;
        private System.Windows.Forms.ComboBox cbPeriferico2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTipoPeriferico2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTestarCOM1;
        private System.Windows.Forms.ComboBox cbPeriferico1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTipoPeriferico1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDesassociarTodos;
        private System.Windows.Forms.Button btnDesassociarUm;
        private System.Windows.Forms.Button btnAssociarUm;
        private System.Windows.Forms.Button btnAssociarTodos;
        private System.Windows.Forms.DataGridView gridAssociados;
        private System.Windows.Forms.DataGridView gridDesassociados;
        private System.Windows.Forms.Button btnPageTerminaisAnterior;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
    }
}

