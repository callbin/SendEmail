//********************************************************************************************************
//Copyright(C) 2008  Զ�ؼ����� 
//�ļ�����Fax_Send_TranFile_NodeInf.cs
//��  �ߣ���ѫ
//�ա��ڣ�2008/04/22
//�衡����[����ת���ļ��ڵ�]�����ݷ�װ��
//�桡����2.00
//�޸���ʷ��¼
//�桡�������������޸�ʱ�䡡�����������޸��ˡ����������������
//  2.00                                  2008/04/22                               ��ѫ�������������½�
//********************************************************************************************************

using System;
using System.Collections.Generic;
using System.Text;

namespace EmailDAL
{
	/// <summary>
	/// ʵ����Fax_UserInfoInf ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class Fax_Send_TranFile_NodeInf
	{
		public Fax_Send_TranFile_NodeInf()
		{}
		#region Model
        private string _iappcode = "";
		private int _seqno = 0;
		private string _flowcode = "";
		private string _batchno = "";
		private string _faxfilepath = "";
		private string _faxfile = "";
		private string _remotefilepath = "";
        private string _remotefile = "";
		private string _footer="";
		private string _header = "";
        private string _coverpage = "";
        private string _subject = "";
		private int _clsid = 0;
		private int _coverpageflag = 0;
        private int _pages = 0;
		private int _sts = -1;
        private int _currentflow = 0;
        private int _failedindex = 0;
        private int _addid = 0;
        /// <summary>
        /// IAppCode ���� �����û���Ϣ��
        /// </summary>
        public string IAppCode
        {
            set { _iappcode = value; }
            get { return _iappcode; }
        }
		/// <summary>
        /// �û�ID
		/// </summary>
		public int SeqNo
		{
			set{ _seqno=value;}
			get{return _seqno;}
		}
		/// <summary>
        /// ���̺�
		/// </summary>
        public string FlowCode
		{
			set{ _flowcode=value;}
			get{return _flowcode;}
		}
		/// <summary>
        /// ���κ�
		/// </summary>
		public string BatchNo
		{
			set{ _batchno=value;}
			get{return _batchno;}
		}
		/// <summary>
        /// ת��ǰ�ļ�·��
		/// </summary>
        public string FaxFilePath
		{
			set{ _faxfilepath=value;}
			get{return _faxfilepath;}
		}
		/// <summary>
        /// ��Ҫת�����ļ���������ļ���֮�䡰,���ָ���
		/// </summary>
        public string FaxFile
		{
			set{ _faxfile=value;}
			get{return _faxfile;}
		}
		/// <summary>
        /// ת�����ļ�·��
		/// </summary>
        public string RemoteFilePath
		{
			set{ _remotefilepath=value;}
			get{return _remotefilepath;}
		}
        public string RemoteFile
        {
            set { _remotefile = value; }
            get { return _remotefile; }
        }
		/// <summary>
        /// ҳ��
		/// </summary>
		public string Footer
		{
			set{ _footer=value;}
			get{return _footer;}
		}
		/// <summary>
        ///  ҳü
		/// </summary>
		public string Header
		{
			set{ _header=value;}
			get{return _header;}
		}
        /// <summary>
        ///  ��ҳ���ݣ���ʽ��������,�����,�����˵�λ,������,�����˵�λ��
        /// </summary>
        public string CoverPage
        {
            set { _coverpage = value; }
            get { return _coverpage; }
        }
        /// <summary>
        ///  ��������
        /// </summary>
        public string Subject
        {
            set { _subject = value; }
            get { return _subject; }
        }
		/// <summary>
        /// �������� 0 �ڲ��� 1 ���ʣ�2 ��;��3 �л�
		/// </summary>
        public int ClsID
		{
            set { _clsid = value; }
            get { return _clsid; }
		}
		/// <summary>
		/// ��ҳ��ʾ 1 ��ӡ��ҳ��0 ����ӡ��ҳ
		/// </summary>
        public int CoverPageFlag
		{
            set { _coverpageflag = value; }
            get { return _coverpageflag; }
		}
        /// <summary>
        /// �ļ�ҳ��
        /// </summary>
        public int Pages
        {
            set { _pages = value; }
            get { return _pages; }
        }
		/// <summary>
        /// ����״̬ -1 ��Ҫװ�����ݣ�0 ����ת����1 ����ת����2 ���Ա������ݣ�
		/// </summary>
		public int Sts
		{
			set{ _sts=value;}
			get{return _sts;}
		}
        /// <summary>
        /// ��ǰ״̬
        /// </summary>
        public int CurrentFlow
        {
            set { _currentflow = value; }
            get { return _currentflow; }
        }
        /// <summary>
        /// ʧ��������
        /// </summary>
        public int FailedIndex
        {
            set { _failedindex = value; }
            get { return _failedindex; }
        }
        /// <summary>
        /// ͨѶ¼����ID
        /// </summary>
        public int AddID
        {
            set { _addid = value; }
            get { return _addid; }
        }
		#endregion Model
	}
}

