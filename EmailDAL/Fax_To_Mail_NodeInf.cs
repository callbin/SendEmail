//********************************************************************************************************
//Copyright(C) 2008  远特技术部 
//文件名：Fax_To_Mail_NodeInf.cs
//作  者：zhuxiang
//日　期：2008/05/30
//描　述：传真转邮件Model
//版　本：2.00
//********************************************************************************************************

using System;
using System.Collections.Generic;
using System.Text;

namespace Fax.EmailDAL
{
    public class Fax_To_Mail_NodeInf
    {
        public Fax_To_Mail_NodeInf()
        { }

        /// <summary>
        /// 通道编号
        /// </summary>
        private int _channelID = -1;
        public int ChannelID
        {
            get { return this._channelID; }
            set { this._channelID = value; }
        }

        /// <summary>
        /// 模板编号
        /// </summary>
        private int _templateID = -1;
        public int TemplateID
        {
            get { return this._templateID; }
            set { this._templateID = value; }
        }

        /// <summary>
        /// 用户编号
        /// </summary>
        private int _seqNo = -1;
        public int SeqNo
        {
            get { return this._seqNo; }
            set { this._seqNo = value; }
        }

        /// <summary>
        /// 邮件类型
        /// </summary>
        private int _emailType = 0;
        public int EmailType
        {
            get { return this._emailType; }
            set { this._emailType = value; }
        }

        /// <summary>
        /// 邮件列表
        /// </summary>
        private string _emailList = string.Empty;
        public string EmailList
        {
            get { return this._emailList; }
            set { this._emailList = value; }
        }

        /// <summary>
        /// 标题
        /// </summary>
        private string _emailTitle = string.Empty;
        public string EmailTitle
        {
            get { return this._emailTitle; }
            set { this._emailTitle = value; }
        }

        /// <summary>
        /// 文件名
        /// </summary>
        private string _fileName = string.Empty;
        public string FileName
        {
            get { return this._fileName; }
            set { this._fileName = value; }
        }

        /// <summary>
        /// 文件路径
        /// </summary>
        private string _filePath = string.Empty;
        public string FilePath
        {
            get { return this._filePath; }
            set { this._filePath = value; }
        }

        /// <summary>
        /// 批次号
        /// </summary>
        private string _batchNo = string.Empty;
        public string BatchNo
        {
            get { return this._batchNo; }
            set { this._batchNo = value; }
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
        /// 接收时间
        /// </summary>
        private DateTime _recTime = DateTime.Now;
        public DateTime RecTime
        {
            get { return this._recTime; }
            set { this._recTime = value; }
        }

        /// <summary>
        /// 主叫号
        /// </summary>
        private string _callerNum = string.Empty;
        public string CallerNum
        {
            get { return this._callerNum; }
            set { this._callerNum = value; }
        }

        /// <summary>
        /// 被叫号
        /// </summary>
        private string _faxNum = string.Empty;
        public string FaxNum
        {
            get { return this._faxNum; }
            set { this._faxNum = value; }
        }
        /// <summary>
        /// 文件内容
        /// </summary>
        private string _filecontent = "";
        public string FileContent
        {
            get { return this._filecontent; }
            set { this._filecontent = value; }
        }
        /// <summary>
        /// 文件长度；
        /// </summary>
        private int _filesize = 0;
        public int FileSize
        {
            get { return this._filesize; }
            set { this._filesize = value; }
        }
        /// <summary>
        /// 接收服务器上文件长度；
        /// </summary>
        private int _rfilesize = 0;
        public int RFileSize
        {
            get { return this._rfilesize; }
            set { this._rfilesize = value; }
        }
    }
}
