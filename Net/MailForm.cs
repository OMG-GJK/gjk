using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
namespace Net
{
    public partial class MailForm : Form
    {
        private String mailDes = "steam1994@163.com";
        private String mailFrom = "steam1994@163.com";
        private String smtpHost = "smtp.163.com";
        private String psw = "gengjin1234kun";
        private int port = 25;

        private SmtpClient client = null;
        private MailAddress fromAddr = null;
        private MailAddress toAddr = null;
        private MailMessage mm = null;
        public MailForm()
        {
            InitializeComponent();

            client = new SmtpClient(smtpHost, port);
            client.Credentials = new System.Net.NetworkCredential(mailFrom, psw); 
            fromAddr = new MailAddress(mailFrom, "gjk");
            mm = new MailMessage();
            mm.From = fromAddr;
            toAddr = new MailAddress(mailDes);
            //mm = new MailMessage(fromAddr, toAddr);
            mailtoBox.Text = mailDes; 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //qq邮箱最多只能发送一个附件，163邮箱可以发送多个
        //任何邮箱，附件不能太大，小于1M
        private void add_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDlg = new OpenFileDialog();
            fileDlg.Filter = "(*.*)|*.*";
            fileDlg.InitialDirectory = "C://";
            fileDlg.RestoreDirectory = true;

            fileDlg.ShowDialog();
            String fileName = fileDlg.FileName.Trim();

            Attachment a =new Attachment(fileName, System.Net.Mime.MediaTypeNames.Application.Octet);

            /*
            //MIME协议下的一个对象，用以设置附件的创建时间，修改时间以及读取时间  
            System.Net.Mime.ContentDisposition disposition = a.ContentDisposition;
            disposition.CreationDate = System.IO.File.GetCreationTime(fileName);
            disposition.ModificationDate = System.IO.File.GetLastWriteTime(fileName);
            disposition.ReadDate = System.IO.File.GetLastAccessTime(fileName);
             * */

            
                mm.Attachments.Add(a);
                MessageBox.Show("已添加");
            
        }

        private void Sendbtn_Click(object sender, EventArgs e)
        {
            mailDes = mailtoBox.Text.Trim();
            toAddr = new MailAddress(mailDes);
            mm.To.Add(toAddr);


            mm.Subject = subject.Text;
            mm.Body = Content.Text;

            try
            {
                client.Send(mm);
                MessageBox.Show("发送成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show("发送失败： " + ex.ToString());

            }
        }
    }
}
