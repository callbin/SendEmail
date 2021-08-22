//********************************************************************************************************
//Copyright(C) 2008  Զ�ؼ����� 
//�ļ�����Fax_UserInfoDb.cs
//��  �ߣ����Ĳ�
//�ա��ڣ�2008/04/11
//�衡������[�����û���Ϣ��<Fax_UserInfo>]�����ݲ�DB������
//�桡����2.00
//�޸���ʷ��¼
//�桡�������������޸�ʱ�䡡�����������޸��ˡ����������������
//  2.00                                  2008/04/11                               ���Ĳ��������������½�
//  2.00                                  2008/05/21                               ���Ĳ�������������׷������Ϊֱ���û�������£����´����û���Ϣ��
//  2.00                                  2008/05/27                               ����              ׷�ӷ���GetUserInfoByEmail
//<Fax_UserInfo>�Ļ�����Ϣ
//********************************************************************************************************

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Fax.DBUtility;

namespace EmailDAL
{
	/// <summary>
	/// ���ݷ�����Fax_UserInfoDb��
	/// </summary>
	public class Fax_UserInfoDb
	{
        DataTable dt = null;

	    public Fax_UserInfoDb()
		  {}

        #region  ��Ա����

        #region �����û�ID��SeqNo���õ������û���Ϣ��<Fax_UserInfo>��������Ϣ
        ///<summary>
        ///�����û�ID��SeqNo���õ������û���Ϣ��<Fax_UserInfo>��������Ϣ
        ///</summary>
        /// <param name="SeqNo">�û�ID</param>
        /// <returns></returns>
        public Fax_UserInfoInf GetFaxUserInfoInfo(int SeqNo)
        {
            SqlParameter[] parameters = {
					new SqlParameter("@SeqNo", SqlDbType.Int,4)};
            parameters[0].Value = SeqNo;

            Fax_UserInfoInf model = new Fax_UserInfoInf();
            DataSet ds = SqlHelper.RunProcedure("UP_Fax_UserInfo_GetModel", parameters, "ds");
            if (ds.Tables[0].Rows.Count > 0)
            {
                model.SendVoice = ds.Tables[0].Rows[0]["SendVoice"].ToString();
                model.RecvVoice = ds.Tables[0].Rows[0]["RecvVoice"].ToString();
                model.SellUName = ds.Tables[0].Rows[0]["SellUName"].ToString();
                model.MsgValue = ds.Tables[0].Rows[0]["MsgValue"].ToString();

                if (ds.Tables[0].Rows[0]["IsEmail"].ToString() != "")
                {
                    model.IsEmail = int.Parse(ds.Tables[0].Rows[0]["IsEmail"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsSms"].ToString() != "")
                {
                    model.IsSms = int.Parse(ds.Tables[0].Rows[0]["IsSms"].ToString());
                }
                model.Mobile = ds.Tables[0].Rows[0]["Mobile"].ToString();
                model.Email = ds.Tables[0].Rows[0]["Email"].ToString();
                if (ds.Tables[0].Rows[0]["ResendTimes"].ToString() != "")
                {
                    model.ResendTimes = int.Parse(ds.Tables[0].Rows[0]["ResendTimes"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ResendDelay"].ToString() != "")
                {
                    model.ResendDelay = int.Parse(ds.Tables[0].Rows[0]["ResendDelay"].ToString());
                }
                model.Sender = ds.Tables[0].Rows[0]["Sender"].ToString();
                model.LocalCSID = ds.Tables[0].Rows[0]["LocalCSID"].ToString();
                if (ds.Tables[0].Rows[0]["Priority"].ToString() != "")
                {
                    model.Priority = int.Parse(ds.Tables[0].Rows[0]["Priority"].ToString());
                }
                model.SenderCompany = ds.Tables[0].Rows[0]["SenderCompany"].ToString();
                if (ds.Tables[0].Rows[0]["IsProbational"].ToString() != "")
                {
                    model.IsProbational = int.Parse(ds.Tables[0].Rows[0]["IsProbational"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UserType"].ToString() != "")
                {
                    model.UserType = int.Parse(ds.Tables[0].Rows[0]["UserType"].ToString());
                }
                if (ds.Tables[0].Rows[0]["State"].ToString() != "")
                {
                    model.State = int.Parse(ds.Tables[0].Rows[0]["State"].ToString());
                }
                model.IAppCode = ds.Tables[0].Rows[0]["IAppCode"].ToString();
                return model;
            }
            else
            {
                return null;
            }
        }
        #endregion

        #region �жϴ����û���Ϣ��<Fax_UserInfo>�Ļ�����Ϣ�У�Email�Ƿ��ظ�
        ///<summary>
        ///���´����û���Ϣ��<Fax_UserInfo>�Ļ�����Ϣ
        ///</summary>
        /// <param name="SeqNo">�û�ID</param>
        /// <param name="Email">��Ҫ���ѵĵ����ʼ�������������Ҫʹ�ð�ǵķֺŸ���";"</param>
        /// <param name="Repeat">�ʼ��Ƿ��ظ� 0 Ϊ���ظ���1λ�ظ�</param>
        /// <returns></returns>
        //public void FaxUserInfoEmailRepeat(Fax_UserInfoInf model, out int Repeat)
        //{
        //    SqlParameter[] parameters = {
        //            //new SqlParameter("@SeqNo", SqlDbType.Int,4),
        //            new SqlParameter("@Email", SqlDbType.VarChar,50),
        //            new SqlParameter("@Repeat", SqlDbType.Int,4)
        //    };
        //    //parameters[0].Value = model.SeqNo;
        //    parameters[0].Value = model.Email;
        //    parameters[1].Direction = ParameterDirection.Output;

        //    try
        //    {
        //        SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, "UP_Fax_UserInfo_Repeat", parameters);
        //        Repeat = 2;
        //        if (parameters[1].Value != null)
        //        {
        //            Repeat = (int)parameters[1].Value;
        //        }
        //    }
        //    catch
        //    {
        //        Repeat = 2;
        //    }
        //}
        #endregion

        #region ���´����û���Ϣ��<Fax_UserInfo>�Ļ�����Ϣ
        ///<summary>
        ///���´����û���Ϣ��<Fax_UserInfo>�Ļ�����Ϣ
        ///</summary>
        /// <param name="IsEmail">�Ƿ���ҪEmail���ѣ�1 Ϊ��Ҫ��0 Ϊ����Ҫ</param>
        /// <param name="IsSms">�Ƿ���Ҫ�������ѣ�1 Ϊ��Ҫ��0 Ϊ����Ҫ</param>
        /// <param name="Mobile">��Ҫ���ѵ��ֻ���</param>
        /// <param name="Email">��Ҫ���ѵĵ����ʼ�������������Ҫʹ�ð�ǵķֺŸ���";"</param>
        /// <param name="Sender">������</param>
        /// <param name="SenderCompany">���͹�˾����</param>
        /// <returns></returns>
        //public int UpdateFaxUserInfoInfo(Fax_UserInfoInf model)
        //{
        //    SqlParameter[] parameters = {
        //            new SqlParameter("@IsEmail", SqlDbType.TinyInt,1),
        //            new SqlParameter("@IsSms", SqlDbType.TinyInt,1),
        //            new SqlParameter("@Mobile", SqlDbType.VarChar,15),
        //            new SqlParameter("@Email", SqlDbType.VarChar,50),
        //            new SqlParameter("@Sender", SqlDbType.VarChar,30),
        //            new SqlParameter("@SenderCompany", SqlDbType.VarChar,30),
        //            new SqlParameter("@SeqNo", SqlDbType.Int,4),
        //                 new SqlParameter("@SendVoice", SqlDbType.VarChar,30),
        //                 new SqlParameter("@RecvVoice", SqlDbType.VarChar,30),
        //            new SqlParameter("@MsgValue", SqlDbType.Xml),
        //            new SqlParameter("@EmailValue", SqlDbType.Xml)
        //    };
        //    parameters[0].Value = model.IsEmail;
        //    parameters[1].Value = model.IsSms;
        //    parameters[2].Value = model.Mobile;
        //    parameters[3].Value = model.Email;                                                                                         
        //    parameters[4].Value = model.Sender;                 
        //    parameters[5].Value = model.SenderCompany;
        //    parameters[6].Value = model.SeqNo;
        //    parameters[7].Value = model.SendVoice;
        //    parameters[8].Value = model.RecvVoice;
        //    parameters[9].Value = model.MsgValue;
        //    parameters[10].Value = model.EmailValue;
        //    try
        //    {
        //        SqlHelper.ExecuteDataset(SqlHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, "UP_Fax_UserInfo_Update", parameters);
        //        return 0;
        //    }
        //    catch
        //    {
        //        return 1;
        //    }
        //    finally
        //    {
        //        parameters = null;
        //    }
        //}
        #endregion

        #region �����û�ID��SeqNo���õ������û���Ϣ��Fax_UserInfo��Fax_UserFaxNumber��IB_Account�Ļ�����Ϣ
        ///<summary>
        ///�����û�ID��SeqNo���õ������û���Ϣ��Fax_UserInfo��Fax_UserFaxNumber��IB_Account�Ļ�����Ϣ
        ///</summary>
        /// <param name="IAppCode">Ӧ�ñ��</param>
        /// <param name="SeqNo">�û�ID</param>
        /// <returns></returns>
        //public DataTable GetFaxUserAllInfo(string IAppCode, int SeqNo)
        //{
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
        //    catch
        //    {
                
        //    }
        //    finally
        //    {
        //    }
        //    return dt;
        //}
        #endregion  

        #region ����Ϊֱ���û�������£����´����û���Ϣ��<Fax_UserInfo>�Ļ�����Ϣ
        ///<summary>
        ///����Ϊֱ���û�������£����´����û���Ϣ��<Fax_UserInfo>�Ļ�����Ϣ
        ///</summary>
        /// <param name="SeqNo">�û�ϵͳ��� ��ʶ �������</param>
        /// <param name="UserType">     1	 ֱ���û�
	                                               ///2	 �ֻ��û�
	                                               ///3	 ��ҵ�û�
	                                               ///4  ��ҵ�û��·ֻ��û�
                                                   ///5 ��ҵ�ܻ��û�
	                                               ///6  400
	                                               ///7	   ֻ���û�
	                                               ///8	   ��Ӫ�̣���ʱ���ã�
	                                               ///9	   ԭ���ĺ󸶷�
	                                               ///10	��������û�
	                                               ///11	800
	                                               ///12	�ֻ�����Ա</param>
        /// <returns></returns>
        //public int UpdateFaxUserInfo(Fax_UserInfoInf model)
        //{
        //    SqlParameter[] parameters = {
        //            new SqlParameter("@SeqNo", SqlDbType.Int,4),
        //                 new SqlParameter("@UserType", SqlDbType.Int,4)
        //    };
        //    parameters[0].Value = model.SeqNo;
        //    parameters[1].Value = model.UserType;
        //    try
        //    {
        //        SqlHelper.ExecuteDataset(SqlHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, "UP_Fax_UserInfo_Update_SJ", parameters);
        //        return 0;
        //    }
        //    catch
        //    {
        //        return 1;
        //    }
        //    finally
        //    {
        //        parameters = null;
        //    }
        //}
        #endregion

        #region ���������ַ��ȡ�û���Ϣ
        //public DataTable GetUserInfoByEmail(string email)
        //{
        //    SqlParameter[] param = { new SqlParameter("@Email", SqlDbType.VarChar, 50) };
        //    param[0].Value = email;
        //    try
        //    {
        //        dt = SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, "UP_Fax_UserInfo_GetInfoByEmail", param);
        //    }
        //    catch
        //    { }
        //    finally
        //    {
        //        param = null;
        //    }
        //    return dt;
        //}
        #endregion

        #endregion  ��Ա����
    }
}

