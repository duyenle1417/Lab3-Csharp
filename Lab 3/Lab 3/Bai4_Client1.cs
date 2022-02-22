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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Lab_3
{
    public partial class Bai4_Client1 : Form
    {
        public Bai4_Client1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string text = txtName.Text + ": " + txtMess.Text;
            Send();
            addMessage(text);
        }

        IPEndPoint ipep;
        Socket client; 

        void Connect()
        {
            ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                client.Connect(ipep);
            }
            catch
            {
                MessageBox.Show("Cannot connect to server!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Thread listen = new Thread(Received);
            listen.IsBackground = true;
            listen.Start();
        }

        void close()
        {
            client.Close();
        }

        void Send()
        {
            string text = txtName.Text + ": " + txtMess.Text;
            if (txtMess.Text != string.Empty)
                client.Send(Serialize(text));
        }

        void Received()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    string mess = Deserialize(data).ToString();
                    addMessage(mess);
                }
            }
            catch
            {
                Close();
            }
        }

        void addMessage(string message)
        {
            lstB1.Items.Add(message);
            txtMess.Clear();
        }

        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }

        Object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(stream);
        }

        private void Bai4_Client1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.close();
        }
    }
}
