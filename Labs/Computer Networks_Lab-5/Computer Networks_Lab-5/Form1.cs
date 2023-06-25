using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Computer_Networks_Lab_5
{
    public partial class ClientServerChat : Form
    {
        private TcpClient Client;

        public StreamReader SR;
        public StreamWriter SW;

        public string SentText;
        public string RecievedText;

        public ClientServerChat()
        {
            InitializeComponent();

            IPAddress[] LocalIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress Address in LocalIP)
            {
                if (Address.AddressFamily == AddressFamily.InterNetwork)
                {
                    ServerIPTextBox.Text = Address.ToString();
                }
            }
        }

        private void StartServerButton_Click(object sender, EventArgs e)
        {
            TcpListener Listener = new TcpListener(IPAddress.Any, int.Parse(ServerPortTextBox.Text));
            Listener.Start();
            Client = Listener.AcceptTcpClient();
            SR = new StreamReader(Client.GetStream());
            SW = new StreamWriter(Client.GetStream());
            SW.AutoFlush = true;

            Text = "Server";

            AdditionalStream1.RunWorkerAsync();
            AdditionalStream2.WorkerSupportsCancellation = true;
        }

        private void ConnectClientButton_Click(object sender, EventArgs e)
        {
            Client = new TcpClient();
            IPEndPoint IPEndP = new IPEndPoint(IPAddress.Parse(ClientIPTextBox.Text), int.Parse(ClientPortTextBox.Text));

            try
            {
                Client.Connect(IPEndP);
                if (Client.Connected == true)
                {
                    ChatRichTextBox.AppendText("Подключение к серверу прошло успешно!\n");
                    SR = new StreamReader(Client.GetStream());
                    SW = new StreamWriter(Client.GetStream());
                    SW.AutoFlush = true;

                    Text = "Client";

                    AdditionalStream1.RunWorkerAsync();
                    AdditionalStream2.WorkerSupportsCancellation = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            if (MessageRichTextBox.Text != "")
            {
                SentText = MessageRichTextBox.Text;
                AdditionalStream2.RunWorkerAsync();
            }
            MessageRichTextBox.Text = "";
        }

        private void AdditionalStream1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (Client.Connected == true)
            {
                try
                {
                    RecievedText = SR.ReadLine();
                    this.ChatRichTextBox.Invoke(new MethodInvoker(delegate() { ChatRichTextBox.AppendText(DateTime.Now + " Получено сообщение:  " + RecievedText + "\n"); }));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void AdditionalStream2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (Client.Connected == true)
            {
                SW.WriteLine(SentText);
                this.ChatRichTextBox.Invoke(new MethodInvoker(delegate() { ChatRichTextBox.AppendText(DateTime.Now + " Ваше сообщение:  " + SentText + "\n"); }));
            }
            else 
            {
                MessageBox.Show("Ошибка! Сообщение не было доставлено!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            AdditionalStream2.CancelAsync();
        }
    }
}
