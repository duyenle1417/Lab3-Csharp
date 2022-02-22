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
    public partial class Bai4_Server : Form
    {
        public Bai4_Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        private void Bai4_Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            foreach(Socket item in clientList)
            {
                Send(item);
            }
            string text = "Server: " + txtMess.Text;
            addMessage(text);
            txtMess.Clear();
        }

        IPEndPoint ipep;
        Socket server;
        List<Socket> clientList;

        void Connect()
        {
            clientList = new List<Socket>();
            ipep = new IPEndPoint(IPAddress.Any, 8080);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(ipep);
            Thread listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        lstB1.Items.Add("New client connected!");
                        clientList.Add(client);
                        Thread receive = new Thread(Received);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    ipep = new IPEndPoint(IPAddress.Any, 8080);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                }
            });
            listen.IsBackground = true;
            listen.Start();
        }

        void close()
        {
            server.Close();
        }

        void Send(Socket client)
        {
            string text = "Server: " + txtMess.Text;
            if (client != null && txtMess.Text != string.Empty)
                client.Send(Serialize(text));
        }

        void Received(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    string mess = Deserialize(data).ToString();
                    foreach(Socket item in clientList)
                    {
                        if(item != null && item != client )
                            item.Send(Serialize(mess));
                    }    
                    addMessage(mess);
                }
            }
            catch
            {
                clientList.Remove(client);
                client.Close();
            }
        }

        void addMessage(string message)
        {
            lstB1.Items.Add(message);
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

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.close();
        }

        private void Bai4_Server_Load(object sender, EventArgs e)
        {
            lstB1.Items.Add("Server running on 127.0.0.1 8080");
        }
    }
}
