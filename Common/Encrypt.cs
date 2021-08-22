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
    /// Encrypt ��ժҪ˵����
    /// </summary>
    public class Encrypt
    {
        #region һ���򵥵ļ��ܽ��ܷ���,ֻ֧��Ӣ��
        public static string EnCryptEnStr(string str) //�����1����
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
        public static string DeCryptEnStr(string str) //˳���1����
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

        //Ĭ����Կ����
        private static byte[] Keys = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
        private static string KEY_64 = "YUAN-TEL";

        /// <summary>
        /// DES�����ַ���
        /// </summary>
        /// <param name="encryptString">�����ܵ��ַ���</param>
        /// <param name="encryptKey">������Կ,Ҫ��Ϊ8λ</param>
        /// <returns>���ܳɹ����ؼ��ܺ���ַ�����ʧ�ܷ���Դ��</returns>
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
        /// DES�����ַ���
        /// </summary>
        /// <param name="decryptString">�����ܵ��ַ���</param>
        /// <param name="decryptKey">������Կ,Ҫ��Ϊ8λ,�ͼ�����Կ��ͬ</param>
        /// <returns>���ܳɹ����ؽ��ܺ���ַ�����ʧ�ܷ�Դ��</returns>
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
