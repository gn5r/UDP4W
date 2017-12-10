using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;

namespace UDPSample
{
    public partial class Form1 : Form
    {
        private System.Net.Sockets.UdpClient UdpClient;
        private String connectIPAddress;

        public Form1()
        {
            InitializeComponent();
            this.Icon = new System.Drawing.Icon(@".\chat.ico");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("接続先と同じLAN内ですか？", 
                "警告",
                MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);

            if (DialogResult.OK == result)
            {
                string HostName = Dns.GetHostName();
                IPAddress[] address = Dns.GetHostAddresses(HostName);
                foreach(IPAddress addr in address)
                {
                    if(addr.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        myIP.Text = "IPAddress:" + addr.ToString();
                    }
                }
            }
        }

        private void onClickConnectButton(object sender, EventArgs args)
        {

            ((Button)sender).Enabled = false;

            if(this.connectIP.Text == null || this.connectIP.Text.Length == 0)
            {
                this.connectIP.Text = "未入力です";
            }

            if(comPort.Text == null)
            {
                comPort.Text = "5555";
            }

            connectIPAddress = this.connectIP.Text;

            BeginReceiveTask(comPort.Text);
        }

        private void BeginReceiveTask(string comPort)
        {
            Task.Run(() =>
            {
                System.Net.IPEndPoint connectIP = new System.Net.IPEndPoint(
                IPAddress.Any,
                int.Parse(comPort));

                UdpClient = new System.Net.Sockets.UdpClient(connectIP);
                UdpClient.BeginReceive(Receive, UdpClient);
            });
        }

        private void Receive(IAsyncResult result)
        {

            System.Net.Sockets.UdpClient udp =
            (System.Net.Sockets.UdpClient)result.AsyncState;

            //非同期受信を終了する
            System.Net.IPEndPoint remoteIP = null;
            byte[] buf;

            try
            {
                buf = udp.EndReceive(result, ref remoteIP);
            }
            catch (System.Net.Sockets.SocketException ex)
            {
                Console.WriteLine("受信エラー({0}/{1})",
                    ex.Message, ex.ErrorCode);
                return;
            }
            catch (ObjectDisposedException ex)
            {
                //すでに閉じている時は終了
                Console.WriteLine("Socketは閉じられています。" + ex.Message);
                return;
            }

            //データを文字列に変換する
            string Message = System.Text.Encoding.UTF8.GetString(buf);

            //受信したデータと送信者の情報をRichTextBoxに表示する
            string displayMsg = string.Format("[{0} ({1})] > {2}",
                remoteIP.Address, remoteIP.Port, Message);
            richTextBox1.BeginInvoke(
                new Action<string>(ShowMessage), displayMsg);

            //再びデータ受信を開始する
            udp.BeginReceive(Receive, udp);
        }

        private void ShowMessage(string message)
        {
            richTextBox1.Text = message + "\r\n" + richTextBox1.Text;

           
        }

        private void sendText_Click(object sender, EventArgs e)
        {
            //送信するデータを作成する
            byte[] sendBytes =
                System.Text.Encoding.UTF8.GetBytes(messageText.Text);

            //UdpClientを作成する
            if (UdpClient == null)
            {
                UdpClient = new System.Net.Sockets.UdpClient();
            }

            //非同期的にデータを送信する
            UdpClient.BeginSend(sendBytes,
                sendBytes.Length,
                connectIPAddress,
                int.Parse(comPort.Text),
                SendCallback,
                UdpClient);

            messageText.Text = "";
        }

        //データを送信した時
        private void SendCallback(IAsyncResult ar)
        {
            System.Net.Sockets.UdpClient udp =
                (System.Net.Sockets.UdpClient)ar.AsyncState;

            //非同期送信を終了する
            try
            {
                udp.EndSend(ar);
            }
            catch (System.Net.Sockets.SocketException ex)
            {
                Console.WriteLine("送信エラー({0}/{1})",
                    ex.Message, ex.ErrorCode);
            }
            catch (ObjectDisposedException ex)
            {
                //すでに閉じている時は終了
                Console.WriteLine("Socketは閉じられています。");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(UdpClient != null)
            {
                UdpClient.Close();
            }
        }
    }
}
