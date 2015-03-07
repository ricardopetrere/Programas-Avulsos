using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Serial1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            s = serialPort1;
            msgrecebida = txtRecebidos;
        }
        Thread t1 = new Thread(EscutarSerial);
        static SerialPort s = new SerialPort();
        static bool Ativa = false;
        static TextBox msgrecebida = new TextBox();
        static string message="";
        #region Comunicação Ethernet
        public static void EnviaPacoteEthernet(String IP, int porta, String dados)
        {
            TcpClient client = null;
            NetworkStream stream = null;
            try
            {
                client = new TcpClient(new IPEndPoint(IPAddress.Parse(IP), porta));
                Byte[] data = Encoding.ASCII.GetBytes(dados);
                stream = client.GetStream();
                stream.Write(data, 0, data.Length);
                data = new Byte[256];
                int bytes = stream.Read(data, 0, data.Length);
                String response = Encoding.ASCII.GetString(data, 0, data.Length);
            }
            catch
            {

            }
            finally
            {
                stream.Close();
                client.Close();
            }
        }

        public static String RecebePacoteEthernet(String IP, int porta)
        {
            String retorno = "";
            TcpListener server = null;
            try
            {
                // TcpListener server = new TcpListener(port);
                server = new TcpListener(IPAddress.Parse(IP), porta);

                // Start listening for client requests.
                server.Start();

                // Buffer for reading data
                Byte[] bytes = new Byte[256];
                String data = null;

                TcpClient client = server.AcceptTcpClient();
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

                // Shutdown and end connection
                client.Close();
            }
            catch
            {

            }
            finally
            {
                server.Stop();
            }
            return retorno;
        }
        #endregion
        #region Comunicação Serial
        public static void EnviaPacoteSerial(SerialPort serial, String dados)
        {
            try
            {
                serial.WriteLine(dados);
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
        }
        public static String RecebePacoteSerial(SerialPort serial)
        {
            String retorno = "";
            try
            {
                retorno = serial.ReadLine();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                serial.Close();
            }
            return retorno;
        }
        public static void EscutarSerial()
        {
            while (Ativa)
            {
                try
                {
                    message = s.ReadLine();
                    msgrecebida.Text = message;
                }
                catch (TimeoutException) { }
            }
        }
        #endregion

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            EnviaPacoteSerial(s, txtEnviados.Text);
        }

        private void btnReceber_Click(object sender, EventArgs e)
        {

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count == 0)
            {
                MessageBox.Show("Não há portas seriais disponíveis.");
                return;
            }
            s.PortName = comboBox1.SelectedItem.ToString();
            serialPort1.Open();
            Ativa = true;
            t1.Start();
            btnAbrir.Enabled = false;
            btnFechar.Enabled = true;
            btnEnviar.Enabled = true;
            btnReceber.Enabled = true;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            t1.Join();
            Ativa = false;
            btnAbrir.Enabled = true;
            btnFechar.Enabled = false;
            btnEnviar.Enabled = false;
            btnReceber.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] seriais = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(seriais);
        }

        private void rbPfe_Baud_Rate_4800_Click(object sender, EventArgs e)
        {
            if (s.IsOpen)
                return;
            RadioButton rb = (sender as RadioButton);
            if(rb.Checked)
                serialPort1.BaudRate = Convert.ToInt32(rb.Text);
        }

        private void rbPfe_Data_Bits_7_Click(object sender, EventArgs e)
        {
            if (s.IsOpen)
                return;
            RadioButton rb = (sender as RadioButton);
            if (rb.Checked)
                serialPort1.DataBits = Convert.ToInt32(rb.Text);
        }

        private void rbPfe_Par_Par_Click(object sender, EventArgs e)
        {
            if (s.IsOpen)
                return;
            if (rbPfe_Par_Impar.Checked)
                serialPort1.Parity = Parity.Odd;
            else if (rbPfe_Par_Par.Checked)
                serialPort1.Parity = Parity.Even;
            else if (rbPfe_Par_Nenhum.Checked)
                serialPort1.Parity = Parity.None;
        }

        private void rbPfe_Stop_Bits_1_Click(object sender, EventArgs e)
        {
            if (s.IsOpen)
                return;
            if (rbPfe_Stop_Bits_1.Checked)
                serialPort1.StopBits = StopBits.One;
            if (rbPfe_Stop_Bits_2.Checked)
                serialPort1.StopBits = StopBits.Two;
        }
    }
}