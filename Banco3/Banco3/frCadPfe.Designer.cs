namespace Banco3
{
    partial class frCadPfe
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbPfe_Baud_Rate_4800 = new System.Windows.Forms.RadioButton();
            this.rbPfe_Baud_Rate_9600 = new System.Windows.Forms.RadioButton();
            this.rbPfe_Baud_Rate_19200 = new System.Windows.Forms.RadioButton();
            this.rbPfe_Baud_Rate_38400 = new System.Windows.Forms.RadioButton();
            this.rbPfe_Baud_Rate_115200 = new System.Windows.Forms.RadioButton();
            this.rbPfe_Baud_Rate_57600 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbPfe_Data_Bits_7 = new System.Windows.Forms.RadioButton();
            this.rbPfe_Data_Bits_8 = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbPfe_Stop_Bits_2 = new System.Windows.Forms.RadioButton();
            this.rbPfe_Stop_Bits_1 = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbPfe_Par_Nenhum = new System.Windows.Forms.RadioButton();
            this.rbPfe_Par_Impar = new System.Windows.Forms.RadioButton();
            this.rbPfe_Par_Par = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPfe_IP = new System.Windows.Forms.TextBox();
            this.txtPfe_Prt = new System.Windows.Forms.TextBox();
            this.cbPfe_Tip = new System.Windows.Forms.ComboBox();
            this.txtPfe_Cod = new System.Windows.Forms.TextBox();
            this.txtPfe_Nom = new System.Windows.Forms.TextBox();
            this.cbPfe_Tip_Com = new System.Windows.Forms.ComboBox();
            this.gridPerifericos = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPerifericos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 300);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbPfe_Tip_Com);
            this.tabPage1.Controls.Add(this.txtPfe_Nom);
            this.tabPage1.Controls.Add(this.txtPfe_Cod);
            this.tabPage1.Controls.Add(this.cbPfe_Tip);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 274);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Periféricos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Comunicação:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(9, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 107);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPfe_Prt);
            this.groupBox2.Controls.Add(this.txtPfe_IP);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(9, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 62);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ethernet:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbPfe_Baud_Rate_115200);
            this.groupBox3.Controls.Add(this.rbPfe_Baud_Rate_57600);
            this.groupBox3.Controls.Add(this.rbPfe_Baud_Rate_38400);
            this.groupBox3.Controls.Add(this.rbPfe_Baud_Rate_19200);
            this.groupBox3.Controls.Add(this.rbPfe_Baud_Rate_9600);
            this.groupBox3.Controls.Add(this.rbPfe_Baud_Rate_4800);
            this.groupBox3.Location = new System.Drawing.Point(7, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 81);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Baud Rate:";
            // 
            // rbPfe_Baud_Rate_4800
            // 
            this.rbPfe_Baud_Rate_4800.AutoSize = true;
            this.rbPfe_Baud_Rate_4800.Location = new System.Drawing.Point(11, 20);
            this.rbPfe_Baud_Rate_4800.Name = "rbPfe_Baud_Rate_4800";
            this.rbPfe_Baud_Rate_4800.Size = new System.Drawing.Size(49, 17);
            this.rbPfe_Baud_Rate_4800.TabIndex = 0;
            this.rbPfe_Baud_Rate_4800.TabStop = true;
            this.rbPfe_Baud_Rate_4800.Text = "4800";
            this.rbPfe_Baud_Rate_4800.UseVisualStyleBackColor = true;
            // 
            // rbPfe_Baud_Rate_9600
            // 
            this.rbPfe_Baud_Rate_9600.AutoSize = true;
            this.rbPfe_Baud_Rate_9600.Location = new System.Drawing.Point(11, 43);
            this.rbPfe_Baud_Rate_9600.Name = "rbPfe_Baud_Rate_9600";
            this.rbPfe_Baud_Rate_9600.Size = new System.Drawing.Size(49, 17);
            this.rbPfe_Baud_Rate_9600.TabIndex = 1;
            this.rbPfe_Baud_Rate_9600.TabStop = true;
            this.rbPfe_Baud_Rate_9600.Text = "9600";
            this.rbPfe_Baud_Rate_9600.UseVisualStyleBackColor = true;
            // 
            // rbPfe_Baud_Rate_19200
            // 
            this.rbPfe_Baud_Rate_19200.AutoSize = true;
            this.rbPfe_Baud_Rate_19200.Location = new System.Drawing.Point(77, 20);
            this.rbPfe_Baud_Rate_19200.Name = "rbPfe_Baud_Rate_19200";
            this.rbPfe_Baud_Rate_19200.Size = new System.Drawing.Size(55, 17);
            this.rbPfe_Baud_Rate_19200.TabIndex = 2;
            this.rbPfe_Baud_Rate_19200.TabStop = true;
            this.rbPfe_Baud_Rate_19200.Text = "19200";
            this.rbPfe_Baud_Rate_19200.UseVisualStyleBackColor = true;
            // 
            // rbPfe_Baud_Rate_38400
            // 
            this.rbPfe_Baud_Rate_38400.AutoSize = true;
            this.rbPfe_Baud_Rate_38400.Location = new System.Drawing.Point(77, 43);
            this.rbPfe_Baud_Rate_38400.Name = "rbPfe_Baud_Rate_38400";
            this.rbPfe_Baud_Rate_38400.Size = new System.Drawing.Size(55, 17);
            this.rbPfe_Baud_Rate_38400.TabIndex = 3;
            this.rbPfe_Baud_Rate_38400.TabStop = true;
            this.rbPfe_Baud_Rate_38400.Text = "38400";
            this.rbPfe_Baud_Rate_38400.UseVisualStyleBackColor = true;
            // 
            // rbPfe_Baud_Rate_115200
            // 
            this.rbPfe_Baud_Rate_115200.AutoSize = true;
            this.rbPfe_Baud_Rate_115200.Location = new System.Drawing.Point(138, 43);
            this.rbPfe_Baud_Rate_115200.Name = "rbPfe_Baud_Rate_115200";
            this.rbPfe_Baud_Rate_115200.Size = new System.Drawing.Size(61, 17);
            this.rbPfe_Baud_Rate_115200.TabIndex = 5;
            this.rbPfe_Baud_Rate_115200.TabStop = true;
            this.rbPfe_Baud_Rate_115200.Text = "115200";
            this.rbPfe_Baud_Rate_115200.UseVisualStyleBackColor = true;
            // 
            // rbPfe_Baud_Rate_57600
            // 
            this.rbPfe_Baud_Rate_57600.AutoSize = true;
            this.rbPfe_Baud_Rate_57600.Location = new System.Drawing.Point(138, 20);
            this.rbPfe_Baud_Rate_57600.Name = "rbPfe_Baud_Rate_57600";
            this.rbPfe_Baud_Rate_57600.Size = new System.Drawing.Size(55, 17);
            this.rbPfe_Baud_Rate_57600.TabIndex = 4;
            this.rbPfe_Baud_Rate_57600.TabStop = true;
            this.rbPfe_Baud_Rate_57600.Text = "57600";
            this.rbPfe_Baud_Rate_57600.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbPfe_Data_Bits_8);
            this.groupBox4.Controls.Add(this.rbPfe_Data_Bits_7);
            this.groupBox4.Location = new System.Drawing.Point(214, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(86, 37);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data Bits:";
            // 
            // rbPfe_Data_Bits_7
            // 
            this.rbPfe_Data_Bits_7.AutoSize = true;
            this.rbPfe_Data_Bits_7.Location = new System.Drawing.Point(6, 14);
            this.rbPfe_Data_Bits_7.Name = "rbPfe_Data_Bits_7";
            this.rbPfe_Data_Bits_7.Size = new System.Drawing.Size(31, 17);
            this.rbPfe_Data_Bits_7.TabIndex = 0;
            this.rbPfe_Data_Bits_7.TabStop = true;
            this.rbPfe_Data_Bits_7.Text = "7";
            this.rbPfe_Data_Bits_7.UseVisualStyleBackColor = true;
            // 
            // rbPfe_Data_Bits_8
            // 
            this.rbPfe_Data_Bits_8.AutoSize = true;
            this.rbPfe_Data_Bits_8.Location = new System.Drawing.Point(43, 14);
            this.rbPfe_Data_Bits_8.Name = "rbPfe_Data_Bits_8";
            this.rbPfe_Data_Bits_8.Size = new System.Drawing.Size(31, 17);
            this.rbPfe_Data_Bits_8.TabIndex = 1;
            this.rbPfe_Data_Bits_8.TabStop = true;
            this.rbPfe_Data_Bits_8.Text = "8";
            this.rbPfe_Data_Bits_8.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbPfe_Stop_Bits_2);
            this.groupBox5.Controls.Add(this.rbPfe_Stop_Bits_1);
            this.groupBox5.Location = new System.Drawing.Point(306, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(86, 37);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Stop Bits:";
            // 
            // rbPfe_Stop_Bits_2
            // 
            this.rbPfe_Stop_Bits_2.AutoSize = true;
            this.rbPfe_Stop_Bits_2.Location = new System.Drawing.Point(43, 14);
            this.rbPfe_Stop_Bits_2.Name = "rbPfe_Stop_Bits_2";
            this.rbPfe_Stop_Bits_2.Size = new System.Drawing.Size(31, 17);
            this.rbPfe_Stop_Bits_2.TabIndex = 1;
            this.rbPfe_Stop_Bits_2.TabStop = true;
            this.rbPfe_Stop_Bits_2.Text = "2";
            this.rbPfe_Stop_Bits_2.UseVisualStyleBackColor = true;
            // 
            // rbPfe_Stop_Bits_1
            // 
            this.rbPfe_Stop_Bits_1.AutoSize = true;
            this.rbPfe_Stop_Bits_1.Location = new System.Drawing.Point(6, 14);
            this.rbPfe_Stop_Bits_1.Name = "rbPfe_Stop_Bits_1";
            this.rbPfe_Stop_Bits_1.Size = new System.Drawing.Size(31, 17);
            this.rbPfe_Stop_Bits_1.TabIndex = 0;
            this.rbPfe_Stop_Bits_1.TabStop = true;
            this.rbPfe_Stop_Bits_1.Text = "1";
            this.rbPfe_Stop_Bits_1.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rbPfe_Par_Nenhum);
            this.groupBox6.Controls.Add(this.rbPfe_Par_Impar);
            this.groupBox6.Controls.Add(this.rbPfe_Par_Par);
            this.groupBox6.Location = new System.Drawing.Point(214, 64);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(178, 37);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Paridade:";
            // 
            // rbPfe_Par_Nenhum
            // 
            this.rbPfe_Par_Nenhum.AutoSize = true;
            this.rbPfe_Par_Nenhum.Location = new System.Drawing.Point(110, 14);
            this.rbPfe_Par_Nenhum.Name = "rbPfe_Par_Nenhum";
            this.rbPfe_Par_Nenhum.Size = new System.Drawing.Size(65, 17);
            this.rbPfe_Par_Nenhum.TabIndex = 7;
            this.rbPfe_Par_Nenhum.TabStop = true;
            this.rbPfe_Par_Nenhum.Text = "Nenhum";
            this.rbPfe_Par_Nenhum.UseVisualStyleBackColor = true;
            // 
            // rbPfe_Par_Impar
            // 
            this.rbPfe_Par_Impar.AutoSize = true;
            this.rbPfe_Par_Impar.Location = new System.Drawing.Point(53, 14);
            this.rbPfe_Par_Impar.Name = "rbPfe_Par_Impar";
            this.rbPfe_Par_Impar.Size = new System.Drawing.Size(51, 17);
            this.rbPfe_Par_Impar.TabIndex = 6;
            this.rbPfe_Par_Impar.TabStop = true;
            this.rbPfe_Par_Impar.Text = "Ímpar";
            this.rbPfe_Par_Impar.UseVisualStyleBackColor = true;
            // 
            // rbPfe_Par_Par
            // 
            this.rbPfe_Par_Par.AutoSize = true;
            this.rbPfe_Par_Par.Location = new System.Drawing.Point(6, 14);
            this.rbPfe_Par_Par.Name = "rbPfe_Par_Par";
            this.rbPfe_Par_Par.Size = new System.Drawing.Size(41, 17);
            this.rbPfe_Par_Par.TabIndex = 5;
            this.rbPfe_Par_Par.TabStop = true;
            this.rbPfe_Par_Par.Text = "Par";
            this.rbPfe_Par_Par.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "IP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Porta:";
            // 
            // txtPfe_IP
            // 
            this.txtPfe_IP.Location = new System.Drawing.Point(45, 20);
            this.txtPfe_IP.Name = "txtPfe_IP";
            this.txtPfe_IP.Size = new System.Drawing.Size(100, 20);
            this.txtPfe_IP.TabIndex = 2;
            // 
            // txtPfe_Prt
            // 
            this.txtPfe_Prt.Location = new System.Drawing.Point(257, 20);
            this.txtPfe_Prt.Name = "txtPfe_Prt";
            this.txtPfe_Prt.Size = new System.Drawing.Size(61, 20);
            this.txtPfe_Prt.TabIndex = 3;
            // 
            // cbPfe_Tip
            // 
            this.cbPfe_Tip.FormattingEnabled = true;
            this.cbPfe_Tip.Location = new System.Drawing.Point(68, 38);
            this.cbPfe_Tip.Name = "cbPfe_Tip";
            this.cbPfe_Tip.Size = new System.Drawing.Size(133, 21);
            this.cbPfe_Tip.TabIndex = 7;
            this.cbPfe_Tip.SelectedIndexChanged += new System.EventHandler(this.cbPfe_Tip_SelectedIndexChanged);
            // 
            // txtPfe_Cod
            // 
            this.txtPfe_Cod.Location = new System.Drawing.Point(288, 38);
            this.txtPfe_Cod.Name = "txtPfe_Cod";
            this.txtPfe_Cod.Size = new System.Drawing.Size(121, 20);
            this.txtPfe_Cod.TabIndex = 8;
            // 
            // txtPfe_Nom
            // 
            this.txtPfe_Nom.Location = new System.Drawing.Point(68, 63);
            this.txtPfe_Nom.Name = "txtPfe_Nom";
            this.txtPfe_Nom.Size = new System.Drawing.Size(133, 20);
            this.txtPfe_Nom.TabIndex = 9;
            // 
            // cbPfe_Tip_Com
            // 
            this.cbPfe_Tip_Com.FormattingEnabled = true;
            this.cbPfe_Tip_Com.Location = new System.Drawing.Point(288, 63);
            this.cbPfe_Tip_Com.Name = "cbPfe_Tip_Com";
            this.cbPfe_Tip_Com.Size = new System.Drawing.Size(121, 21);
            this.cbPfe_Tip_Com.TabIndex = 10;
            this.cbPfe_Tip_Com.SelectedIndexChanged += new System.EventHandler(this.cbPfe_Tip_Com_SelectedIndexChanged);
            // 
            // gridPerifericos
            // 
            this.gridPerifericos.AllowUserToAddRows = false;
            this.gridPerifericos.AllowUserToDeleteRows = false;
            this.gridPerifericos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPerifericos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPerifericos.Location = new System.Drawing.Point(0, 0);
            this.gridPerifericos.Name = "gridPerifericos";
            this.gridPerifericos.ReadOnly = true;
            this.gridPerifericos.Size = new System.Drawing.Size(784, 198);
            this.gridPerifericos.TabIndex = 1;
            this.gridPerifericos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridPerifericos_CellMouseDoubleClick);
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
            this.splitContainer2.Panel2.Controls.Add(this.gridPerifericos);
            this.splitContainer2.Size = new System.Drawing.Size(784, 487);
            this.splitContainer2.SplitterDistance = 285;
            this.splitContainer2.TabIndex = 2;
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
            // frCadPfe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frCadPfe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Periféricos";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPerifericos)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rbPfe_Par_Nenhum;
        private System.Windows.Forms.RadioButton rbPfe_Par_Impar;
        private System.Windows.Forms.RadioButton rbPfe_Par_Par;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbPfe_Stop_Bits_2;
        private System.Windows.Forms.RadioButton rbPfe_Stop_Bits_1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbPfe_Data_Bits_8;
        private System.Windows.Forms.RadioButton rbPfe_Data_Bits_7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbPfe_Baud_Rate_115200;
        private System.Windows.Forms.RadioButton rbPfe_Baud_Rate_57600;
        private System.Windows.Forms.RadioButton rbPfe_Baud_Rate_38400;
        private System.Windows.Forms.RadioButton rbPfe_Baud_Rate_19200;
        private System.Windows.Forms.RadioButton rbPfe_Baud_Rate_9600;
        private System.Windows.Forms.RadioButton rbPfe_Baud_Rate_4800;
        private System.Windows.Forms.TextBox txtPfe_Prt;
        private System.Windows.Forms.TextBox txtPfe_IP;
        private System.Windows.Forms.TextBox txtPfe_Nom;
        private System.Windows.Forms.TextBox txtPfe_Cod;
        private System.Windows.Forms.ComboBox cbPfe_Tip;
        private System.Windows.Forms.ComboBox cbPfe_Tip_Com;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView gridPerifericos;
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