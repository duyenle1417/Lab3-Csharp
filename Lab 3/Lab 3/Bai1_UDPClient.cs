using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Lab_3
{
    public partial class Bai1_UDP_Client : Form
    {
        public Bai1_UDP_Client()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            Byte[] sendByte = Encoding.UTF8.GetBytes(txtMess.Text);
            udpClient.Send(sendByte, sendByte.Length, txtIP.Text, Convert.ToInt32(txtPort.Text));
            txtMess.Text = "";
            //IPAddress serverIp = IPAddress.Parse(txtIP.Text);
            //int serverPort = int.Parse(txtPort.Text);
            //IPEndPoint serverEndP = new IPEndPoint(serverIp, serverPort);
            //byte[] data = new byte[1024];
            //Socket serverSock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //data = Encoding.UTF8.GetBytes(txtMess.Text);
            //serverSock.SendTo(data, serverEndP);
            //txtMess.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
