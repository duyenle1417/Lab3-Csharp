using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace Lab_3
{
    public partial class Bai3_TcpServer : Form
    {
        public Bai3_TcpServer()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread tcpThread = new Thread(new ThreadStart(startThread));
            tcpThread.Start();
        }

        void startThread()
        {
            int bytesReceived = 0;
            byte[] recv = new byte[1];
            Socket clientSocket;
            Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listenerSocket.Bind(ipep);
            listenerSocket.Listen(-1);
            clientSocket = listenerSocket.Accept();
            textBox1.Text = "New client connect...." + "\r\n";
            while(clientSocket.Connected)
            {
                do
                {
                    bytesReceived = clientSocket.Receive(recv);
                    textBox1.Text += Encoding.UTF8.GetString(recv);
                } while (bytesReceived != 0);
            }
            listenerSocket.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
