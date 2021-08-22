using System;
using System.Collections.Generic;
using System.Text;

namespace EmailDAL
{
    public class Fax_Recv_Bill_SyncInf
    {
        public Fax_Recv_Bill_SyncInf()
        { }
        #region Model
        private int _sysid = 0;
        private string _iappcode = "";
        private int _seqno = 0;
        private int _recvflag = 0;
        private string _recvfilepath = "";
        private string _recvfile = "";
        private string _callednum = "";
        private string _calledext = "";
        private string _callernum = "";
        private int _recvpages = 0;
        private string _remotecsid = "";
        private string _recvtime = "";
        private int _holdtime = 0;
        private string _recvserver = "";
        private string _dokey = "";
        private int _doflag = 0;
        private string _crdate = "";
        /// <summary>
        /// 
        /// </summary>
        public int SysID
        {
            set { _sysid = value; }
            get { return _sysid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IAppCode
        {
            set { _iappcode = value; }
            get { return _iappcode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int SeqNo
        {
            set { _seqno = value; }
            get { return _seqno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int RecvFlag
        {
            set { _recvflag = value; }
            get { return _recvflag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RecvFilePath
        {
            set { _recvfilepath = value; }
            get { return _recvfilepath; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RecvFile
        {
            set { _recvfile = value; }
            get { return _recvfile; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CalledNum
        {
            set { _callednum = value; }
            get { return _callednum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CalledExt
        {
            set { _calledext = value; }
            get { return _calledext; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CallerNum
        {
            set { _callernum = value; }
            get { return _callernum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int RecvPages
        {
            set { _recvpages = value; }
            get { return _recvpages; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RemoteCSID
        {
            set { _remotecsid = value; }
            get { return _remotecsid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RecvTime
        {
            set { _recvtime = value; }
            get { return _recvtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int HoldTime
        {
            set { _holdtime = value; }
            get { return _holdtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RecvServer
        {
            set { _recvserver = value; }
            get { return _recvserver; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DoKey
        {
            set { _dokey = value; }
            get { return _dokey; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int DoFlag
        {
            set { _doflag = value; }
            get { return _doflag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CrDate
        {
            set { _crdate = value; }
            get { return _crdate; }
        }
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
        #endregion Model
    }
}
