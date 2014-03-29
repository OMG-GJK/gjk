using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
namespace Net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ReceiveMsg();
        }

        private String Ip = "127.0.0.1";
        private int port = 9999;
        private String IPVoice = "127.0.0.1";
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        delegate void AppendTextCallBack(string txt);
        private void SendBtn_Click(object sender, EventArgs e)
        {
           
            if (MsgField.Text == "")
                MessageBox.Show("不可发送空消息");
            TcpClient tc = new TcpClient();
            IPAddress ipa=IPAddress.Parse(Ip);
            IPEndPoint ipep=new IPEndPoint(ipa,port);
            tc.Connect(ipep);
            if(tc.Connected)
                MessageBox.Show("ok");
          
            /*
            String Msg = MsgField.Text;
            NetworkStream ns = tc.GetStream();
            StreamWriter sw = new StreamWriter(ns);
            sw.WriteLine(Msg);
            sw.Flush();
            */

            NetworkStream ns = tc.GetStream();
            byte[] msg = Encoding.Unicode.GetBytes(MsgField.Text);
            ns.Write(msg, 0, msg.Length);
            ns.Flush();
           
        }
       
        private void ReceiveMsg()
        {
            Thread ListenThread = new Thread(
               
                    Listen
          
             );
            ListenThread.Start();
        }
        private void Listen()
        {
            
            IPAddress ipa = IPAddress.Parse(Ip);
        
            TcpListener tl = new TcpListener(ipa,port);
            tl.Start();
            MessageBox.Show("正在监听...");
            while (true)
            {
                byte[] rsvMsg = new byte[1024];
                Socket s=tl.AcceptSocket();
                s.Receive(rsvMsg);
                String RsvMsg = Encoding.Unicode.GetString(rsvMsg).TrimEnd('\0');
                MessageBox.Show(RsvMsg);
                AppendTextCallBack atcb = new AppendTextCallBack(ShowField.AppendText);
                this.Invoke(atcb, "Client: " + RsvMsg + Environment.NewLine);
            }
            /*
            NetworkStream ns = null;
            StreamReader sr=null;
            Socket s=null;
            while (true)
            {
                s=tl.AcceptSocket();
              
                ns = new NetworkStream(s);
              
                sr = new StreamReader(ns);
                if (sr == null)
                    MessageBox.Show("null");
                AppendTextCallBack atcb = new AppendTextCallBack(ShowField.AppendText);
                this.Invoke(atcb, "111");
                MessageBox.Show("revMsg" + sr.ReadLine());
                string revMsg = sr.ReadLine();
                this.Invoke(atcb,"Client: " + revMsg + Environment.NewLine);
            }
             * */
             
        }

        private void axVSession2_Enter(object sender, EventArgs e)
        {
            
        }

        private void startVoiceCommunication_Click(object sender, EventArgs e)
        {
            VoiceCommunication.Init();
            VoiceCommunication.AddDestIp(IPVoice);
            VoiceCommunication.Start();
        }

        private void stopVoiceCommunication_Click(object sender, EventArgs e)
        {
            VoiceCommunication.Stop();
        }

        private void SendMail_Click(object sender, EventArgs e)
        {
            MailForm mailForm = new MailForm();
            mailForm.Show();
        }
    }
}
