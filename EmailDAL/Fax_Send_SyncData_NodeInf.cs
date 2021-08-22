//********************************************************************************************************
//Copyright(C) 2008  远特技术部 
//文件名：Fax_Send_SyncData_NodeInf.cs
//作  者：朱翔
//日　期：2008/05/02
//描　述：[传真数据同步节点]的数据封装类
//版　本：2.00
//修改历史记录
//版　本　　　　　修改时间　　　　　　修改人　　　　　变更内容
//  2.00       2008/05/02              朱翔　　　　　　新建
//             2008/05/04              朱翔            结构修改
//********************************************************************************************************

using System;
using System.Collections.Generic;
using System.Text;

namespace EmailDAL
{
    public class Fax_Send_SyncData_NodeInf
    {
        public Fax_Send_SyncData_NodeInf()
        { }
        /// <summary>
        /// 应用编号
        /// </summary>
        private string _iappcode = "";
        public string IAppCode
        {
            get { return this._iappcode; }
            set { this._iappcode = value; }
        }
        /// <summary>
        /// 流程号
        /// </summary>
        private string _flowcode = "";
        public string FlowCode
        {
            get { return this._flowcode; }
            set { this._flowcode = value; }
        }
        /// <summary>
        /// 发送类型
        /// </summary>
        private int _sendtype = 1;
        public int SendType
        {
            get { return this._sendtype; }
            set { this._sendtype = value; }
        }

        /// <summary>
        /// 接收传真标示
        /// </summary>
        private int _sysid = 0;
        public int SysID
        {
            get { return this._sysid; }
            set { this._sysid = value; }
        }

        /// <summary>
        /// 批次号
        /// </summary>
        private string _batchno = "";
        public string BatchNo
        {
            get { return this._batchno; }
            set { this._batchno = value; }
        }

        /// <summary>
        /// 用户系统编号
        /// </summary>
        private int _seqno = 0;
        public int SeqNo
        {
            get { return this._seqno; }
            set { this._seqno = value; }
        }

        /// <summary>
        /// 主叫号码
        /// </summary>
        private string _callernum = "";
        public string CallerNum
        {
            get { return this._callernum; }
            set { this._callernum = value; }
        }

        /// <summary>
        /// 被叫号码
        /// </summary>
        private string _faxnum = "";
        public string FaxNum
        {
            get { return this._faxnum; }
            set { this._faxnum = value; }
        }

        /// <summary>
        /// 显示本地传真机上的名称
        /// </summary>
        private string _localcsid = "";
        public string LocalCSID
        {
            get { return this._localcsid; }
            set { this._localcsid = value; }
        }

        /// <summary>
        /// 重发间隔
        /// </summary>
        private int _resenddelay = 0;
        public int ResendDelay
        {
            get { return this._resenddelay; }
            set { this._resenddelay = value; }
        }

        /// <summary>
        /// 重发次数
        /// </summary>
        private int _resendtimes = 0;
        public int ResendTimes
        {
            get { return this._resendtimes; }
            set { this._resendtimes = value; }
        }

        /// <summary>
        /// 发送优先级
        /// </summary>
        private int _priority = 0;
        public int Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        /// <summary>
        /// 发送时间
        /// </summary>
        private string _sendtime = DateTime.Now.ToString();
        public string SendTime
        {
            get { return this._sendtime; }
            set { this._sendtime = value; }
        }

        /// <summary>
        /// 提交时间
        /// </summary>
        private string _submittime = DateTime.Now.ToString();
        public string SubmitTime
        {
            get { return this._submittime; }
            set { this._submittime = value; }
        }

        /// <summary>
        /// 发送类型
        /// </summary>
        private int _clsid = 0;
        public int ClsID
        {
            get { return this._clsid; }
            set { this._clsid = value; }
        }

        /// <summary>
        /// 转换后的文件路径
        /// </summary>
        private string _remotefilepath = "";
        public string RemoteFilePath
        {
            get { return this._remotefilepath; }
            set { this._remotefilepath = value; }
        }

        /// <summary>
        /// 转换后的文件名
        /// </summary>
        private string _remotefile = "";
        public string RemoteFile
        {
            get { return this._remotefile; }
            set { this._remotefile = value; }
        }

        /// <summary>
        /// 传真页数
        /// </summary>
        private int _faxpages = 0;
        public int FaxPages
        {
            get { return this._faxpages; }
            set { this._faxpages = value; }
        }

        /// <summary>
        /// 转换文件存放服务器
        /// </summary>
        private string _transervername = "";
        public string TranServerName
        {
            get { return this._transervername; }
            set { this._transervername = value; }
        }

        /// <summary>
        /// 操作区别码
        /// </summary>
        private string _dokey = "";
        public string DoKey
        {
            get { return this._dokey; }
            set { this._dokey = value; }
        }

        /// <summary>
        /// 操作标志
        /// </summary>
        private int _doflag = 0;
        public int DoFlag
        {
            get { return this._doflag; }
            set { this._doflag = value; }
        }

        /// <summary>
        /// 创建日期
        /// </summary>
        private string _crdate = DateTime.Now.ToString();
        public string CrDate
        {
            get { return this._crdate; }
            set { this._crdate = value; }
        }

        /// <summary>
        /// 传真状态
        /// </summary>
        private int _sts = 0;
        public int Sts
        {
            get { return this._sts; }
            set { this._sts = value; }
        }

        /// <summary>
        /// 失败原因
        /// </summary>
        private int _failedreason = 0;
        public int FailedReason
        {
            get { return this._failedreason; }
            set { this._failedreason = value; }
        }

        /// <summary>
        /// 重试次数
        /// </summary>
        private int _retrytimes = 0;
        public int RetryTimes
        {
            get { return this._retrytimes; }
            set { this._retrytimes = value; }
        }

        /// <summary>
        /// 发送结束时间
        /// </summary>
        private string _sendendtime = DateTime.Now.ToString();
        public string SendEndTime
        {
            get { return this._sendendtime; }
            set { this._sendendtime = value; }
        }

        /// <summary>
        /// 发送服务器
        /// </summary>
        private string _sendservername = "";
        public string SendServerName
        {
            get { return this._sendservername; }
            set { this._sendservername = value; }
        }

        /// <summary>
        /// 当前状态：-1 需要装载数据；0 可以同步；1 正在同步；2 可以同步数据；
        /// </summary>
        private int _staus = -1;
        public int Staus
        {
            get { return this._staus; }
            set { this._staus = value; }
        }
        /// <summary>
        /// 文件路径
        /// </summary>
        private string _filepath = "";
        public string FilePath
        {
            get { return this._filepath; }
            set { this._filepath = value; }
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

    }
}
