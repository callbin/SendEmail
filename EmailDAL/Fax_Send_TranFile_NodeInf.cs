//********************************************************************************************************
//Copyright(C) 2008  远特技术部 
//文件名：Fax_Send_TranFile_NodeInf.cs
//作  者：王勋
//日　期：2008/04/22
//描　述：[传真转换文件节点]的数据封装类
//版　本：2.00
//修改历史记录
//版　本　　　　　修改时间　　　　　　修改人　　　　　变更内容
//  2.00                                  2008/04/22                               王勋　　　　　　新建
//********************************************************************************************************

using System;
using System.Collections.Generic;
using System.Text;

namespace EmailDAL
{
	/// <summary>
	/// 实体类Fax_UserInfoInf 。(属性说明自动提取数据库字段的描述信息)
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
        /// IAppCode 属于 传真用户信息表
        /// </summary>
        public string IAppCode
        {
            set { _iappcode = value; }
            get { return _iappcode; }
        }
		/// <summary>
        /// 用户ID
		/// </summary>
		public int SeqNo
		{
			set{ _seqno=value;}
			get{return _seqno;}
		}
		/// <summary>
        /// 流程号
		/// </summary>
        public string FlowCode
		{
			set{ _flowcode=value;}
			get{return _flowcode;}
		}
		/// <summary>
        /// 批次号
		/// </summary>
		public string BatchNo
		{
			set{ _batchno=value;}
			get{return _batchno;}
		}
		/// <summary>
        /// 转换前文件路径
		/// </summary>
        public string FaxFilePath
		{
			set{ _faxfilepath=value;}
			get{return _faxfilepath;}
		}
		/// <summary>
        /// 需要转换的文件名（多个文件名之间“,”分隔）
		/// </summary>
        public string FaxFile
		{
			set{ _faxfile=value;}
			get{return _faxfile;}
		}
		/// <summary>
        /// 转换后文件路径
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
        /// 页脚
		/// </summary>
		public string Footer
		{
			set{ _footer=value;}
			get{return _footer;}
		}
		/// <summary>
        ///  页眉
		/// </summary>
		public string Header
		{
			set{ _header=value;}
			get{return _header;}
		}
        /// <summary>
        ///  封页内容（格式：接收人,传真号,接收人单位,发件人,发件人单位）
        /// </summary>
        public string CoverPage
        {
            set { _coverpage = value; }
            get { return _coverpage; }
        }
        /// <summary>
        ///  传真主题
        /// </summary>
        public string Subject
        {
            set { _subject = value; }
            get { return _subject; }
        }
		/// <summary>
        /// 发送类型 0 内部； 1 国际；2 长途；3 市话
		/// </summary>
        public int ClsID
		{
            set { _clsid = value; }
            get { return _clsid; }
		}
		/// <summary>
		/// 封页标示 1 打印分页；0 不打印封页
		/// </summary>
        public int CoverPageFlag
		{
            set { _coverpageflag = value; }
            get { return _coverpageflag; }
		}
        /// <summary>
        /// 文件页数
        /// </summary>
        public int Pages
        {
            set { _pages = value; }
            get { return _pages; }
        }
		/// <summary>
        /// 发送状态 -1 需要装载数据；0 可以转换；1 正在转换；2 可以保存数据；
		/// </summary>
		public int Sts
		{
			set{ _sts=value;}
			get{return _sts;}
		}
        /// <summary>
        /// 当前状态
        /// </summary>
        public int CurrentFlow
        {
            set { _currentflow = value; }
            get { return _currentflow; }
        }
        /// <summary>
        /// 失败索引号
        /// </summary>
        public int FailedIndex
        {
            set { _failedindex = value; }
            get { return _failedindex; }
        }
        /// <summary>
        /// 通讯录分组ID
        /// </summary>
        public int AddID
        {
            set { _addid = value; }
            get { return _addid; }
        }
		#endregion Model
	}
}

