using System;
using System.Collections.Generic;
using System.Text;

namespace Fax.EmailDAL
{
    public class Mail_To_Fax_UserInfo
    {
        public Mail_To_Fax_UserInfo()
        { }

        private int _seqNo = 0;
        private string _sendVoice = string.Empty;
        private string _recvVoice = string.Empty;
        private string _sellUName = string.Empty;
        private int _isEmail = 0;
        private int _isSms = 0;
        private string _mobile = string.Empty;
        private string _email = string.Empty;
        private int _resendTimes = 0;
        private int _resendDelay = 0;
        private string _sender = string.Empty;
        private string _localCsid = string.Empty;
        private int _priority = 0;
        private string _senderCompany = string.Empty;
        private int _isProbational = 0;
        private int _userType = 0;
        private int _state = 0;
        private string _iAppCode = string.Empty;
        private string _msgValue = string.Empty;
        private string _emailValue = string.Empty;
        private int _repeat = 0;
        private int _compID = 0;
        private string _lineNum = string.Empty;
        private string _areaCode = string.Empty;

        /// <summary>
        /// 电子邮件
        /// </summary>
        public string EmailValue
        {
            set { _emailValue = value; }
            get { return _emailValue; }
        }
        /// <summary>
        /// 邮件是否重复 0 为不重复，1位重复
        /// </summary>
        public int Repeat
        {
            set { _repeat = value; }
            get { return _repeat; }
        }
        /// <summary>
        /// 用户ID
        /// </summary>
        public int SeqNo
        {
            set { _seqNo = value; }
            get { return _seqNo; }
        }
        /// <summary>
        /// 发送语音文件；用户发送传真时的个性语音文件
        /// </summary>
        public string SendVoice
        {
            set { _sendVoice = value; }
            get { return _sendVoice; }
        }
        /// <summary>
        /// 短信提醒值
        /// </summary>
        public string MsgValue
        {
            set { _msgValue = value; }
            get { return _msgValue; }
        }
        /// <summary>
        /// 接收语音文件；用户接收传真时的个性语音文件
        /// </summary>
        public string RecvVoice
        {
            set { _recvVoice = value; }
            get { return _recvVoice; }
        }
        /// <summary>
        /// 电话销售人员名称；
        /// </summary>
        public string SellUName
        {
            set { _sellUName = value; }
            get { return _sellUName; }
        }
        /// <summary>
        /// 是否需要Email提醒；1 为需要；0 为不需要
        /// </summary>
        public int IsEmail
        {
            set { _isEmail = value; }
            get { return _isEmail; }
        }
        /// <summary>
        /// 是否需要短信提醒；1 为需要；0 为不需要
        /// </summary>
        public int IsSms
        {
            set { _isSms = value; }
            get { return _isSms; }
        }
        /// <summary>
        /// 需要提醒的手机号
        /// </summary>
        public string Mobile
        {
            set { _mobile = value; }
            get { return _mobile; }
        }
        /// <summary>
        /// 需要提醒的电子邮件，如果多个则需要使用半角的分号隔开";"
        /// </summary>
        public string Email
        {
            set { _email = value; }
            get { return _email; }
        }
        /// <summary>
        /// 失败重发次数
        /// </summary>
        public int ResendTimes
        {
            set { _resendTimes = value; }
            get { return _resendTimes; }
        }
        /// <summary>
        /// 失败重发时间间隔
        /// </summary>
        public int ResendDelay
        {
            set { _resendDelay = value; }
            get { return _resendDelay; }
        }
        /// <summary>
        /// 发送人
        /// </summary>
        public string Sender
        {
            set { _sender = value; }
            get { return _sender; }
        }
        /// <summary>
        /// 传真机上显示名称
        /// </summary>
        public string LocalCSID
        {
            set { _localCsid = value; }
            get { return _localCsid; }
        }
        /// <summary>
        /// 优先级；数值越小优先级越高
        /// </summary>
        public int Priority
        {
            set { _priority = value; }
            get { return _priority; }
        }
        /// <summary>
        ///  发送公司名称
        /// </summary>
        public string SenderCompany
        {
            set { _senderCompany = value; }
            get { return _senderCompany; }
        }
        /// <summary>
        /// 0 表示正式
        /// </summary>
        public int IsProbational
        {
            set { _isProbational = value; }
            get { return _isProbational; }
        }
        /// <summary>
        /// 1	直拨用户　2	分机用户　3	企业用户　4	企业用户下分机用户　5	企业总机用户
        ///6	400     7	只发用户 8	运营商（暂时不用）9	原来的后付费 10	终身免费用户 11	800     12	分机管理员
        /// </summary>
        public int UserType
        {
            set { _userType = value; }
            get { return _userType; }
        }
        /// <summary>
        /// 0 暂停 1 正常 2 欠费 3 到期 4 注销 5 删除
        /// </summary>
        public int State
        {
            set { _state = value; }
            get { return _state; }
        }
        /// <summary>
        /// IAppCode 属于 传真用户信息表
        /// </summary>
        public string IAppCode
        {
            set { _iAppCode = value; }
            get { return _iAppCode; }
        }
        /// <summary>
        /// 企业编号
        /// </summary>
        public int CompID
        {
            get { return _compID; }
            set { _compID = value; }
        }
        /// <summary>
        /// 传真号码
        /// </summary>
        public string LineNum
        {
            get { return _lineNum; }
            set { _lineNum = value; }
        }

        public string AreaCode
        {
            get { return _areaCode; }
            set { _areaCode = value; }
        }
    }
}
