//********************************************************************************************************
//Copyright(C) 2008  远特技术部 
//文件名：Fax_Send_ReturnStatsLogInf.cs
//作  者：王勋
//日　期：2008/05/09
//描　述：[传真数据同步节点]的数据封装类
//版　本：2.00
//修改历史记录
//版　本　　　　　修改时间　　　　　　修改人　　　　　变更内容
//  2.00       2008/05/09              朱翔　　　　　　新建

//********************************************************************************************************

using System;
using System.Collections.Generic;
using System.Text;

namespace EmailDAL
{
    public class Fax_Send_ReturnStatsLogInf
    {
        public Fax_Send_ReturnStatsLogInf() { }
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
        /// 转换文件存放服务器
        /// </summary>
        private string _transervername = "";
        public string TranServerName
        {
            get { return this._transervername; }
            set { this._transervername = value; }
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
        /// 发送更新时间
        /// </summary>
        private string _sendendtime = "";
        public string SendEndTime
        {
            get { return this._sendendtime; }
            set { this._sendendtime = value; }
        }
        /// <summary>
        /// 日志序号
        /// </summary>
        private int _maxid = 0;
        public int MaxID
        {
            get { return this._maxid; }
            set { this._maxid = value; }
        }
        /// <summary>
        /// 发送状态
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
        /// 发送页面数
        /// </summary>
        private int _sentpages = 0;
        public int SentPages
        {
            get { return this._sentpages; }
            set { this._sentpages = value; }
        }
        /// <summary>
        /// 发送秒数
        /// </summary>
        private int _seconds = 0;
        public int Seconds
        {
            get { return this._seconds; }
            set { this._seconds = value; }
        }
        /// <summary>
        /// 发送原始金额
        /// </summary>
        private int _oriamount = 0;
        public int OriAmount
        {
            get { return this._oriamount; }
            set { this._oriamount = value; }
        }
        /// <summary>
        /// 发送折扣后金额
        /// </summary>
        private int _donatedamount = 0;
        public int DonatedAmount
        {
            get { return this._donatedamount; }
            set { this._donatedamount = value; }
        }
        /// <summary>
        /// 发送折扣
        /// </summary>
        private int _percents = 0;
        public int Percents
        {
            get { return this._percents; }
            set { this._percents = value; }
        }
    }
}
