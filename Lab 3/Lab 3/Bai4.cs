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
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void btnClient1_Click(object sender, EventArgs e)
        {
            Bai4_Client1 frmClient1 = new Bai4_Client1();
            frmClient1.Show();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            Bai4_Server frmServer = new Bai4_Server();
            frmServer.Show();
        }

        private void btnClient2_Click(object sender, EventArgs e)
        {
            Bai4_Client2 frmClient2 = new Bai4_Client2();
            frmClient2.Show();
        }

        private void btnClient3_Click(object sender, EventArgs e)
        {
            Bai4_Client3 frmClient3 = new Bai4_Client3();
            frmClient3.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
