using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using CFG_BD_XML;

namespace Banco2_Server
{
    public partial class frPrincipal : Form
    {
        public frPrincipal()
        {
            InitializeComponent();
        }
        String ip_tcp;
        int porta_tcp;
        TcpListener listener = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!BD_Connection.LeuBDXML())
            {
                Application.Exit();
                return;
            }
            ConfiguracaoVO cfg = ConfiguracaoDAO.Consulta();
            ip_tcp = cfg.Cfg_Tcpip_Ip;
            porta_tcp = cfg.Cfg_Tcpip_Prt;
            toolStripStatusLabel1.Text = toolStripStatusLabel1.Text.Replace("xxxxx"
                , porta_tcp.ToString());
            IniciarTcpListener();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (listener != null)
                listener.Stop();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.WordWrap = checkBox1.Checked;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            RecebePacotes();
        }

        private void RecebePacotes()
        {
            try
            {
                while (true)
                {
                    String retorno = "";
                    // Buffer for reading data
                    Byte[] bytes = new Byte[256];
                    String data = null;

                    TcpClient client = listener.AcceptTcpClient();
                    NetworkStream stream = client.GetStream();
                    int i;

                    // Loop to receive all the data sent by the client.
                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        // Translate data bytes to a ASCII string.
                        data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                        retorno += data;
                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

                    }
                    backgroundWorker1.ReportProgress(100, retorno);

                    // Shutdown and end connection
                    client.Close();
                }
            }
            catch
            {

            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            textBox1.Text = e.UserState.ToString();
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
            listener.Stop();
            switch (new frConexaoBD().ShowDialog())
            {
                case DialogResult.Abort:
                    Application.Exit();
                    break;
                case DialogResult.OK:
                    IniciarTcpListener();
                    break;
            }
        }
        private void IniciarTcpListener()
        {
            listener = new TcpListener(Dns.GetHostEntry(ip_tcp).AddressList[0], porta_tcp);
            listener.Start();
            backgroundWorker1.RunWorkerAsync();
        }
    }
}
