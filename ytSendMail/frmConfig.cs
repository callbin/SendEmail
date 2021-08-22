using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Fax.Common;

namespace ytSendMail
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
        }

        string logCount = string.Empty;
        string rowCount = string.Empty;
        string exitPwd = string.Empty;
        string serverIP = string.Empty;

        string path = Application.ExecutablePath + @".config";
        XmlDocument doc = null;
        XmlNodeList nodeList = null;
        XmlNodeList databaseList = null;

        private void frmConfig_Load(object sender, EventArgs e)
        {
            try
            {
                doc = new XmlDocument();
                doc.Load(path);
                nodeList = doc.SelectNodes("configuration/appSettings/add");
                foreach (XmlNode node in nodeList)
                {
                    if (node.NodeType != XmlNodeType.Comment)
                    {
                        switch (node.Attributes["key"].Value)
                        {
                            case "MaxLogLines":
                                logCount = node.Attributes["value"].Value;
                                break;
                            case "Rows":
                                rowCount = node.Attributes["value"].Value;
                                break;
                            case "ExitPwd":
                                exitPwd = node.Attributes["value"].Value;
                                break;
                            default:
                                break;
                        }
                    }
                }
                databaseList = doc.SelectNodes("configuration/connectionStrings/add");
                foreach (XmlNode node in databaseList)
                {
                    if (node.NodeType != XmlNodeType.Comment)
                    {
                        if (node.Attributes["name"].Value == "ytMail")
                        {
                            serverIP = node.Attributes["connectionString"].Value;
                        }
                    }
                }

                this.txtLogCount.Text = logCount;
                this.txtRowCount.Text = rowCount;
                this.txtExitPwd.Text = exitPwd;
                this.txtServerIP.Text = serverIP;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                logCount = this.txtLogCount.Text;
                if (!Common.IsNumber(logCount))
                {
                    MessageBox.Show("显示日志最大行数只能为数字！");
                    this.txtLogCount.SelectAll();
                    return;
                }
                rowCount = this.txtRowCount.Text;
                if (!Common.IsNumber(rowCount))
                {
                    MessageBox.Show("每次提取记录条数只能为数字！");
                    this.txtRowCount.SelectAll();
                    return;
                }
                exitPwd = this.txtExitPwd.Text;
                serverIP = this.txtServerIP.Text;

                foreach (XmlNode node in nodeList)
                {
                    if (node.NodeType != XmlNodeType.Comment)
                    {
                        switch (node.Attributes["key"].Value)
                        {
                            case "MaxLogLines":
                                node.Attributes["value"].Value = logCount;
                                break;
                            case "Rows":
                                node.Attributes["value"].Value = rowCount;
                                break;
                            case "ExitPwd":
                                node.Attributes["value"].Value = exitPwd;
                                break;
                            default:
                                break;
                        }
                    }
                }
                foreach (XmlNode node in databaseList)
                {
                    if (node.NodeType != XmlNodeType.Comment)
                    {
                        if (node.Attributes["name"].Value == "ytMail")
                        {
                            node.Attributes["connectionString"].Value = serverIP;
                        }
                    }
                }
                doc.Save(path);
                this.Close();
                if (MessageBox.Show("修改成功，重启程序后生效，是否立即重启？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Restart();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}