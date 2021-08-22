//********************************************************************************************************
//Copyright(C) 2008  远特技术部 
//文件名：Fax_UserInfoInf.cs
//作  者：徐文波
//日　期：2008/04/10
//描　述：表[传真用户信息表<Fax_UserInfo>]的数据封装类
//版　本：2.00
//修改历史记录
//版　本　　　　　修改时间　　　　　　修改人　　　　　变更内容
//  2.00                                  2008/04/10                               徐文波　　　　　　新建
//********************************************************************************************************

using System;
using System.Collections.Generic;
using System.Text;

namespace EmailDAL
{
    /// <summary>
    /// 实体类Fax_UserInfoInf 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public class Fax_UserInfoInf
    {
        public Fax_UserInfoInf()
        { }
        #region Model
        private int _seqno;
        private string _sendvoice;
        private string _recvvoice;
        private string _selluname;
        private int? _isemail;
        private int? _issms;
        private string _mobile;
        private string _email;
        private int? _resendtimes;
        private int? _resenddelay;
        private string _sender;
        private string _localcsid;
        private int? _priority;
        private string _sendercompany;
        private int? _isprobational;
        private int? _usertype;
        private int? _state;
        private string _iappcode;
        private string _msgvalue;
        private string _emailvalue;
        private int _repeat;

        private int? _compid;
        private string _linenum;

        /// <summary>
        /// 电子邮件
        /// </summary>
        public string EmailValue
        {
            set { _emailvalue = value; }
            get { return _emailvalue; }
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
            set { _seqno = value; }
            get { return _seqno; }
        }
        /// <summary>
        /// 发送语音文件；用户发送传真时的个性语音文件
        /// </summary>
        public string SendVoice
        {
            set { _sendvoice = value; }
            get { return _sendvoice; }
        }
        /// <summary>
        /// 短信提醒值
        /// </summary>
        public string MsgValue
        {
            set { _msgvalue = value; }
            get { return _msgvalue; }
        }
        /// <summary>
        /// 接收语音文件；用户接收传真时的个性语音文件
        /// </summary>
        public string RecvVoice
        {
            set { _recvvoice = value; }
            get { return _recvvoice; }
        }
        /// <summary>
        /// 电话销售人员名称；
        /// </summary>
        public string SellUName
        {
            set { _selluname = value; }
            get { return _selluname; }
        }
        /// <summary>
        /// 是否需要Email提醒；1 为需要；0 为不需要
        /// </summary>
        public int? IsEmail
        {
            set { _isemail = value; }
            get { return _isemail; }
        }
        /// <summary>
        /// 是否需要短信提醒；1 为需要；0 为不需要
        /// </summary>
        public int? IsSms
        {
            set { _issms = value; }
            get { return _issms; }
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
        public int? ResendTimes
        {
            set { _resendtimes = value; }
            get { return _resendtimes; }
        }
        /// <summary>
        /// 失败重发时间间隔
        /// </summary>
        public int? ResendDelay
        {
            set { _resenddelay = value; }
            get { return _resenddelay; }
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
            set { _localcsid = value; }
            get { return _localcsid; }
        }
        /// <summary>
        /// 优先级；数值越小优先级越高
        /// </summary>
        public int? Priority
        {
            set { _priority = value; }
            get { return _priority; }
        }
        /// <summary>
        ///  发送公司名称
        /// </summary>
        public string SenderCompany
        {
            set { _sendercompany = value; }
            get { return _sendercompany; }
        }
        /// <summary>
        /// 0 表示正式
        /// </summary>
        public int? IsProbational
        {
            set { _isprobational = value; }
            get { return _isprobational; }
        }
        /// <summary>
        /// 1	直拨用户　2	分机用户　3	企业用户　4	企业用户下分机用户　5	企业总机用户
        ///6	400     7	只发用户 8	运营商（暂时不用）9	原来的后付费 10	终身免费用户 11	800     12	分机管理员
        /// </summary>
        public int? UserType
        {
            set { _usertype = value; }
            get { return _usertype; }
        }
        /// <summary>
        /// 0 暂停 1 正常 2 欠费 3 到期 4 注销 5 删除
        /// </summary>
        public int? State
        {
            set { _state = value; }
            get { return _state; }
        }
        /// <summary>
        /// IAppCode 属于 传真用户信息表
        /// </summary>
        public string IAppCode
        {
            set { _iappcode = value; }
            get { return _iappcode; }
        }
        /// <summary>
        /// 企业编号
        /// </summary>
        public int? CompID
        {
            get { return _compid; }
            set { _compid = value; }
        }
        /// <summary>
        /// 传真号码
        /// </summary>
        public string LineNum
        {
            get { return _linenum; }
            set { _linenum = value; }
        }
        #endregion Model

    }
}

