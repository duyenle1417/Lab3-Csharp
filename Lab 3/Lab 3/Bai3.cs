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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btnTcpClient_Click(object sender, EventArgs e)
        {
            Bai3_TcpClient frmTcpClient = new Bai3_TcpClient();
            frmTcpClient.Show();
        }

        private void btnTcpServer_Click(object sender, EventArgs e)
        {
            Bai3_TcpServer frmTcpServer = new Bai3_TcpServer();
            frmTcpServer.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
