namespace ytSendMail
{
    partial class frmSendMail
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSendMail));
            this.stsBar = new System.Windows.Forms.StatusStrip();
            this.tssTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.pTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssSucceed = new System.Windows.Forms.ToolStripStatusLabel();
            this.pSucceed = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssFailed = new System.Windows.Forms.ToolStripStatusLabel();
            this.pFailed = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHid = new System.Windows.Forms.Button();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.btnConfig = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.测试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stsBar.SuspendLayout();
            this.cmsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // stsBar
            // 
            this.stsBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssTotal,
            this.pTotal,
            this.tssSucceed,
            this.pSucceed,
            this.tssFailed,
            this.pFailed});
            this.stsBar.Location = new System.Drawing.Point(0, 377);
            this.stsBar.Name = "stsBar";
            this.stsBar.Size = new System.Drawing.Size(512, 22);
            this.stsBar.TabIndex = 10;
            // 
            // tssTotal
            // 
            this.tssTotal.Name = "tssTotal";
            this.tssTotal.Size = new System.Drawing.Size(101, 17);
            this.tssTotal.Text = "发送邮件总数量：";
            // 
            // pTotal
            // 
            this.pTotal.AutoSize = false;
            this.pTotal.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.pTotal.Name = "pTotal";
            this.pTotal.Size = new System.Drawing.Size(40, 17);
            this.pTotal.Text = "0";
            // 
            // tssSucceed
            // 
            this.tssSucceed.Name = "tssSucceed";
            this.tssSucceed.Size = new System.Drawing.Size(65, 17);
            this.tssSucceed.Text = "成功数量：";
            // 
            // pSucceed
            // 
            this.pSucceed.AutoSize = false;
            this.pSucceed.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.pSucceed.Name = "pSucceed";
            this.pSucceed.Size = new System.Drawing.Size(40, 17);
            this.pSucceed.Text = "0";
            // 
            // tssFailed
            // 
            this.tssFailed.Name = "tssFailed";
            this.tssFailed.Size = new System.Drawing.Size(65, 17);
            this.tssFailed.Text = "失败数量：";
            // 
            // pFailed
            // 
            this.pFailed.AutoSize = false;
            this.pFailed.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.pFailed.Name = "pFailed";
            this.pFailed.Size = new System.Drawing.Size(40, 17);
            this.pFailed.Text = "0";
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.cmsMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Visible = true;
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDisplay,
            this.测试ToolStripMenuItem});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(153, 70);
            // 
            // tsmiDisplay
            // 
            this.tsmiDisplay.Name = "tsmiDisplay";
            this.tsmiDisplay.Size = new System.Drawing.Size(152, 22);
            this.tsmiDisplay.Text = "显示主窗体";
            this.tsmiDisplay.Click += new System.EventHandler(this.tsmiDisplay_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(200, 349);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHid
            // 
            this.btnHid.Location = new System.Drawing.Point(425, 349);
            this.btnHid.Name = "btnHid";
            this.btnHid.Size = new System.Drawing.Size(75, 23);
            this.btnHid.TabIndex = 7;
            this.btnHid.Text = "隐藏";
            this.btnHid.UseVisualStyleBackColor = true;
            this.btnHid.Click += new System.EventHandler(this.btnHid_Click);
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(21, 357);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(53, 12);
            this.lblPwd.TabIndex = 8;
            this.lblPwd.Text = "退出密码";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(80, 351);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(114, 21);
            this.txtPwd.TabIndex = 6;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(0, -1);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(510, 344);
            this.txtLog.TabIndex = 11;
            this.txtLog.Text = "";
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(344, 349);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(75, 23);
            this.btnConfig.TabIndex = 12;
            this.btnConfig.Text = "配置";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // 测试ToolStripMenuItem
            // 
            this.测试ToolStripMenuItem.Name = "测试ToolStripMenuItem";
            this.测试ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.测试ToolStripMenuItem.Text = "测试";
            this.测试ToolStripMenuItem.Click += new System.EventHandler(this.测试ToolStripMenuItem_Click);
            // 
            // frmSendMail
            // 
            this.AcceptButton = this.btnExit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 399);
            this.ControlBox = false;
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.stsBar);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHid);
            this.Controls.Add(this.txtPwd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSendMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSendMail_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.stsBar.ResumeLayout(false);
            this.stsBar.PerformLayout();
            this.cmsMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stsBar;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiDisplay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHid;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.ToolStripStatusLabel tssTotal;
        private System.Windows.Forms.ToolStripStatusLabel pTotal;
        private System.Windows.Forms.ToolStripStatusLabel tssSucceed;
        private System.Windows.Forms.ToolStripStatusLabel pSucceed;
        private System.Windows.Forms.ToolStripStatusLabel tssFailed;
        private System.Windows.Forms.ToolStripStatusLabel pFailed;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 测试ToolStripMenuItem;
    }
}

