//==================================================================
// Copyright (C) 2008 远特技术部
// 文件名: Mail_Send_NodeDb.cs
// 作 者：朱翔
// 日 期：2008/05/22
// 描 述：发送邮件数据层DB操作类
// 版 本：2.00

//==================================================================

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Fax.DBUtility;

namespace Fax.EmailDAL
{
    public class Mail_Send_NodeDb
    {
        public Mail_Send_NodeDb()
        { }

        private const string Mail_SERVER = "ytMail";

        public DataSet Mail_Send_GetList(int rows)
        {
            DataSet ds = null;

            SqlParameter[] param = { new SqlParameter("@Rows", SqlDbType.VarChar, 3) };
            param[0].Value = rows.ToString();

            try
            {
                ds = MainDAC.ExecuteDataset(Mail_SERVER,CommandType.StoredProcedure, "UP_Mail_GetList", param);
                return ds;
            }
            catch
            {
                return null;
            }
        }

        public void Mail_Send_UpdateSts(int smsID, int sts)
        {
            SqlParameter[] param = { new SqlParameter("@EmailID", SqlDbType.VarChar, 10), new SqlParameter("@Sts", SqlDbType.VarChar, 3) };
            param[0].Value = smsID.ToString();
            param[1].Value = sts.ToString();

            try
            {
                MainDAC.ExecuteNonQuery(Mail_SERVER,CommandType.StoredProcedure, "UP_Mail_UpdateSts", param);
            }
            catch
            { }
        }

        public void Mail_Send_Insert(int channelID, int templateID, int seqNo, int emailType, string emailList, string emailTitle)
        {
            SqlParameter[] param = { new SqlParameter("@ChannelID", SqlDbType.VarChar, 6), new SqlParameter("@TemplateID", SqlDbType.VarChar, 6), new SqlParameter("@SeqNo", SqlDbType.VarChar, 20), new SqlParameter("@EmailType", SqlDbType.VarChar, 6), new SqlParameter("@EmailList", SqlDbType.VarChar, 300), new SqlParameter("@EmailTitle", SqlDbType.VarChar, 300) };
            param[0].Value = channelID.ToString();
            param[1].Value = templateID.ToString();
            param[2].Value = seqNo.ToString();
            param[3].Value = emailType.ToString();
            param[4].Value = emailList;
            param[5].Value = emailTitle;

            try
            {
                MainDAC.ExecuteNonQuery(Mail_SERVER,CommandType.StoredProcedure, "UP_Mail_Bill_Add", param);
            }
            catch { }
        }

        public static void SendMail(int seqNo, string batchNo, string email,string faxNum,int emailType,string failedReason)
        {
                SqlParameter[] param = { 
                    new SqlParameter("@SeqNo",SqlDbType.Int),
                    new SqlParameter("@EmailType",SqlDbType.Int),
                    new SqlParameter("@EmailList",SqlDbType.VarChar),
                    new SqlParameter("@BatchNo",SqlDbType.VarChar),
                    new SqlParameter("@Param1",SqlDbType.VarChar),
                    new SqlParameter("@Param2",SqlDbType.VarChar),
                    new SqlParameter("@Param3",SqlDbType.VarChar),
                    new SqlParameter("@Param4",SqlDbType.VarChar),
                    new SqlParameter("@Param5",SqlDbType.VarChar),
                    new SqlParameter("@Param6",SqlDbType.VarChar),
                    new SqlParameter("@Param7",SqlDbType.VarChar),
                    new SqlParameter("@Param8",SqlDbType.VarChar),
                    new SqlParameter("@Param9",SqlDbType.VarChar),
                    new SqlParameter("@Param10",SqlDbType.VarChar)
                };
                param[0].Value = seqNo;
                param[1].Value = emailType;
                param[2].Value = email;
                param[3].Value = batchNo;
                param[4].Value = faxNum;
                param[5].Value = failedReason;
                param[6].Value = "";
                param[7].Value = "";
                param[8].Value = "";
                param[9].Value = "";
                param[10].Value = "";
                param[11].Value = "";
                param[12].Value = "";
                param[13].Value = "";

                MainDAC.ExecuteNonQuery("ytMail", CommandType.StoredProcedure, "UP_Mail_Bill_Add_V1", param);
        }

        public static void DeleteFaxMailTemp(string batchNo)
        {
            SqlParameter[] param = { new SqlParameter("@BatchNo", SqlDbType.VarChar) };
            param[0].Value = batchNo;
            MainDAC.ExecuteNonQuery("ytMail", CommandType.StoredProcedure, "UP_Email_Fax_Delete", param);
        }
    }
}
