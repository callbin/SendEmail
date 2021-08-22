//********************************************************************************************************
//Copyright(C) 2008  Զ�ؼ����� 
//�ļ�����Fax_UserInfoInf.cs
//��  �ߣ����Ĳ�
//�ա��ڣ�2008/04/10
//�衡������[�����û���Ϣ��<Fax_UserInfo>]�����ݷ�װ��
//�桡����2.00
//�޸���ʷ��¼
//�桡�������������޸�ʱ�䡡�����������޸��ˡ����������������
//  2.00                                  2008/04/10                               ���Ĳ��������������½�
//********************************************************************************************************

using System;
using System.Collections.Generic;
using System.Text;

namespace EmailDAL
{
    /// <summary>
    /// ʵ����Fax_UserInfoInf ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
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
        /// �����ʼ�
        /// </summary>
        public string EmailValue
        {
            set { _emailvalue = value; }
            get { return _emailvalue; }
        }
        /// <summary>
        /// �ʼ��Ƿ��ظ� 0 Ϊ���ظ���1λ�ظ�
        /// </summary>
        public int Repeat
        {
            set { _repeat = value; }
            get { return _repeat; }
        }
        /// <summary>
        /// �û�ID
        /// </summary>
        public int SeqNo
        {
            set { _seqno = value; }
            get { return _seqno; }
        }
        /// <summary>
        /// ���������ļ����û����ʹ���ʱ�ĸ��������ļ�
        /// </summary>
        public string SendVoice
        {
            set { _sendvoice = value; }
            get { return _sendvoice; }
        }
        /// <summary>
        /// ��������ֵ
        /// </summary>
        public string MsgValue
        {
            set { _msgvalue = value; }
            get { return _msgvalue; }
        }
        /// <summary>
        /// ���������ļ����û����մ���ʱ�ĸ��������ļ�
        /// </summary>
        public string RecvVoice
        {
            set { _recvvoice = value; }
            get { return _recvvoice; }
        }
        /// <summary>
        /// �绰������Ա���ƣ�
        /// </summary>
        public string SellUName
        {
            set { _selluname = value; }
            get { return _selluname; }
        }
        /// <summary>
        /// �Ƿ���ҪEmail���ѣ�1 Ϊ��Ҫ��0 Ϊ����Ҫ
        /// </summary>
        public int? IsEmail
        {
            set { _isemail = value; }
            get { return _isemail; }
        }
        /// <summary>
        /// �Ƿ���Ҫ�������ѣ�1 Ϊ��Ҫ��0 Ϊ����Ҫ
        /// </summary>
        public int? IsSms
        {
            set { _issms = value; }
            get { return _issms; }
        }
        /// <summary>
        /// ��Ҫ���ѵ��ֻ���
        /// </summary>
        public string Mobile
        {
            set { _mobile = value; }
            get { return _mobile; }
        }
        /// <summary>
        /// ��Ҫ���ѵĵ����ʼ�������������Ҫʹ�ð�ǵķֺŸ���";"
        /// </summary>
        public string Email
        {
            set { _email = value; }
            get { return _email; }
        }
        /// <summary>
        /// ʧ���ط�����
        /// </summary>
        public int? ResendTimes
        {
            set { _resendtimes = value; }
            get { return _resendtimes; }
        }
        /// <summary>
        /// ʧ���ط�ʱ����
        /// </summary>
        public int? ResendDelay
        {
            set { _resenddelay = value; }
            get { return _resenddelay; }
        }
        /// <summary>
        /// ������
        /// </summary>
        public string Sender
        {
            set { _sender = value; }
            get { return _sender; }
        }
        /// <summary>
        /// ���������ʾ����
        /// </summary>
        public string LocalCSID
        {
            set { _localcsid = value; }
            get { return _localcsid; }
        }
        /// <summary>
        /// ���ȼ�����ֵԽС���ȼ�Խ��
        /// </summary>
        public int? Priority
        {
            set { _priority = value; }
            get { return _priority; }
        }
        /// <summary>
        ///  ���͹�˾����
        /// </summary>
        public string SenderCompany
        {
            set { _sendercompany = value; }
            get { return _sendercompany; }
        }
        /// <summary>
        /// 0 ��ʾ��ʽ
        /// </summary>
        public int? IsProbational
        {
            set { _isprobational = value; }
            get { return _isprobational; }
        }
        /// <summary>
        /// 1	ֱ���û���2	�ֻ��û���3	��ҵ�û���4	��ҵ�û��·ֻ��û���5	��ҵ�ܻ��û�
        ///6	400     7	ֻ���û� 8	��Ӫ�̣���ʱ���ã�9	ԭ���ĺ󸶷� 10	��������û� 11	800     12	�ֻ�����Ա
        /// </summary>
        public int? UserType
        {
            set { _usertype = value; }
            get { return _usertype; }
        }
        /// <summary>
        /// 0 ��ͣ 1 ���� 2 Ƿ�� 3 ���� 4 ע�� 5 ɾ��
        /// </summary>
        public int? State
        {
            set { _state = value; }
            get { return _state; }
        }
        /// <summary>
        /// IAppCode ���� �����û���Ϣ��
        /// </summary>
        public string IAppCode
        {
            set { _iappcode = value; }
            get { return _iappcode; }
        }
        /// <summary>
        /// ��ҵ���
        /// </summary>
        public int? CompID
        {
            get { return _compid; }
            set { _compid = value; }
        }
        /// <summary>
        /// �������
        /// </summary>
        public string LineNum
        {
            get { return _linenum; }
            set { _linenum = value; }
        }
        #endregion Model

    }
}

