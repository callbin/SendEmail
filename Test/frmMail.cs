using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using jmail;

namespace Test
{
    public partial class frmMail : Form
    {
        public frmMail()
        {
            InitializeComponent();
        }

        private void frmMail_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                jmail.Message jmessage = new jmail.MessageClass();
                jmessage.Charset = "GB2312";
                //jmessage.From = "sina@sme.sina.net";
                jmessage.From = "ytfax@yutong.com";
                jmessage.FromName = "";
                jmessage.Subject = "爱的方式大幅";
                jmessage.AddRecipient("zhuxiang@yuantel.com", "", "");
                jmessage.Body = "爱的方式大幅";
                jmessage.AddAttachment(@"D:\新浪VIP邮箱传真.doc", false, null);
                //string url = "http://211.157.111.150:8080/FaxFile/201009/26/recv/fzr01920100926173118.tif";// "http://vd.51cto.com/adimage.php?filename=728x90_15.jpg&contenttype=jpeg";//"http://211.157.111.150/RecFile/201009/26/recv/fzr01920100926173118.tif";
                //jmessage.AddURLAttachment(url, url.Substring(url.LastIndexOf("/") + 1), false, null);
                jmessage.MailServerUserName = "ytfax@yutong.com";
                jmessage.MailServerPassWord = "*&*&())(HHT*&^%%";
                jmessage.Send("mail.yutong.com", false);
                //jmessage.MailServerUserName = "sina@sme.sina.net";
                //jmessage.MailServerPassWord = "1111";
                //jmessage.Send("smtp.sinanet.com", false);
                jmessage.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            POP3Class mail = new POP3Class();
            mail.Connect("ytfax@yutong.com", "*&*&())(HHT*&^%%", "mail.yutong.com", 6534);
        }
    }
}

