using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Fax.EmailDAL;
using Fax.Common;

using System.Threading;

namespace ytSendMail
{
    public partial class frmSendMail : Form
    {
        public frmSendMail()
        {
            InitializeComponent();
        }

        private string sysName = string.Empty;  //系统名称
        private string exitPwd = string.Empty;  //退出密码
        private int maxLogLines = 0;            //最大日志行数
        private int rows = 0;                   //提取记录数
        private int mailCount = 0;            //当前日志行数
        private string logInfo = string.Empty;  //日志信息
        private string connString = string.Empty;//数据库连接字符串
        private int total = 0;   //发送邮件数量
        private int succeed = 0;
        private int failed = 0;
        private string root = string.Empty;

        private Mail_Send_NodeInf nodeInfo = null;
        private Mail_Send_NodeDb nodeDb = null;

        private DateTime lastSendTime = DateTime.Now;

        private DataSet dsMailList = null;

        private Thread workThread = null;

        /// <summary>
        /// 页面初始化
        /// </summary>
        private void Init()
        {
            //显示标题文本
            this.sysName = ytDACConfig.GetItemByKey("SysName");
            this.Text = ytDACConfig.GetSystemName_V2();

            //日志最大行数
            this.maxLogLines = int.Parse(ytDACConfig.GetItemByKey("MaxLogLines"));

            //每次取的记录数
            this.rows = int.Parse(ytDACConfig.GetItemByKey("Rows"));

            //托盘图标
            this.notifyIcon.Visible = false;
            this.notifyIcon.Text = this.sysName;

            //数据库连接字符串
            this.connString = ytDACConfig.GetConnectionString();

            this.root = ytDACConfig.GetItemByKey("RootPath");
        }

        private void Send()
        {
            while (true)
            {
                lastSendTime = DateTime.Now;

                try
                {
                    nodeDb = new Mail_Send_NodeDb();
                    this.dsMailList = nodeDb.Mail_Send_GetList(this.rows);
                    if (this.dsMailList != null && this.dsMailList.Tables[0].Rows.Count > 0)
                    {
                        logInfo = string.Format("读取到{0}条记录", this.dsMailList.Tables[0].Rows.Count);
                        this.SetLog(logInfo);
                        for (int i = 0; i < this.dsMailList.Tables[0].Rows.Count; i++)
                        {
                            nodeInfo = new Mail_Send_NodeInf();

                            nodeInfo.EmailID = int.Parse(this.dsMailList.Tables[0].Rows[i]["EmailID"].ToString());

                            nodeInfo.MailServer = this.dsMailList.Tables[0].Rows[i]["MailServer"].ToString();
                            nodeInfo.UserName = this.dsMailList.Tables[0].Rows[i]["UserName"].ToString();
                            nodeInfo.Pwd = this.dsMailList.Tables[0].Rows[i]["PassWord"].ToString();

                            nodeInfo.MailList = this.dsMailList.Tables[0].Rows[i]["MailList"].ToString();
                            nodeInfo.Header = this.dsMailList.Tables[0].Rows[i]["Header"].ToString();
                            if (nodeInfo.Header.Length > 0)
                            {
                                nodeInfo.Body += nodeInfo.Header + "\r\n\r\n";
                            }
                            nodeInfo.Content = this.dsMailList.Tables[0].Rows[i]["Contents"].ToString();
                            if (nodeInfo.Content.Length > 0)
                            {
                                nodeInfo.Body += nodeInfo.Content + "\r\n\r\n";
                            }
                            nodeInfo.Footer = this.dsMailList.Tables[0].Rows[i]["Footer"].ToString();
                            if (nodeInfo.Footer.Length > 0)
                            {
                                nodeInfo.Body += nodeInfo.Footer;
                            }
                            nodeInfo.MailSubject = this.dsMailList.Tables[0].Rows[i]["MailSubject"].ToString();
                            string attachment = this.dsMailList.Tables[0].Rows[i]["Attachment"].ToString();
                            if (!string.IsNullOrEmpty(attachment))
                            {
                                if (!Common.IsUrl(attachment))
                                {
                                    attachment = root + attachment;
                                }
                            }
                            else
                            {
                                attachment = "";
                            }
                            nodeInfo.Attachment = attachment;
                            nodeInfo.FromName = this.dsMailList.Tables[0].Rows[i]["FromName"].ToString();
                            nodeInfo.Times = int.Parse(this.dsMailList.Tables[0].Rows[i]["Times"].ToString());
                            string EmailType = this.dsMailList.Tables[0].Rows[i]["EmailType"].ToString();

                            try
                            {
                                LogHelper.Info(string.Format("开始发送 {0}",nodeInfo.EmailID));

                                Mail.SendJmail(nodeInfo.MailServer, nodeInfo.UserName, nodeInfo.Pwd, nodeInfo.MailList, nodeInfo.MailSubject, nodeInfo.Body, nodeInfo.Attachment, nodeInfo.FromName,EmailType);

                                nodeDb.Mail_Send_UpdateSts(nodeInfo.EmailID, 1);

                                logInfo = string.Format("[{0}]:成功发送到[{1}]！", nodeInfo.EmailID, nodeInfo.MailList);
                                this.SetLog(logInfo);
                                this.pSucceed.Text = (++this.succeed).ToString();
                                this.pTotal.Text = (++this.total).ToString();
                            }
                            catch (Exception ex)
                            {
                                logInfo = string.Format("[{0}]:发送到[{1}]失败,第{3}次失败，失败原因：{2}", nodeInfo.EmailID, nodeInfo.MailList, ex.Message, nodeInfo.Times);
                                this.SetLog(logInfo);

                                if (nodeInfo.Times >= 4)
                                {
                                    nodeDb.Mail_Send_UpdateSts(nodeInfo.EmailID, -1);
                                    this.pFailed.Text = (++this.failed).ToString();
                                    this.pTotal.Text = (++this.total).ToString();
                                }
                            }
                        }
                    }
                    else
                    {
                        logInfo = string.Format("读取到0条记录");
                        this.SetLog(logInfo);
                        Thread.Sleep(1000);
                    }
                }
                catch (Exception ex)
                {
                    logInfo = ex.ToString();
                    this.SetLog(logInfo);
                    continue;
                }
            }
        }

        delegate void somedle(string logInfo);
        /// <summary>
        /// 记录日志
        /// </summary>
        /// <param name="_msg">日志信息</param>
        private void SetLog(string logInfo)
        {
            if (this.txtLog.InvokeRequired)
            {
                somedle _dle = new somedle(this.SetLog);
                this.Invoke(_dle, new object[] { logInfo });
            }
            else
            {
                this.txtLog.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "-" + logInfo + Environment.NewLine);
                if (this.txtLog.Text.Length > 10000)
                {
                    this.txtLog.Clear();
                }

                //if (this.mailCount < this.maxLogLines)
                //{
                //    this.mailCount++;
                //}
                //else
                //{
                //    this.txtLog.Text = "";
                //    this.mailCount = 0;
                //}
                //if (logInfo.Length > 0)
                //    this.txtLog.Text = logInfo + "\r\n" + this.txtLog.Text;

                LogHelper.Info(logInfo);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                this.Init();

                workThread = new Thread(new ThreadStart(Send));
                workThread.IsBackground = true;
                workThread.Start();
            }
            catch
            {
                MessageBox.Show("程序初始化失败！");
            }
        }

        private void frmSendMail_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                workThread.Abort();
            }
            catch { }
        }

        private void btnHid_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            this.notifyIcon.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (this.txtPwd.Text.Equals(exitPwd))
            {
                this.Close();
                this.notifyIcon.Visible = false;
            }
            else
            {
                MessageBox.Show("退出密码不正确！", this.sysName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtPwd.Focus();
            }
        }

        private void tsmiDisplay_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.notifyIcon.Visible = false;
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmConfig form = new frmConfig();
            form.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lastSendTime.AddMinutes(10) < DateTime.Now)
            {
                LogHelper.Info("工作线程已两分钟没有响应，自动重启");
                Environment.Exit(0);
            }
        }

        private void 测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestEamil te = new TestEamil();
            te.ShowDialog();
        }
    }
}