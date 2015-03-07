using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()//construtor padrão
        {
            InitializeComponent();//necessário para mostrar a interface gráfica
            textBox2.Text = Form1.operacoes.ToString();
        }
        public Form2(ref string valor)//construtor sobrecarregado com referencia como argumento
        {
            InitializeComponent();
            textBox1.Text = valor;
            textBox2.Text = Form1.operacoes.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.operacoes++;
            textBox2.Text = Form1.operacoes.ToString();
        }
    }
}
