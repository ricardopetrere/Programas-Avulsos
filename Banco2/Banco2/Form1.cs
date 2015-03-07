using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Banco2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TcpClient client = null;
        String endereco_tcp;
        int porta_tcp;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.WordWrap = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnviaPacote();
        }

        private void EnviaPacote()
        {
            NetworkStream stream = null;
            Byte[] dados = null;
            try
            {
                endereco_tcp = txtEndereco.Text;
                porta_tcp = (int)numPorta.Value;
                client = new TcpClient(endereco_tcp, porta_tcp);
                dados = System.Text.Encoding.ASCII.GetBytes(textBox1.Text);
                stream = client.GetStream();
                stream.Write(dados, 0, dados.Length);
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message);
            }
            finally
            {
                if(stream!=null)
                    stream.Close();
                if (client != null)
                    client.Close();
            }

        }
    }
}
