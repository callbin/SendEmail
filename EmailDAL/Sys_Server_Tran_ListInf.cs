using System;
using System.Collections.Generic;
using System.Text;

namespace EmailDAL
{
    /// <summary>
    /// 实体类Sys_Server_Tran_ListInf
    /// </summary>
    public class Sys_Server_Tran_ListInf
    {
        public Sys_Server_Tran_ListInf()
        { }
        #region Model
        private int _serverid = 0;
        private int _clsid = 0;
        private string _servername = "";
        private string _serverip = "";
        private string _servercode = "";
        private string _appurl = "";
        private int _files = 0;
        private int _lines = 0;
        private int _tranfiles = 0;
        private string _exfield1 = "";
        private string _exfield2 = "";
        private string _exfield4 = "";
        private int _specialflag = 0;
        private DateTime _crdate = DateTime.Now;
        private int _sts = 0;
        /// <summary>
        /// 转换服务器标示
        /// </summary>
        public int ServerID
        {
            set { _serverid = value; }
            get { return _serverid; }
        }
        /// <summary>
        /// 服务器类型
        /// </summary>
        public int ClsID
        {
            set { _clsid = value; }
            get { return _clsid; }
        }
        /// <summary>
        /// 服务器名称
        /// </summary>
        public string ServerName
        {
            set { _servername = value; }
            get { return _servername; }
        }
        /// <summary>
        /// 服务器IP
        /// </summary>
        public string ServerIP
        {
            set { _serverip = value; }
            get { return _serverip; }
        }
        /// <summary>
        /// 服务器代码
        /// </summary>
        public string ServerCode
        {
            set { _servercode = value; }
            get { return _servercode; }
        }
        /// <summary>
        /// 服务器URL
        /// </summary>
        public string AppUrl
        {
            set { _appurl = value; }
            get { return _appurl; }
        }
        /// <summary>
        /// 需要转换的文件数
        /// </summary>
        public int Files
        {
            set { _files = value; }
            get { return _files; }
        }
        /// <summary>
        /// 发送服务器线路数
        /// </summary>
        public int Lines
        {
            set { _lines = value; }
            get { return _lines; }
        }
        /// <summary>
        /// 已经转换的文件数
        /// </summary>
        public int TranFiles
        {
            set { _tranfiles = value; }
            get { return _tranfiles; }
        }
        /// <summary>
        /// 扩展一
        /// </summary>
        public string ExField1
        {
            set { _exfield1 = value; }
            get { return _exfield1; }
        }
        /// <summary>
        /// 扩展一
        /// </summary>
        public string ExField2
        {
            set { _exfield2 = value; }
            get { return _exfield2; }
        }
        /// <summary>
        /// 扩展一
        /// </summary>
        public string ExField4
        {
            set { _exfield4 = value; }
            get { return _exfield4; }
        }
        /// <summary>
        /// 特殊应用标志
        /// </summary>
        public int SpecialFlag
        {
            set { _specialflag = value; }
            get { return _specialflag; }
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
        /// 状态 0停用,1启用
        /// </summary>
        public int Sts
        {
            set { _sts = value; }
            get { return _sts; }
        }
        #endregion Model

    }
}
