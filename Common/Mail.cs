using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.IO;
using jmail;
using System.Configuration;

namespace Fax.Common
{
    public class Mail
    {
        /// <summary>
        ///  发送邮件
        /// </summary>
        /// <param name="strSmtpServer">发送邮件服务器</param>
        /// <param name="strFrom">发信人Email</param>
        /// <param name="strFromPass">发信人Email密码</param>
        /// <param name="strTo">收信人Email</param>
        /// <param name="strSubject">邮件主题</param>
        /// <param name="strBody">邮件内容</param>
        public static int Send(string strSmtpServer, string strFrom, string strFromPass, string strTo, string strSubject, string strBody)
        {
            try
            {
                SmtpClient client = new SmtpClient(strSmtpServer);

                client.UseDefaultCredentials = false;
                strFromPass = Encrypt.DeCryptEnStr(strFromPass);
                client.Credentials = new System.Net.NetworkCredential(strFrom, strFromPass);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;

                Byte[] b = Encoding.Default.GetBytes(strBody);
                strBody = Encoding.GetEncoding("gb2312").GetString(b).ToString();

                MailMessage message = new MailMessage(strFrom, strTo, strSubject, strBody);

                message.BodyEncoding = Encoding.UTF8;
                //message.IsBodyHtml = true;

                client.Send(message);

                return 1;
            }
            catch (System.Net.WebException)
            {
                return -1;
            }
            catch (SmtpFailedRecipientException)
            {
                return -2;
            }
        }

        /// <summary>
        ///  发送邮件(带附件)
        /// </summary>
        /// <param name="strSmtpServer">发送邮件服务器</param>
        /// <param name="strFrom">发信人Email</param>
        /// <param name="strFromPass">发信人Email密码</param>
        /// <param name="strTo">收信人Email</param>
        /// <param name="strSubject">邮件主题</param>
        /// <param name="strBody">邮件内容</param>
        /// <param name="strAttach">邮件附件</param>
        public static int Send(string strSmtpServer, string strFrom, string strFromPass, string strTo, string strSubject, string strBody, string strAttach)
        {
            try
            {
                SmtpClient client = new SmtpClient(strSmtpServer);

                client.UseDefaultCredentials = false;
                strFromPass = Encrypt.DeCryptEnStr(strFromPass);
                client.Credentials = new System.Net.NetworkCredential(strFrom, strFromPass);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;

                Byte[] b = Encoding.Default.GetBytes(strBody);
                strBody = Encoding.GetEncoding("gb2312").GetString(b).ToString();

                MailMessage message = new MailMessage(strFrom, strTo, strSubject, strBody);

                message.BodyEncoding = Encoding.UTF8;
                //message.IsBodyHtml = true;

                System.Net.Mail.Attachment data = new System.Net.Mail.Attachment(strAttach, System.Net.Mime.MediaTypeNames.Application.Octet);
                message.Attachments.Add(data);

                client.Send(message);

                return 1;
            }
            catch (System.Net.WebException)
            {
                return -1;
            }
            catch (SmtpFailedRecipientException)
            {
                return -2;
            }
        }//&quot;765432pbijo

        public static void SendJmail(string strSmtpServer, string strFrom, string strFromPass, string strTo, string strSubject, string strBody, string strAttach,string FromName,string EmailType="")
        {
            try
            {
                jmail.Message jmessage = new jmail.MessageClass();
                jmessage.Charset = "GB2312";
                jmessage.From = strFrom;
                jmessage.FromName = FromName;
                jmessage.Subject = strSubject;
                string[] receivers = strTo.Split(';');
                for (int i = 0; i < receivers.Length; i++)
                {
                    jmessage.AddRecipient(receivers[i], "", "");
                }
               
                if (CheckEmailType(EmailType))
                {
                    jmessage.HTMLBody = strBody;
                }
                else
                {
                    jmessage.Body = strBody;
                }
                //jmessage.Body = strBody;
                if (strAttach.Length > 0)
                {
                    if (!Common.IsUrl(strAttach))
                    {
                        jmessage.AddAttachment(strAttach, false, null);
                    }
                    else
                    {
                        jmessage.AddURLAttachment(strAttach, strAttach.Substring(strAttach.LastIndexOf("/") + 1), false, null);
                    }
                }
                //jmessage.MailServerUserName = strFrom.Split('@')[0];
                jmessage.MailServerUserName = strFrom;
                jmessage.MailServerPassWord = Encrypt.DecryptDES(strFromPass);
                jmessage.Send(strSmtpServer, false);
                jmessage.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private static bool CheckEmailType(string EmailType)
        {
            if (EmailType != "")
            {
                string[] EmailTypeList;
                string strEmailType = ConfigurationManager.AppSettings["EmialType"];
                if (!string.IsNullOrEmpty(strEmailType))
                {
                    EmailTypeList = strEmailType.Split(',');

                    foreach (string e in EmailTypeList)
                    {
                        if (e == EmailType)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
