using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace P2PNetworkApp
{
    public partial class Form1 : Form
    {
        private Socket socket;
        private EndPoint localEP, remoteEP;

        public Form1()
        {
            InitializeComponent();
            // Initialize socket for UDP communication
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            // Set the text fields with local IP address
            ipBox1.Text = GetLocalIP();
            ipBox2.Text = GetLocalIP();

            this.sendBox.KeyPress += new KeyPressEventHandler(this.sendBox_KeyPress);
        }

        private string GetLocalIP()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            // Loop over all host addresses and return first IPv4 address found
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }

            // Return local loopback address in case no other IPv4 address is found
            return "127.0.0.1";
        }

        private void SendMessage()
        {
            try
            {
                string message = sendBox.Text.Trim();
                if (!string.IsNullOrEmpty(message))
                {
                    byte[] msg = new ASCIIEncoding().GetBytes(message);

                    socket.Send(msg);

                    // Display the sent message and clear the input box
                    receiveBox.AppendText(">>" + message + Environment.NewLine);
                    sendBox.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void HandleMessage(IAsyncResult aResult)
        {
            try
            {
                int size = socket.EndReceiveFrom(aResult, ref remoteEP);

                if (size > 0)
                {
                    byte[] receivedData = new byte[size];
                    Array.Copy((byte[])aResult.AsyncState, receivedData, size);

                    // Convert received bytes into a string message
                    string messageReceived = new ASCIIEncoding().GetString(receivedData);

                    receiveBox.AppendText(">>" + messageReceived + Environment.NewLine);
                }

                byte[] buffer = new byte[1500];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref remoteEP,
                    new AsyncCallback(HandleMessage), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void sendButton_Click(object sender, EventArgs e)
        {
            SendMessage();
        }


        private void sendBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SendMessage();
            }

        }


        public void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Bind the socket to the local endpoint
                localEP = new IPEndPoint(IPAddress.Parse(ipBox1.Text), Convert.ToInt32(portBox1.Text));
                socket.Bind(localEP);

                // Connect to the remote endpoint
                remoteEP = new IPEndPoint(IPAddress.Parse(ipBox2.Text), Convert.ToInt32(portBox2.Text));
                socket.Connect(remoteEP);

                // Start receiving data
                byte[] buffer = new byte[1500];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref remoteEP,
                    new AsyncCallback(HandleMessage), buffer);

                // Update the UI
                connectButton.Text = "Connected!";
                connectButton.Enabled = false;
                sendButton.Enabled = true;
                sendBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}