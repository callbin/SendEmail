//********************************************************************************************************
//Copyright(C) 2008  远特技术部 
//文件名：Fax_To_Mail_NodeDb.cs
//作  者：zhuxiang
//日　期：2008/05/30
//描　述：传真转邮件数据操作类
//版　本：2.00
//********************************************************************************************************

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Fax.DBUtility;

namespace Fax.EmailDAL
{
    public class Fax_To_Mail_NodeDb
    {
        private const string Mail_SERVER = "ytMail";
        public Fax_To_Mail_NodeDb()
        { }
        public int Mail_Send_Insert(Fax_To_Mail_NodeInf node)
        {
            SqlParameter[] param = 
            { 
                new SqlParameter("@SeqNo",SqlDbType.Int),
                new SqlParameter("@EmailType",SqlDbType.Int),
                new SqlParameter("@EmailList",SqlDbType.VarChar,300),
                new SqlParameter("@FileName",SqlDbType.VarChar,200),
                new SqlParameter("@FilePath",SqlDbType.VarChar,100),
                new SqlParameter("@BatchNo",SqlDbType.VarChar,20),
                new SqlParameter("@SendTime",SqlDbType.DateTime),
                new SqlParameter("@RecTime",SqlDbType.DateTime),
                new SqlParameter("@CallerNum",SqlDbType.VarChar,30),
                new SqlParameter("@FaxNum",SqlDbType.VarChar,30)
            };
            param[0].Value = node.SeqNo;
            param[1].Value = node.EmailType;
            param[2].Value = node.EmailList;
            param[3].Value = node.FileName;
            param[4].Value = node.FilePath;
            param[5].Value = node.BatchNo;
            param[6].Value = node.SendTime;
            param[7].Value = node.RecTime;
            param[8].Value = node.CallerNum;
            param[9].Value = node.FaxNum;
            //UP_Mail_Bill_Add 5,3,'wangxun@yuantel.com','r106020080527142617.tif','d:\emaildir\200805\29\faxtoemail\','','2008-5-29 18:36:43','2008-5-29 18:36:43','15810000001','15810000001,1010'
            try
            {
                int i = MainDAC.ExecuteNonQuery(Mail_SERVER, "UP_Mail_Bill_Add", param);
                return i;
            }
            catch
            {
                return 0;
            }
        }
    }
}
