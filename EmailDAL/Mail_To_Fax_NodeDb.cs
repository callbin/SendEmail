using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Fax.DBUtility;

namespace Fax.EmailDAL
{
    public class Mail_To_Fax_NodeDb
    {
        public Mail_To_Fax_NodeDb()
        { }

        private const string Mail_SERVER = "ytMail";

        public static void Mail_Rec_Add(Mail_Rec_NodeInf node)
        {
            SqlParameter[] param = 
            { 
                new SqlParameter("@SenderMail",SqlDbType.VarChar,100),
                new SqlParameter("@ReceiverMail",SqlDbType.VarChar,100),
                new SqlParameter("@SendTime",SqlDbType.DateTime),
                new SqlParameter("@SenderName",SqlDbType.VarChar,60),
                new SqlParameter("@ReceiverName",SqlDbType.VarChar,60),
                new SqlParameter("@FileName",SqlDbType.VarChar,200),
                new SqlParameter("@FilePath",SqlDbType.VarChar,30),
                new SqlParameter("@FaxNum",SqlDbType.VarChar,30),
                new SqlParameter("@Subject",SqlDbType.VarChar,100),
                new SqlParameter("@AreaID",SqlDbType.VarChar,6)
            };
            param[0].Value = node.SenderMail;
            param[1].Value = node.ReceiverMail;
            param[2].Value = node.SendTime;
            param[3].Value = node.SenderName;
            param[4].Value = node.ReceiverName;
            param[5].Value = node.FileName;
            param[6].Value = node.FilePath;
            param[7].Value = node.FaxNum;
            param[8].Value = node.Subject;
            param[9].Value = node.AreaID;

            try
            {
                MainDAC.ExecuteNonQuery(Mail_SERVER,CommandType.StoredProcedure, "UP_Mail_Rec_Add", param);
            }
            catch { }
            finally
            {
                param = null;
            }
        }

        public static DataSet Mail_Rec_GetList(int rows)
        {
            DataSet ds = new DataSet();
            SqlParameter[] parem =
                { 
                    new SqlParameter("@Rows",SqlDbType.VarChar,3)
                };
            parem[0].Value = rows.ToString();

            try
            {
                ds = MainDAC.ExecuteDataset(Mail_SERVER,CommandType.StoredProcedure, "UP_Mail_Rec_GetList", parem);
            }
            catch
            {
                ds = null;
            }
            finally
            {
                parem = null;
            }

            return ds;
        }

        /// <summary>
        /// 通过编号类型产生编号（批次号和文件名）
        /// </summary>
        /// <param name="_clsid">_clsid 编号类型:
        ///1  传真单发送批次号及文件
        ///2   传真群发送批次号及文件
        ///3   待定
        ///4   Email传真发送文件编号
        ///5   群发录文件
        ///6   个性语音文件
        ///7   单发文件
        ///</param>
        /// <returns>编号</returns>
        public static string GetCommonCodeByClsID(string _clsid)
        {
            string BatchNo = "";
            SqlParameter[] parameters = {
					new SqlParameter("@ClsID", SqlDbType.Int,4),//编号类型
                    new SqlParameter("@BatchNo",SqlDbType.VarChar,50)
					};
            parameters[0].Value = _clsid;
            parameters[1].Direction = ParameterDirection.Output;
            try
            {
                SqlHelper.ExecuteScalar(SqlHelper.ConnectionStringytSys, CommandType.StoredProcedure, "UP_Sys_Common_Code_CreateNew", parameters);
                BatchNo = parameters[1].Value.ToString().Trim();
            }
            catch
            {
                BatchNo = "";
            }
            return BatchNo;
        }

        public static DataTable GetUserInfoByEmail(string email)
        {
            DataTable dt = null;
            SqlParameter[] param = { new SqlParameter("@Email", SqlDbType.VarChar, 50) };
            param[0].Value = email;
            try
            {
                dt = SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, "UP_GetUserInfoByEmail_ForMail2Fax", param);
            }
            catch
            { }
            finally
            {
                param = null;
            }
            return dt;
        }

        //public static DataTable GetFaxUserAllInfo(string IAppCode, int SeqNo)
        //{
        //    DataTable dt = null;
        //    try
        //    {
        //        SqlParameter[] parameters = {
        //            new SqlParameter("@IAppCode", SqlDbType.VarChar,50),
        //            new SqlParameter("@SeqNo", SqlDbType.Int)
        //        };
        //        parameters[0].Value = IAppCode;
        //        parameters[1].Value = SeqNo;
        //        dt = SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, "UP_Fax_UserInfo_GetSendInfo", parameters);
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    finally
        //    {
        //    }
        //    return dt;
        //}

        //public static DataSet GetCreditInfo(int seqNo,out int userType)
        //{
        //    DataSet ds = null;
        //    SqlParameter[] parameters = {
        //           new SqlParameter("@SeqNo", SqlDbType.Int),
        //        new SqlParameter("@UserType",SqlDbType.Int)
        //        };
        //    parameters[0].Value = seqNo;
        //    parameters[1].Direction = ParameterDirection.Output;
        //    try
        //    {
        //        ds = SqlHelper.ExecuteDataset(SqlHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, "UP_Fax_GetCreditInfo", parameters);
        //        userType = int.Parse(parameters[1].Value.ToString());
        //    }
        //    catch (Exception ex)
        //    {
        //        userType = 0;
        //    }
        //    return ds;
        //}
    }
}
