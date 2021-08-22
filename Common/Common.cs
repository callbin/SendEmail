using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Text.RegularExpressions;

namespace Fax.Common
{
    public class Common
    {
        /// <summary>
        /// 是否为数字
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsNumber(string str)
        {
            if (str.Length > 0)
            {
                foreach (char ch in str.ToCharArray())
                {
                    if (!Char.IsNumber(ch))
                        return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 是否为IP地址
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        public static bool IsIPAddress(string ip)
        {
            if (ip.Length > 0)
            {
                try
                {
                    IPAddress.Parse(ip);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 是否为邮箱地址
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool IsEmail(string email)
        {
            if (email.Length > 0)
            {
                try
                {
                    Regex emailExp = new Regex(@"^(\w)+((\w)|(-)|(.))+@+((\w)|(-))+(.)+[a-zA-Z]");//"^\w+@\w+(\.\w+)+(\,\w+@\w+(\.\w+)+)*$");
                    if (emailExp.Match(email).Success)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 本机IP地址
        /// </summary>
        /// <returns></returns>
        public static string GetHostIP()
        {
            IPHostEntry ipEntry = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress[] addr = ipEntry.AddressList;
            return addr[0].ToString();
        }

        /// <summary>
        /// 是否为传真号
        /// </summary>
        /// <param name="faxnum"></param>
        /// <returns></returns>
        public static bool IsFaxNum(string faxnum)
        {
            if (faxnum.Length > 0)
            {
                try
                {
                    Regex faxExp = new Regex(@"^(\d{6,20})(($)|(,\d{1,8}$))$");//^(([0\+]\d{2,3})?(0\d{2,3}))?(\d{7,8})(,(\d{3,}))?$
                    return faxExp.Match(faxnum).Success ? true : false;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool IsUrl(string fileName)
        {
            if (fileName.StartsWith("http://"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
