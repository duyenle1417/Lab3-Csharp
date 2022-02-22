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
    public partial class Bai1_UDPServer : Form
    {
        public Bai1_UDPServer()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread thdUdpServer = new Thread(new ThreadStart(serverThread));
            thdUdpServer.Start();
        }

        public void serverThread()
        {
            UdpClient udpClient = new UdpClient(8080);
            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receivedBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.UTF8.GetString(receivedBytes);
                string mess = "";
                mess = RemoteIpEndPoint.Address.ToString() + ": " + returnData.ToString() + "\r\n";
                listBox1.Items.Add(mess);
            }
            //IPAddress localIP = IPAddress.Any;
            //int localPort = 8080;
            //IPEndPoint localEndP = new IPEndPoint(localIP, localPort);
            //Socket localSock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //localSock.Bind(localEndP);
            //byte[] data = new byte[1024];
            //while(true)
            //{
            //    EndPoint remoteEndP = new IPEndPoint(IPAddress.Any, 0);
            //    var length = localSock.ReceiveFrom(data, ref remoteEndP);
            //    string returnData = Encoding.UTF8.GetString(data, 0, length);
            //    string mess = remoteEndP.ToString() + ": " + returnData + "\r\n";
            //    listBox1.Items.Add(mess);
            //}
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
