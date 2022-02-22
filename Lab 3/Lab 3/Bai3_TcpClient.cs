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
using System.Threading;

namespace Lab_3
{
    public partial class Bai3_TcpClient : Form
    {
        public Bai3_TcpClient()
        {
            InitializeComponent();
        }

        TcpClient tcpClient;

        private void btnSend_Click(object sender, EventArgs e)
        {
            tcpClient = new TcpClient();
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            IPEndPoint ipep = new IPEndPoint(ipAddress, 8080);
            tcpClient.Connect(ipep);
            Thread thread=new Thread(Send);
            thread.Start();
        }
        
        void Send()
        {
            NetworkStream ns = tcpClient.GetStream();
            byte[] data = Encoding.UTF8.GetBytes(textBox1.Text);
            ns.Write(data, 0, data.Length);
            textBox1.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
