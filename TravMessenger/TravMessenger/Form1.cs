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

namespace TravMessenger
{
    public partial class Form1 : Form
    {
        Socket Sckt;
        EndPoint epLocal, epRemote;

        public Form1()
        {
            InitializeComponent();
            // prep the socket, UDP
            Sckt = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            Sckt.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            Text_Box_Local_IP.Text = GetLocalIP();
       }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if(ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                int size = Sckt.EndReceiveFrom(aResult,ref epRemote);
                if (size > 0)
                {
                    byte[] recievedData = new byte[1500];
                    recievedData = (byte[])aResult.AsyncState;

                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string recievedMessage = eEncoding.GetString(recievedData);

                    Chat_Window.Items.Add("Friend: "+recievedMessage);
                }

                byte[] buffer = new byte[1500];
                Sckt.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Connect_Button_Click(object sender, EventArgs e)
        {
            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(Text_Box_Local_IP.Text), Convert.ToInt32(Text_Box_Local_Port.Text));
                Sckt.Bind(epLocal);

                epRemote = new IPEndPoint(IPAddress.Parse(Text_Box_Remote_IP.Text), Convert.ToInt32(Text_Box_Remote_Port.Text));
                Sckt.Connect(epRemote);

                byte[] buffer = new byte[1500];
                Sckt.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

                Connect_Button.Text = "Connected";
                Connect_Button.Enabled = false;
                Send_Button.Enabled = true;
                Text_Box_Msg_Input.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Send_Button_Click(object sender, EventArgs e)
        {
            try
            {
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(Text_Box_Msg_Input.Text);

                Sckt.Send(msg);
                Chat_Window.Items.Add("Me: "+Text_Box_Msg_Input.Text);
                Text_Box_Msg_Input.Clear();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void Text_Box_Msg_Input_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
