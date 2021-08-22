using System;
using System.Collections.Generic;
using System.Text;

namespace EmailDAL
{
    public class Fax_Send_Bill_Node
    {
        public Fax_Send_Bill_Node()
        { }

        #region Model
        private string _iappcode="";
        private string _flowcode="";
        private string _batchno="";
        private string _refid="";
        private int _seqno;
        private int _compid;
        private string _callernum="";
        private string _faxnum="";
        private string _remotecsid="";
        private string _localcsid="";
        private string _subject="";
        private string _header="";
        private string _footer="";
        private string _receiver="";
        private string _receivercompany="";
        private string _mobilelist="";
        private string _emaillist="";
        private int _resenddelay=3;
        private int _resendtimes=3;
        private int _priority;
        private int _coverpageflag;
        private string _coverpage="";
        private DateTime _submittime;
        private DateTime _sendtime;
        private DateTime _datasynctime;
        private DateTime _sendendtime;
        private int _usedvalue;
        private int _seconds;
        private int _sendpages;
        private int _unfreezeflag;
        private int _freezeflag;
        private int _freeze;
        private int _unfreezetimes;
        private string _sendserevername="";
        private int _clsid;
        private int _isdelete;
        private int _doflag;
        private string _dokey="";
        private DateTime _crdate;
        private int _sts;
        private int _failedreason;

        private string _areaid="";
        private string _faxfile="";
        private string _userfile="";
        private string _transervername="";
        private string _sendVoice = "";
        private int _auditingFlag;
        /// <summary>
        /// 传真文件名
        /// </summary>
        public string FaxFile
        {
            set { _faxfile = value; }
            get { return _faxfile; }
        }
        /// <summary>
        /// 用户文件名
        /// </summary>
        public string UserFile
        {
            set { _userfile = value; }
            get { return _userfile; }
        }
        /// <summary>
        /// 转换服务器
        /// </summary>
        public string TranServerName
        {
            set { _transervername = value; }
            get { return _transervername; }
        }
        /// <summary>
        /// 主叫区号
        /// </summary>
        public string AreaID
        {
            set { _areaid = value; }
            get { return _areaid; }
        }
        /// <summary>
        /// 应用号
        /// </summary>
        public string IAppCode
        {
            set { _iappcode = value; }
            get { return _iappcode; }
        }
        /// <summary>
        /// 流程号
        /// </summary>
        public string FlowCode
        {
            set { _flowcode = value; }
            get { return _flowcode; }
        }
        /// <summary>
        /// 批次号
        /// </summary>
        public string BatchNo
        {
            set { _batchno = value; }
            get { return _batchno; }
        }
        /// <summary>
        /// 相关系统编号
        /// </summary>
        public string RefID
        {
            set { _refid = value; }
            get { return _refid; }
        }
        /// <summary>
        /// 用户系统编号
        /// </summary>
        public int SeqNo
        {
            set { _seqno = value; }
            get { return _seqno; }
        }
        /// <summary>
        /// 企业ID
        /// </summary>
        public int CompID
        {
            set { _compid = value; }
            get { return _compid; }
        }
        /// <summary>
        /// 主叫号码
        /// </summary>
        public string CallerNum
        {
            set { _callernum = value; }
            get { return _callernum; }
        }
        /// <summary>
        /// 被叫号码
        /// </summary>
        public string FaxNum
        {
            set { _faxnum = value; }
            get { return _faxnum; }
        }
        /// <summary>
        /// 对方传真上显示的发件人
        /// </summary>
        public string RemoteCSID
        {
            set { _remotecsid = value; }
            get { return _remotecsid; }
        }
        /// <summary>
        /// 显示本地传真机上的名称
        /// </summary>
        public string LocalCSID
        {
            set { _localcsid = value; }
            get { return _localcsid; }
        }
        /// <summary>
        /// 传真主题
        /// </summary>
        public string Subject
        {
            set { _subject = value; }
            get { return _subject; }
        }
        /// <summary>
        /// 页眉
        /// </summary>
        public string Header
        {
            set { _header = value; }
            get { return _header; }
        }
        /// <summary>
        /// 页脚
        /// </summary>
        public string Footer
        {
            set { _footer = value; }
            get { return _footer; }
        }
        /// <summary>
        /// 接收人
        /// </summary>
        public string Receiver
        {
            set { _receiver = value; }
            get { return _receiver; }
        }
        /// <summary>
        /// 接收人单位
        /// </summary>
        public string ReceiverCompany
        {
            set { _receivercompany = value; }
            get { return _receivercompany; }
        }
        /// <summary>
        /// 提醒手机号
        /// </summary>
        public string MobileList
        {
            set { _mobilelist = value; }
            get { return _mobilelist; }
        }
        /// <summary>
        /// Email列表
        /// </summary>
        public string EmailList
        {
            set { _emaillist = value; }
            get { return _emaillist; }
        }
        /// <summary>
        /// 重发重发间隔
        /// </summary>
        public int ResendDelay
        {
            set { _resenddelay = value; }
            get { return _resenddelay; }
        }
        /// <summary>
        /// 重发次数
        /// </summary>
        public int ResendTimes
        {
            set { _resendtimes = value; }
            get { return _resendtimes; }
        }
        /// <summary>
        /// 发送优先级
        /// </summary>
        public int Priority
        {
            set { _priority = value; }
            get { return _priority; }
        }
        /// <summary>
        /// 封页标志
        /// </summary>
        public int CoverPageFlag
        {
            set { _coverpageflag = value; }
            get { return _coverpageflag; }
        }
        /// <summary>
        /// 封页内容
        /// </summary>
        public string CoverPage
        {
            set { _coverpage = value; }
            get { return _coverpage; }
        }
        /// <summary>
        /// 提交时间
        /// </summary>
        public DateTime SubmitTime
        {
            set { _submittime = value; }
            get { return _submittime; }
        }
        /// <summary>
        /// 发送时间
        /// </summary>
        public DateTime SendTime
        {
            set { _sendtime = value; }
            get { return _sendtime; }
        }
        /// <summary>
        /// 数据同步时间
        /// </summary>
        public DateTime DataSyncTime
        {
            set { _datasynctime = value; }
            get { return _datasynctime; }
        }
        /// <summary>
        /// 发送结束时间
        /// </summary>
        public DateTime SendEndTime
        {
            set { _sendendtime = value; }
            get { return _sendendtime; }
        }
        /// <summary>
        /// 消费金额
        /// </summary>
        public int UsedValue
        {
            set { _usedvalue = value; }
            get { return _usedvalue; }
        }
        /// <summary>
        /// 发送秒数
        /// </summary>
        public int Seconds
        {
            set { _seconds = value; }
            get { return _seconds; }
        }
        /// <summary>
        /// 发送页数
        /// </summary>
        public int SendPages
        {
            set { _sendpages = value; }
            get { return _sendpages; }
        }
        /// <summary>
        /// 解冻标志
        /// </summary>
        public int UnFreezeFlag
        {
            set { _unfreezeflag = value; }
            get { return _unfreezeflag; }
        }
        /// <summary>
        /// 冻结标志
        /// </summary>
        public int FreezeFlag
        {
            set { _freezeflag = value; }
            get { return _freezeflag; }
        }
        /// <summary>
        /// 冻结金额
        /// </summary>
        public int Freeze
        {
            set { _freeze = value; }
            get { return _freeze; }
        }
        /// <summary>
        /// 解冻次数
        /// </summary>
        public int UnFreezeTimes
        {
            set { _unfreezetimes = value; }
            get { return _unfreezetimes; }
        }
        /// <summary>
        /// 发送服务器
        /// </summary>
        public string SendSereverName
        {
            set { _sendserevername = value; }
            get { return _sendserevername; }
        }
        /// <summary>
        /// 发送类型
        /// </summary>
        public int ClsID
        {
            set { _clsid = value; }
            get { return _clsid; }
        }
        /// <summary>
        /// 删除标志
        /// </summary>
        public int IsDelete
        {
            set { _isdelete = value; }
            get { return _isdelete; }
        }
        /// <summary>
        /// 操作标志
        /// </summary>
        public int DoFlag
        {
            set { _doflag = value; }
            get { return _doflag; }
        }
        /// <summary>
        /// 操作区别码
        /// </summary>
        public string DoKey
        {
            set { _dokey = value; }
            get { return _dokey; }
        }
        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime CrDate
        {
            set { _crdate = value; }
            get { return _crdate; }
        }
        /// <summary>
        ///传真状态 
        /// </summary>
        public int Sts
        {
            set { _sts = value; }
            get { return _sts; }
        }
        /// <summary>
        /// 失败原因
        /// </summary>
        public int FailedReason
        {
            set { _failedreason = value; }
            get { return _failedreason; }
        }
        /// <summary>
        /// 发送语音
        /// </summary>
        public string SendVoice
        {
            set { _sendVoice = value; }
            get { return _sendVoice; }
        }
        /// <summary>
        /// 是否页数限制
        /// </summary>
        public int AuditingFlag
        {
            set { _auditingFlag = value; }
            get { return _auditingFlag; }
        }
        #endregion Model
    }
}
