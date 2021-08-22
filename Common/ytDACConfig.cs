using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace Fax.Common
{
    public class ytDACConfig
    {
        public ytDACConfig() { }

        /// <summary>
        /// ���App.Config�е�������Ϣ
        /// </summary>
        /// <param name="_key">������Ϣ��Keyֵ</param>
        /// <returns>������Ϣ����</returns>
        public static string GetItemByKey(string _key)
        {
            return ConfigurationManager.AppSettings[_key];
        }

        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ytMail"].ConnectionString;
        }

        public static string GetSystemName_V1()
        {
            string Result = "";
            Result = GetItemByKey("SysName");
            return Result;
        }

        public static string GetSystemName_V2()
        {
            string Result = "";
            Result = GetItemByKey("SysName") + " " + GetItemByKey("Version");
            return Result;
        }
    }
}
