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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //página 35 Referências POO.pdf
        public static int operacoes;//variável static
        public int Quadrado(int x)//metodo
        {
            operacoes++;
            return x * x;
        }

        public double Quadrado(double y)//sobrecarga de método (overload)
        {
            operacoes++;
            return y * y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text=textBox1.Text.Replace('.',',');
            try
            {
                textBox2.Text = Quadrado(Convert.ToInt16(textBox1.Text)).ToString();
                return;
            }
            catch { }
            try
            {
                textBox2.Text = Quadrado(Convert.ToDouble(textBox1.Text)).ToString();
                return;
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 segundo = new Form2();//instancia Form2 com construtor padrão
            segundo.Show();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            string dado = textBox2.Text;//A property or indexer may not be passed as an out or ref parameter
            Form2 segundo = new Form2(ref dado);//instancia Form2 com construtor sobrecarregado
            segundo.Show();
        }
        
    }
}
