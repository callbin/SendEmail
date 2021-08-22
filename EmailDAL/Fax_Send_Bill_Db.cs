using System;
using System.Collections.Generic;
using System.Text;
using Fax.DBUtility;
using System.Data;
using System.Data.SqlClient;

namespace EmailDAL
{
    public class Fax_Send_Bill_Db
    {
        public static int Fax_Send_Bill_Add(Fax_Send_Bill_Node model)
        {
            try
            {
                SqlParameter[] parameters = {
					new SqlParameter("@IAppCode", SqlDbType.VarChar,50),
					new SqlParameter("@BatchNo", SqlDbType.VarChar,20),
					new SqlParameter("@RefID", SqlDbType.VarChar,50),
					new SqlParameter("@SeqNo", SqlDbType.Int,4),
                    new SqlParameter("@AreaID", SqlDbType.VarChar,10),

					new SqlParameter("@CallerNum", SqlDbType.VarChar,30),
					new SqlParameter("@FaxNum", SqlDbType.VarChar,30),
					new SqlParameter("@RemoteCSID", SqlDbType.NVarChar,60),
					new SqlParameter("@LocalCSID", SqlDbType.NVarChar,60),
					new SqlParameter("@Subject", SqlDbType.NVarChar,60),

					new SqlParameter("@Header", SqlDbType.NVarChar,100),
					new SqlParameter("@Footer", SqlDbType.NVarChar,100),
					new SqlParameter("@Receiver", SqlDbType.NVarChar,60),
					new SqlParameter("@ReceiverCompany", SqlDbType.NVarChar,60),
					new SqlParameter("@MobileList", SqlDbType.VarChar,60),

					new SqlParameter("@ResendDelay", SqlDbType.Int,4),
					new SqlParameter("@ResendTimes", SqlDbType.Int,4),
                    new SqlParameter("@EmailList", SqlDbType.VarChar,100),
					new SqlParameter("@CoverPage", SqlDbType.NVarChar,400),
                    new SqlParameter("@SendTime", SqlDbType.DateTime),

					new SqlParameter("@FaxFile", SqlDbType.VarChar,300),
					new SqlParameter("@UserFile", SqlDbType.VarChar,300),
					new SqlParameter("@TranServerName", SqlDbType.VarChar,20),
                    new SqlParameter("@SendVoice", SqlDbType.VarChar),
                    new SqlParameter("@AuditingFlag",SqlDbType.Int,4),

                    new SqlParameter("@Result",SqlDbType.Int,4)
                };
                parameters[0].Value = model.IAppCode;
                parameters[1].Value = model.BatchNo;
                parameters[2].Value = model.RefID;
                parameters[3].Value = model.SeqNo;
                parameters[4].Value = model.AreaID;

                parameters[5].Value = model.CallerNum;
                parameters[6].Value = model.FaxNum;
                parameters[7].Value = model.RemoteCSID;
                parameters[8].Value = model.LocalCSID;
                parameters[9].Value = model.Subject;

                parameters[10].Value = model.Header;
                parameters[11].Value = model.Footer;
                parameters[12].Value = model.Receiver;
                parameters[13].Value = model.ReceiverCompany;
                parameters[14].Value = model.MobileList;

                parameters[15].Value = model.ResendDelay;
                parameters[16].Value = model.ResendTimes;
                parameters[17].Value = model.EmailList;
                parameters[18].Value = model.CoverPage;
                parameters[19].Value = model.SendTime;

                parameters[20].Value = model.FaxFile;
                parameters[21].Value = model.UserFile;
                parameters[22].Value = model.TranServerName;
                parameters[23].Value = model.SendVoice;
                parameters[24].Value = model.AuditingFlag;

                parameters[25].Direction = ParameterDirection.Output;

                MainDAC.ExecuteNonQuery("ytFax_DB", CommandType.StoredProcedure, "UP_Fax_Send_Bill_ADD", parameters);
                return int.Parse(parameters[25].Value.ToString());
            }
            catch
            {
                return -1;
            }
        }

        //public static Int64 GetBanlance(int SeqNo)
        //{
        //    try
        //    {
        //        SqlParameter[] param = { 
        //            new SqlParameter("@SeqNo",SqlDbType.Int),
        //            new SqlParameter("@Balance",SqlDbType.BigInt)
        //        };
        //        param[0].Value = SeqNo;
        //        param[1].Direction = ParameterDirection.Output;

        //        MainDAC.ExecuteScalar("ytFax", CommandType.StoredProcedure, "IB_UP_GetClientBalance", param);
        //        return Int64.Parse(param[1].Value.ToString());
        //    }
        //    catch
        //    {
        //        return 0;
        //    }
        //}
        
        /// <summary>
        /// 获取用户金额账户信息列表 Create by lining at 2011-3-16
        /// </summary>
        /// <param name="seqNo"></param>
        /// <param name="ProductID"></param>
        /// <param name="CostType">付费类型   0：全部  1：通信费帐户   2：非通信费帐户（租用费帐户或包年费用帐户）</param>
        /// <param name="FeeTypeIndex">通话类型ID 如果为：-1不进行判断 </param>
        /// <param name="TotalBalance">输出参数--充值余额总数 </param>
        /// <param name="TotalDonatedBalance">输出参数--赠送余额总数 </param>
        /// <returns></returns>
        public static Int64 GetBanlance(int SeqNo)
        {
            Int64 balance = 0;
            try
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@SeqNo", SqlDbType.Int)
                   ,new SqlParameter("@ProductID", SqlDbType.Int)
                   ,new SqlParameter("@CostType", SqlDbType.TinyInt)
                   ,new SqlParameter("@FeeTypeIndex", SqlDbType.Int)
                };
                parameters[0].Value = SeqNo;
                parameters[1].Value = 50;
                parameters[2].Value = 1;
                parameters[3].Value = -1;

                using (SqlDataReader rdr = SqlHelper.ExecuteReader(SqlHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, "UP_IB_V3_I_GetClientAccountList", parameters))
                {
                    if (rdr != null)
                    {
                        while (rdr.Read())
                        {
                            if (!rdr.IsDBNull(3)) balance += rdr.GetInt64(3);
                            if (!rdr.IsDBNull(4)) balance += rdr.GetInt64(4);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return balance;
        }

        public static string GetFilePath(int ClsID)
        {
            try
            {
                SqlParameter[] param = { 
                    new SqlParameter("@ClsID",SqlDbType.Int),
                    new SqlParameter("@FilePath",SqlDbType.VarChar,50)
                };
                param[0].Value = ClsID;
                param[1].Direction = ParameterDirection.Output;

                MainDAC.ExecuteScalar("ytFax_DB", CommandType.StoredProcedure, "UP_Common_FaxFilePath", param);
                return param[1].Value.ToString();
            }
            catch
            {
                return "";
            }
        }

        /// <summary>
        /// 添加邮件传真对应关系表
        /// </summary>
        /// <param name="batchNo">批次号</param>
        /// <param name="seqNo">用户编号</param>
        /// <param name="email">邮箱地址</param>
        public static void InsertEmailFax(string batchNo, int seqNo, string email,string faxNum)
        {
            try
            {
                SqlParameter[] param = {
                    new SqlParameter("@BatchNo",SqlDbType.VarChar),
                    new SqlParameter("SeqNo",SqlDbType.Int),
                    new SqlParameter("@Email",SqlDbType.VarChar),
                    new SqlParameter("@FaxNum",SqlDbType.VarChar)
                };
                param[0].Value = batchNo;
                param[1].Value = seqNo;
                param[2].Value = email;
                param[3].Value = faxNum;

                MainDAC.ExecuteNonQuery("ytMail", CommandType.StoredProcedure, "UP_Email_Fax_Add", param);
            }
            catch { }
        }

        /// <summary>
        /// 删除一条已发送的邮件传真记录
        /// </summary>
        /// <param name="batchNo">批次号</param>
        public static void DeleteEmailFax(string batchNo)
        {
            try
            {
                SqlParameter[] param = {
                    new SqlParameter("@BatchNo",SqlDbType.VarChar)
                };
                param[0].Value = batchNo;

                MainDAC.ExecuteNonQuery("ytMail", CommandType.StoredProcedure, "UP_Email_Fax_Delete", param);
            }
            catch { }
        }

        /// <summary>
        /// 获取邮件转换传真的记录列表
        /// </summary>
        /// <returns></returns>
        public static DataSet GetEmailFax()
        {
            DataSet ds = new DataSet();
            try
            {
                ds = MainDAC.ExecuteDataset("ytMail", CommandType.StoredProcedure, "UP_Email_Fax_GetList", null);
            }
            catch 
            {
                ds = null;
            }
            return ds;
        }
    }
}
