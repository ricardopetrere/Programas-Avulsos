namespace Serial1
{
    partial class Form1
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
            this.txtEnviados = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnReceber = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbPfe_Par_Nenhum = new System.Windows.Forms.RadioButton();
            this.rbPfe_Par_Impar = new System.Windows.Forms.RadioButton();
            this.rbPfe_Par_Par = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbPfe_Stop_Bits_2 = new System.Windows.Forms.RadioButton();
            this.rbPfe_Stop_Bits_1 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbPfe_Data_Bits_8 = new System.Windows.Forms.RadioButton();
            this.rbPfe_Data_Bits_7 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbPfe_Baud_Rate_115200 = new System.Windows.Forms.RadioButton();
            this.rbPfe_Baud_Rate_57600 = new System.Windows.Forms.RadioButton();
            this.rbPfe_Baud_Rate_38400 = new System.Windows.Forms.RadioButton();
            this.rbPfe_Baud_Rate_19200 = new System.Windows.Forms.RadioButton();
            this.rbPfe_Baud_Rate_9600 = new System.Windows.Forms.RadioButton();
            this.rbPfe_Baud_Rate_4800 = new System.Windows.Forms.RadioButton();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRecebidos = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEnviados
            // 
            this.txtEnviados.Location = new System.Drawing.Point(12, 185);
            this.txtEnviados.Multiline = true;
            this.txtEnviados.Name = "txtEnviados";
            this.txtEnviados.Size = new System.Drawing.Size(199, 145);
            this.txtEnviados.TabIndex = 0;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Enabled = false;
            this.btnEnviar.Location = new System.Drawing.Point(418, 40);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnReceber
            // 
            this.btnReceber.Enabled = false;
            this.btnReceber.Location = new System.Drawing.Point(418, 69);
            this.btnReceber.Name = "btnReceber";
            this.btnReceber.Size = new System.Drawing.Size(75, 23);
            this.btnReceber.TabIndex = 2;
            this.btnReceber.Text = "Receber";
            this.btnReceber.UseVisualStyleBackColor = true;
            this.btnReceber.Click += new System.EventHandler(this.btnReceber_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 142);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rbPfe_Par_Nenhum);
            this.groupBox6.Controls.Add(this.rbPfe_Par_Impar);
            this.groupBox6.Controls.Add(this.rbPfe_Par_Par);
            this.groupBox6.Location = new System.Drawing.Point(213, 99);
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
            this.rbPfe_Par_Nenhum.Text = "Nenhum";
            this.rbPfe_Par_Nenhum.UseVisualStyleBackColor = true;
            this.rbPfe_Par_Nenhum.Click += new System.EventHandler(this.rbPfe_Par_Par_Click);
            // 
            // rbPfe_Par_Impar
            // 
            this.rbPfe_Par_Impar.AutoSize = true;
            this.rbPfe_Par_Impar.Location = new System.Drawing.Point(53, 14);
            this.rbPfe_Par_Impar.Name = "rbPfe_Par_Impar";
            this.rbPfe_Par_Impar.Size = new System.Drawing.Size(51, 17);
            this.rbPfe_Par_Impar.TabIndex = 6;
            this.rbPfe_Par_Impar.Text = "Ímpar";
            this.rbPfe_Par_Impar.UseVisualStyleBackColor = true;
            this.rbPfe_Par_Impar.Click += new System.EventHandler(this.rbPfe_Par_Par_Click);
            // 
            // rbPfe_Par_Par
            // 
            this.rbPfe_Par_Par.AutoSize = true;
            this.rbPfe_Par_Par.Checked = true;
            this.rbPfe_Par_Par.Location = new System.Drawing.Point(6, 14);
            this.rbPfe_Par_Par.Name = "rbPfe_Par_Par";
            this.rbPfe_Par_Par.Size = new System.Drawing.Size(41, 17);
            this.rbPfe_Par_Par.TabIndex = 5;
            this.rbPfe_Par_Par.TabStop = true;
            this.rbPfe_Par_Par.Text = "Par";
            this.rbPfe_Par_Par.UseVisualStyleBackColor = true;
            this.rbPfe_Par_Par.Click += new System.EventHandler(this.rbPfe_Par_Par_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbPfe_Stop_Bits_2);
            this.groupBox5.Controls.Add(this.rbPfe_Stop_Bits_1);
            this.groupBox5.Location = new System.Drawing.Point(305, 54);
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
            this.rbPfe_Stop_Bits_2.Text = "2";
            this.rbPfe_Stop_Bits_2.UseVisualStyleBackColor = true;
            this.rbPfe_Stop_Bits_2.Click += new System.EventHandler(this.rbPfe_Stop_Bits_1_Click);
            // 
            // rbPfe_Stop_Bits_1
            // 
            this.rbPfe_Stop_Bits_1.AutoSize = true;
            this.rbPfe_Stop_Bits_1.Checked = true;
            this.rbPfe_Stop_Bits_1.Location = new System.Drawing.Point(6, 14);
            this.rbPfe_Stop_Bits_1.Name = "rbPfe_Stop_Bits_1";
            this.rbPfe_Stop_Bits_1.Size = new System.Drawing.Size(31, 17);
            this.rbPfe_Stop_Bits_1.TabIndex = 0;
            this.rbPfe_Stop_Bits_1.TabStop = true;
            this.rbPfe_Stop_Bits_1.Text = "1";
            this.rbPfe_Stop_Bits_1.UseVisualStyleBackColor = true;
            this.rbPfe_Stop_Bits_1.Click += new System.EventHandler(this.rbPfe_Stop_Bits_1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbPfe_Data_Bits_8);
            this.groupBox4.Controls.Add(this.rbPfe_Data_Bits_7);
            this.groupBox4.Location = new System.Drawing.Point(213, 55);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(86, 37);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data Bits:";
            // 
            // rbPfe_Data_Bits_8
            // 
            this.rbPfe_Data_Bits_8.AutoSize = true;
            this.rbPfe_Data_Bits_8.Location = new System.Drawing.Point(43, 14);
            this.rbPfe_Data_Bits_8.Name = "rbPfe_Data_Bits_8";
            this.rbPfe_Data_Bits_8.Size = new System.Drawing.Size(31, 17);
            this.rbPfe_Data_Bits_8.TabIndex = 1;
            this.rbPfe_Data_Bits_8.Text = "8";
            this.rbPfe_Data_Bits_8.UseVisualStyleBackColor = true;
            this.rbPfe_Data_Bits_8.Click += new System.EventHandler(this.rbPfe_Data_Bits_7_Click);
            // 
            // rbPfe_Data_Bits_7
            // 
            this.rbPfe_Data_Bits_7.AutoSize = true;
            this.rbPfe_Data_Bits_7.Checked = true;
            this.rbPfe_Data_Bits_7.Location = new System.Drawing.Point(6, 14);
            this.rbPfe_Data_Bits_7.Name = "rbPfe_Data_Bits_7";
            this.rbPfe_Data_Bits_7.Size = new System.Drawing.Size(31, 17);
            this.rbPfe_Data_Bits_7.TabIndex = 0;
            this.rbPfe_Data_Bits_7.TabStop = true;
            this.rbPfe_Data_Bits_7.Text = "7";
            this.rbPfe_Data_Bits_7.UseVisualStyleBackColor = true;
            this.rbPfe_Data_Bits_7.Click += new System.EventHandler(this.rbPfe_Data_Bits_7_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbPfe_Baud_Rate_115200);
            this.groupBox3.Controls.Add(this.rbPfe_Baud_Rate_57600);
            this.groupBox3.Controls.Add(this.rbPfe_Baud_Rate_38400);
            this.groupBox3.Controls.Add(this.rbPfe_Baud_Rate_19200);
            this.groupBox3.Controls.Add(this.rbPfe_Baud_Rate_9600);
            this.groupBox3.Controls.Add(this.rbPfe_Baud_Rate_4800);
            this.groupBox3.Location = new System.Drawing.Point(6, 55);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 81);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Baud Rate:";
            // 
            // rbPfe_Baud_Rate_115200
            // 
            this.rbPfe_Baud_Rate_115200.AutoSize = true;
            this.rbPfe_Baud_Rate_115200.Location = new System.Drawing.Point(138, 43);
            this.rbPfe_Baud_Rate_115200.Name = "rbPfe_Baud_Rate_115200";
            this.rbPfe_Baud_Rate_115200.Size = new System.Drawing.Size(61, 17);
            this.rbPfe_Baud_Rate_115200.TabIndex = 5;
            this.rbPfe_Baud_Rate_115200.Text = "115200";
            this.rbPfe_Baud_Rate_115200.UseVisualStyleBackColor = true;
            this.rbPfe_Baud_Rate_115200.Click += new System.EventHandler(this.rbPfe_Baud_Rate_4800_Click);
            // 
            // rbPfe_Baud_Rate_57600
            // 
            this.rbPfe_Baud_Rate_57600.AutoSize = true;
            this.rbPfe_Baud_Rate_57600.Location = new System.Drawing.Point(138, 20);
            this.rbPfe_Baud_Rate_57600.Name = "rbPfe_Baud_Rate_57600";
            this.rbPfe_Baud_Rate_57600.Size = new System.Drawing.Size(55, 17);
            this.rbPfe_Baud_Rate_57600.TabIndex = 4;
            this.rbPfe_Baud_Rate_57600.Text = "57600";
            this.rbPfe_Baud_Rate_57600.UseVisualStyleBackColor = true;
            this.rbPfe_Baud_Rate_57600.Click += new System.EventHandler(this.rbPfe_Baud_Rate_4800_Click);
            // 
            // rbPfe_Baud_Rate_38400
            // 
            this.rbPfe_Baud_Rate_38400.AutoSize = true;
            this.rbPfe_Baud_Rate_38400.Location = new System.Drawing.Point(77, 43);
            this.rbPfe_Baud_Rate_38400.Name = "rbPfe_Baud_Rate_38400";
            this.rbPfe_Baud_Rate_38400.Size = new System.Drawing.Size(55, 17);
            this.rbPfe_Baud_Rate_38400.TabIndex = 3;
            this.rbPfe_Baud_Rate_38400.Text = "38400";
            this.rbPfe_Baud_Rate_38400.UseVisualStyleBackColor = true;
            this.rbPfe_Baud_Rate_38400.Click += new System.EventHandler(this.rbPfe_Baud_Rate_4800_Click);
            // 
            // rbPfe_Baud_Rate_19200
            // 
            this.rbPfe_Baud_Rate_19200.AutoSize = true;
            this.rbPfe_Baud_Rate_19200.Location = new System.Drawing.Point(77, 20);
            this.rbPfe_Baud_Rate_19200.Name = "rbPfe_Baud_Rate_19200";
            this.rbPfe_Baud_Rate_19200.Size = new System.Drawing.Size(55, 17);
            this.rbPfe_Baud_Rate_19200.TabIndex = 2;
            this.rbPfe_Baud_Rate_19200.Text = "19200";
            this.rbPfe_Baud_Rate_19200.UseVisualStyleBackColor = true;
            this.rbPfe_Baud_Rate_19200.Click += new System.EventHandler(this.rbPfe_Baud_Rate_4800_Click);
            // 
            // rbPfe_Baud_Rate_9600
            // 
            this.rbPfe_Baud_Rate_9600.AutoSize = true;
            this.rbPfe_Baud_Rate_9600.Checked = true;
            this.rbPfe_Baud_Rate_9600.Location = new System.Drawing.Point(11, 43);
            this.rbPfe_Baud_Rate_9600.Name = "rbPfe_Baud_Rate_9600";
            this.rbPfe_Baud_Rate_9600.Size = new System.Drawing.Size(49, 17);
            this.rbPfe_Baud_Rate_9600.TabIndex = 1;
            this.rbPfe_Baud_Rate_9600.TabStop = true;
            this.rbPfe_Baud_Rate_9600.Text = "9600";
            this.rbPfe_Baud_Rate_9600.UseVisualStyleBackColor = true;
            this.rbPfe_Baud_Rate_9600.Click += new System.EventHandler(this.rbPfe_Baud_Rate_4800_Click);
            // 
            // rbPfe_Baud_Rate_4800
            // 
            this.rbPfe_Baud_Rate_4800.AutoSize = true;
            this.rbPfe_Baud_Rate_4800.Location = new System.Drawing.Point(11, 20);
            this.rbPfe_Baud_Rate_4800.Name = "rbPfe_Baud_Rate_4800";
            this.rbPfe_Baud_Rate_4800.Size = new System.Drawing.Size(49, 17);
            this.rbPfe_Baud_Rate_4800.TabIndex = 0;
            this.rbPfe_Baud_Rate_4800.Text = "4800";
            this.rbPfe_Baud_Rate_4800.UseVisualStyleBackColor = true;
            this.rbPfe_Baud_Rate_4800.Click += new System.EventHandler(this.rbPfe_Baud_Rate_4800_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(418, 213);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 7;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Enabled = false;
            this.btnFechar.Location = new System.Drawing.Point(418, 271);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Porta:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(121, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dados enviados:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Dados recebidos:";
            // 
            // txtRecebidos
            // 
            this.txtRecebidos.Location = new System.Drawing.Point(213, 185);
            this.txtRecebidos.Multiline = true;
            this.txtRecebidos.Name = "txtRecebidos";
            this.txtRecebidos.Size = new System.Drawing.Size(199, 145);
            this.txtRecebidos.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 342);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRecebidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReceber);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtEnviados);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnviados;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnReceber;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRecebidos;

    }
}

