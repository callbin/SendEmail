//==================================================================
// Copyright (C) 2008 远特技术部
// 文件名: Mail_Send_NodeInf.cs
// 作 者：朱翔
// 日 期：2008/05/22
// 描 述：发送邮件数据封装类
// 版 本：2.00

//==================================================================

using System;
using System.Collections.Generic;
using System.Text;

namespace Fax.EmailDAL
{
    public class Mail_Send_NodeInf
    {
        public Mail_Send_NodeInf()
        { }

        private string _mailServer = string.Empty;
        private string _userName = string.Empty;
        private string _pwd = string.Empty;
        private int _emailID = 0;
        private int _emailType = 0;
        private string _body = string.Empty;
        private string _contentTemplate = string.Empty;
        private int _sts = 0;
        private string _mailList = string.Empty;
        private string _mailSubject = string.Empty;
        private string _header = string.Empty;
        private string _footer = string.Empty;
        private string _content = string.Empty;
        private string _attachment = string.Empty;
        private string _fromName = string.Empty;

        /// <summary>
        /// 邮件服务器
        /// </summary>
        public string MailServer
        {
            get { return this._mailServer; }
            set { this._mailServer = value; }
        }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        /// <summary>
        /// 密码
        /// </summary>
        public string Pwd
        {
            get { return this._pwd; }
            set { this._pwd = value; }
        }

        /// <summary>
        /// 邮件编号
        /// </summary>
        public int EmailID
        {
            get { return this._emailID; }
            set { this._emailID = value; }
        }

        /// <summary>
        /// 邮件类型
        /// </summary>
        public int EmailType
        {
            get { return this._emailType; }
            set { this._emailType = value; }
        }

        /// <summary>
        /// 邮件内容
        /// </summary>
        public string Body
        {
            get { return this._body; }
            set { this._body = value; }
        }

        /// <summary>
        /// 邮件模板
        /// </summary>
        public string ContentTemplate
        {
            get { return this._contentTemplate; }
            set { this._contentTemplate = value; }
        }

        /// <summary>
        /// 状态
        /// </summary>
        public int Sts
        {
            get { return this._sts; }
            set { this._sts = value; }
        }

        /// <summary>
        /// 邮箱列表
        /// </summary>
        public string MailList
        {
            get { return this._mailList; }
            set { this._mailList = value; }
        }

        /// <summary>
        /// 邮件主题
        /// </summary>
        public string MailSubject
        {
            get { return this._mailSubject; }
            set { this._mailSubject = value; }
        }

        /// <summary>
        /// 页眉
        /// </summary>
        public string Header
        {
            get { return this._header; }
            set { this._header = value; }
        }

        /// <summary>
        /// 页脚
        /// </summary>
        public string Footer
        {
            get { return this._footer; }
            set { this._footer = value; }
        }

        /// <summary>
        /// 内容
        /// </summary>
        public string Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        /// <summary>
        /// 附件
        /// </summary>
        public string Attachment
        {
            get { return this._attachment; }
            set { this._attachment = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string FromName
        {
            get { return this._fromName; }
            set { this._fromName = value; }
        }

        private int _times = 0;
        public int Times
        {
            get { return _times; }
            set { _times = value; }
        }
    }
}
