using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btnUdpServer_Click(object sender, EventArgs e)
        {
            Bai1_UDPServer frmUdpServer = new Bai1_UDPServer();
            frmUdpServer.Show();
        }

        private void btnUdpClient_Click(object sender, EventArgs e)
        {
            Bai1_UDP_Client frmUdpClient = new Bai1_UDP_Client();
            frmUdpClient.Show();
        }

        private void btnThoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
