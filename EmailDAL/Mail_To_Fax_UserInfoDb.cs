using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Fax.DBUtility;

namespace EmailDAL
{
    public class Mail_To_Fax_UserInfoDb
    {
        private const string Develop_SERVER = "ytDevelop";

        public Mail_To_Fax_UserInfoDb()
        { }

        public static DataTable GetUserInfoByEmail(string email)
        {
            DataTable dt = null;
            SqlParameter[] param = { new SqlParameter("@Email", SqlDbType.VarChar, 50) };
            param[0].Value = email;
            try
            {
                dt = MainDAC.ExecuteDataTable(Develop_SERVER, CommandType.StoredProcedure, "UP_Fax_UserInfo_GetInfoByEmail", param);
            }
            catch
            { }
            finally
            {
                param = null;
            }
            return dt;
        }

        public static DataTable GetFaxUserAllInfo(string IAppCode, int SeqNo)
        {
            DataTable dt = null;
            SqlParameter[] param = {
                    new SqlParameter("@IAppCode", SqlDbType.VarChar,50),
                    new SqlParameter("@SeqNo", SqlDbType.Int)
                };
            param[0].Value = IAppCode;
            param[1].Value = SeqNo;
            try
            {
                dt = MainDAC.ExecuteDataTable(Develop_SERVER, CommandType.StoredProcedure, "UP_Fax_UserInfo_GetSendInfo", param);
            }
            catch
            { }
            finally
            {
                param = null;
            }
            return dt;
        }
    }
}
