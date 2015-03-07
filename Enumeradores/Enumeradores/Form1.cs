using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Enumerador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //página 43 Referências POO.pdf
        //enum Meses { Janeiro, Fevereiro, Março, Abril, Maio, Junho, Julho, Agosto, Setembro = 1, Outubro, Novembro, Dezembro };//desse jeito teria indices como int (padrão)
        enum Meses : short{ Janeiro, Fevereiro, Março, Abril, Maio, Junho, Julho, Agosto, Setembro = 1, Outubro, Novembro, Dezembro };//enum com os meses do ano

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(Meses.Janeiro);
            comboBox1.Items.Add(Meses.Fevereiro);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ((int)Meses.Setembro).ToString();
            comboBox2.Items.Add((int)Meses.Janeiro);
            comboBox2.Items.Add((int)Meses.Fevereiro);
            comboBox2.Items.Add((int)Meses.Março);
            comboBox2.Items.Add((int)Meses.Abril);
            comboBox2.Items.Add((int)Meses.Maio);
            comboBox2.Items.Add((int)Meses.Junho);
            comboBox2.Items.Add((int)Meses.Julho);
            comboBox2.Items.Add((int)Meses.Agosto);
            comboBox2.Items.Add((int)Meses.Setembro);
            comboBox2.Items.Add((int)Meses.Outubro);
            comboBox2.Items.Add((int)Meses.Novembro);
            comboBox2.Items.Add((int)Meses.Dezembro);
        }
    }
}
