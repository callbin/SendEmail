using System;
using System.Collections.Generic;
using System.Text;

namespace EmailDAL
{
    public class Fax_Recv_BillInf
    {
        public Fax_Recv_BillInf()
		{}
		#region Model
		private string _iappcode="";
		private int _sysid=0;
		private int _seqno=0;
		private string _subject="";
		private string _callernum="";
		private string _faxnum="";
		private string _receivetime="";
		private string _faxfilepath="";
		private string _faxfile="";
		private int _receivepages=0;
		private string _servername="";
		private int _issync=0;
		private int _isemail=0;
		private int _issms=0;
		private int _isview=0;
		private int _isdownload=0;
		private int _downloadtimes=0;
		private string _downloaddate="";
		private int _isdelete=0;
		private int _doflag=0;
		private string _dokey="";
		private string _crdate="";
		private int _sts=0;
		/// <summary>
		/// 
		/// </summary>
		public string IAppCode
		{
			set{ _iappcode=value;}
			get{return _iappcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int SysID
		{
			set{ _sysid=value;}
			get{return _sysid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int SeqNo
		{
			set{ _seqno=value;}
			get{return _seqno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Subject
		{
			set{ _subject=value;}
			get{return _subject;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CallerNum
		{
			set{ _callernum=value;}
			get{return _callernum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FaxNum
		{
			set{ _faxnum=value;}
			get{return _faxnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReceiveTime
		{
			set{ _receivetime=value;}
			get{return _receivetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FaxFilePath
		{
			set{ _faxfilepath=value;}
			get{return _faxfilepath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FaxFile
		{
			set{ _faxfile=value;}
			get{return _faxfile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ReceivePages
		{
			set{ _receivepages=value;}
			get{return _receivepages;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ServerName
		{
			set{ _servername=value;}
			get{return _servername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsSync
		{
			set{ _issync=value;}
			get{return _issync;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsEmail
		{
			set{ _isemail=value;}
			get{return _isemail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsSms
		{
			set{ _issms=value;}
			get{return _issms;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsView
		{
			set{ _isview=value;}
			get{return _isview;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsDownload
		{
			set{ _isdownload=value;}
			get{return _isdownload;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int DownloadTimes
		{
			set{ _downloadtimes=value;}
			get{return _downloadtimes;}
		}
		/// <summary>
		/// 
		/// </summary>
        public string DownloadDate
		{
			set{ _downloaddate=value;}
			get{return _downloaddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsDelete
		{
			set{ _isdelete=value;}
			get{return _isdelete;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int DoFlag
		{
			set{ _doflag=value;}
			get{return _doflag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DoKey
		{
			set{ _dokey=value;}
			get{return _dokey;}
		}
		/// <summary>
		/// 
		/// </summary>
        public string CrDate
		{
			set{ _crdate=value;}
			get{return _crdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Sts
		{
			set{ _sts=value;}
			get{return _sts;}
		}
		#endregion Model
        /// <summary>
        /// 目标服务器
        /// </summary>
        private string _objservername = "";
        public string ObjServerName
        {
            get { return this._objservername; }
            set { this._objservername = value; }
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
        /// <summary>
        /// 
        /// </summary>
        private int _holdtime = 0;
        public int HoldTime
        {
            set { _holdtime = value; }
            get { return _holdtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        private string _recvtime = "";
        public string RecvTime
        {
            set { _recvtime = value; }
            get { return _recvtime; }
        }
    }
}
