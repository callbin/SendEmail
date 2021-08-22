//********************************************************************************************************
//Copyright(C) 2008  Զ�ؼ����� 
//�ļ�����Fax_Send_ReturnStatsLogInf.cs
//��  �ߣ���ѫ
//�ա��ڣ�2008/05/09
//�衡����[��������ͬ���ڵ�]�����ݷ�װ��
//�桡����2.00
//�޸���ʷ��¼
//�桡�������������޸�ʱ�䡡�����������޸��ˡ����������������
//  2.00       2008/05/09              ���衡�����������½�

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
        /// Ӧ�ñ��
        /// </summary>
        private string _iappcode = "";
        public string IAppCode
        {
            get { return this._iappcode; }
            set { this._iappcode = value; }
        }
        /// <summary>
        /// ���̺�
        /// </summary>
        private string _flowcode = "";
        public string FlowCode
        {
            get { return this._flowcode; }
            set { this._flowcode = value; }
        }
        /// <summary>
        /// ��������
        /// </summary>
        private int _sendtype = 1;
        public int SendType
        {
            get { return this._sendtype; }
            set { this._sendtype = value; }
        }
        /// <summary>
        /// ���մ����ʾ
        /// </summary>
        private int _sysid = 0;
        public int SysID
        {
            get { return this._sysid; }
            set { this._sysid = value; }
        }

        /// <summary>
        /// ���κ�
        /// </summary>
        private string _batchno = "";
        public string BatchNo
        {
            get { return this._batchno; }
            set { this._batchno = value; }
        }

        /// <summary>
        /// �û�ϵͳ���
        /// </summary>
        private int _seqno = 0;
        public int SeqNo
        {
            get { return this._seqno; }
            set { this._seqno = value; }
        }
        /// <summary>
        /// ת���ļ���ŷ�����
        /// </summary>
        private string _transervername = "";
        public string TranServerName
        {
            get { return this._transervername; }
            set { this._transervername = value; }
        }
        /// <summary>
        /// ���ͷ�����
        /// </summary>
        private string _sendservername = "";
        public string SendServerName
        {
            get { return this._sendservername; }
            set { this._sendservername = value; }
        }
        /// <summary>
        /// ���͸���ʱ��
        /// </summary>
        private string _sendendtime = "";
        public string SendEndTime
        {
            get { return this._sendendtime; }
            set { this._sendendtime = value; }
        }
        /// <summary>
        /// ��־���
        /// </summary>
        private int _maxid = 0;
        public int MaxID
        {
            get { return this._maxid; }
            set { this._maxid = value; }
        }
        /// <summary>
        /// ����״̬
        /// </summary>
        private int _sts = 0;
        public int Sts
        {
            get { return this._sts; }
            set { this._sts = value; }
        }
        /// <summary>
        /// ʧ��ԭ��
        /// </summary>
        private int _failedreason = 0;
        public int FailedReason
        {
            get { return this._failedreason; }
            set { this._failedreason = value; }
        }
        /// <summary>
        /// ����ҳ����
        /// </summary>
        private int _sentpages = 0;
        public int SentPages
        {
            get { return this._sentpages; }
            set { this._sentpages = value; }
        }
        /// <summary>
        /// ��������
        /// </summary>
        private int _seconds = 0;
        public int Seconds
        {
            get { return this._seconds; }
            set { this._seconds = value; }
        }
        /// <summary>
        /// ����ԭʼ���
        /// </summary>
        private int _oriamount = 0;
        public int OriAmount
        {
            get { return this._oriamount; }
            set { this._oriamount = value; }
        }
        /// <summary>
        /// �����ۿۺ���
        /// </summary>
        private int _donatedamount = 0;
        public int DonatedAmount
        {
            get { return this._donatedamount; }
            set { this._donatedamount = value; }
        }
        /// <summary>
        /// �����ۿ�
        /// </summary>
        private int _percents = 0;
        public int Percents
        {
            get { return this._percents; }
            set { this._percents = value; }
        }
    }
}
