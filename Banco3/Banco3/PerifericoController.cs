using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Banco3
{
    public static class PerifericoController
    {
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
                serial.Open();
                serial.WriteLine(dados);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                serial.Close();
            }
        }
        public static String RecebePacoteSerial(SerialPort serial)
        {
            String retorno = "";
            try
            {
                serial.Open();
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
        #endregion
    }
}