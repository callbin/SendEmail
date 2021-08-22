//==================================================================
// Copyright (C) 2008 远特技术部
// 文件名: Mail_Rec_NodeInf.cs
// 作 者：朱翔
// 日 期：2008/05/26
// 描 述：接收邮件数据封装类
// 版 本：1.00
//==================================================================

using System;
using System.Collections.Generic;
using System.Text;

namespace Fax.EmailDAL
{
    public class Mail_Rec_NodeInf
    {
        public Mail_Rec_NodeInf()
        { }

        /// <summary>
        /// 邮件编号
        /// </summary>
        private int _emailID = 0;
        public int EmailID
        {
            get { return this._emailID; }
            set { this._emailID = value; }
        }

        /// <summary>
        /// 发件人地址
        /// </summary>
        private string _senderMail = string.Empty;
        public string SenderMail
        {
            get { return this._senderMail; }
            set { this._senderMail = value; }
        }

        /// <summary>
        /// 发件人名称
        /// </summary>
        private string _senderName = string.Empty;
        public string SenderName
        {
            get { return this._senderName; }
            set { this._senderName = value; }
        }

        /// <summary>
        /// 收件人地址
        /// </summary>
        private string _receiverMail = string.Empty;
        public string ReceiverMail
        {
            get { return this._receiverMail; }
            set { this._receiverMail = value; }
        }

        /// <summary>
        /// 收件人名称
        /// </summary>
        private string _receiverName = string.Empty;
        public string ReceiverName
        {
            get { return this._receiverName; }
            set { this._receiverName = value; }
        }

        /// <summary>
        /// 状态 1.转换成功；2.用户信息不存在；3.账号余额不足
        /// </summary>
        private int _sts = 0;
        public int Sts
        {
            get { return this._sts; }
            set { this._sts = value; }
        }

        /// <summary>
        /// 附件名称
        /// </summary>
        private string _fileName = string.Empty;
        public string FileName
        {
            get { return this._fileName; }
            set { this._fileName = value; }
        }

        /// <summary>
        /// 附件路径
        /// </summary>
        private string _filePath = string.Empty;
        public string FilePath
        {
            get { return this._filePath; }
            set { this._filePath = value; }
        }

        /// <summary>
        /// 被叫传真号码
        /// </summary>
        private string _faxNum = string.Empty;
        public string FaxNum
        {
            get { return this._faxNum; }
            set { this._faxNum = value; }
        }

        /// <summary>
        /// 主题
        /// </summary>
        private string _subject = string.Empty;
        public string Subject
        {
            get { return this._subject; }
            set { this._subject = value; }
        }

        /// <summary>
        /// 发送时间
        /// </summary>
        private DateTime _sendTime = DateTime.Now;
        public DateTime SendTime
        {
            get { return this._sendTime; }
            set { this._sendTime = value; }
        }

        /// <summary>
        /// 区号
        /// </summary>
        private string _areaID = string.Empty;
        public string AreaID
        {
            get { return this._areaID; }
            set { this._areaID = value; }
        }

        /// <summary>
        /// 文件内容
        /// </summary>
        private string _fileContent = string.Empty;
        public string FileContent
        {
            get { return this._fileContent; }
            set { this._fileContent = value; }
        }

        /// <summary>
        /// 文件大小
        /// </summary>
        private int _fileSize = 0;
        public int FileSize
        {
            get { return this._fileSize; }
            set { this._fileSize = value; }
        }
    }
}
