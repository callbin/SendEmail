using System;
using System.Security.Cryptography;
using System.IO;
using System.Data;
using System.Web;
using System.Text;
using System.Security;

namespace Fax.Common
{
    /// <summary>
    /// Encrypt 的摘要说明。
    /// </summary>
    public class Encrypt
    {
        #region 一个简单的加密解密方法,只支持英文
        public static string EnCryptEnStr(string str) //倒序加1加密
        {
            byte[] by = new byte[str.Length];
            for (int i = 0;i <= str.Length - 1;i++)
            {
                by[i] = (byte)((byte)str[i] + 1);
            }
            str = "";
            for (int i = by.Length - 1;
             i >= 0;
             i--)
            {
                str += ((char)by[i]).ToString();
            }
            return str;
        }
        public static string DeCryptEnStr(string str) //顺序减1解码
        {
            byte[] by = new byte[str.Length];
            for (int i = 0;i <= str.Length - 1;i++)
            {
                by[i] = (byte)((byte)str[i] - 1);
            }
            str = "";
            for (int i = by.Length - 1;i >= 0;i--)
            {
                str += ((char)by[i]).ToString();
            }
            return str;
        }
        #endregion

        //默认密钥向量
        private static byte[] Keys = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
        private static string KEY_64 = "YUAN-TEL";

        /// <summary>
        /// DES加密字符串
        /// </summary>
        /// <param name="encryptString">待加密的字符串</param>
        /// <param name="encryptKey">加密密钥,要求为8位</param>
        /// <returns>加密成功返回加密后的字符串，失败返回源串</returns>
        public static string EncryptDES(string encryptString)
        {
            try
            {
                byte[] rgbKey = Encoding.UTF8.GetBytes(KEY_64.Substring(0, 8));
                byte[] rgbIV = Keys;
                byte[] inputByteArray = Encoding.UTF8.GetBytes(encryptString);
                DESCryptoServiceProvider dCSP = new DESCryptoServiceProvider();
                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, dCSP.CreateEncryptor(rgbKey,

rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Convert.ToBase64String(mStream.ToArray());
            }
            catch
            {
                return encryptString;
            }
        }
        
        /// <summary>
        /// DES解密字符串
        /// </summary>
        /// <param name="decryptString">待解密的字符串</param>
        /// <param name="decryptKey">解密密钥,要求为8位,和加密密钥相同</param>
        /// <returns>解密成功返回解密后的字符串，失败返源串</returns>
        public static string DecryptDES(string decryptString)
        {
            try
            {
                byte[] rgbKey = Encoding.UTF8.GetBytes(KEY_64);
                byte[] rgbIV = Keys;
                byte[] inputByteArray = Convert.FromBase64String(decryptString);
                DESCryptoServiceProvider DCSP = new DESCryptoServiceProvider();
                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, DCSP.CreateDecryptor(rgbKey,

rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Encoding.UTF8.GetString(mStream.ToArray());
            }
            catch
            {
                return decryptString;
            }
        } 

    }
}
