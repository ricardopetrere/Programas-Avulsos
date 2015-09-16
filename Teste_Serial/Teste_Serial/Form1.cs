using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace Teste_Serial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(SerialPort.GetPortNames());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.BaudRate = Convert.ToInt16(rb9600.Text);
            serialPort1.DataBits = Convert.ToInt16(rb7.Text);
            serialPort1.Parity = Parity.Even;
            serialPort1.StopBits = StopBits.One;
            serialPort1.Open();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
                serialPort1.Close();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] dados = new byte[serialPort1.ReadBufferSize];
            Stream s = serialPort1.BaseStream;
            s.Read(dados, 0, dados.Length);
            txtRecebido.Text = serialPort1.ReadLine();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }
    }
}
