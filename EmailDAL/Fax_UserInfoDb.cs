//********************************************************************************************************
//Copyright(C) 2008  远特技术部 
//文件名：Fax_UserInfoDb.cs
//作  者：徐文波
//日　期：2008/04/11
//描　述：表[传真用户信息表<Fax_UserInfo>]的数据层DB操作类
//版　本：2.00
//修改历史记录
//版　本　　　　　修改时间　　　　　　修改人　　　　　变更内容
//  2.00                                  2008/04/11                               徐文波　　　　　　新建
//  2.00                                  2008/05/21                               徐文波　　　　　　追加升级为直拨用户的情况下，更新传真用户信息表
//  2.00                                  2008/05/27                               朱翔              追加方法GetUserInfoByEmail
//<Fax_UserInfo>的基本信息
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
	/// 数据访问类Fax_UserInfoDb。
	/// </summary>
	public class Fax_UserInfoDb
	{
        DataTable dt = null;

	    public Fax_UserInfoDb()
		  {}

        #region  成员方法

        #region 根据用户ID（SeqNo）得到传真用户信息表<Fax_UserInfo>的所有信息
        ///<summary>
        ///根据用户ID（SeqNo）得到传真用户信息表<Fax_UserInfo>的所有信息
        ///</summary>
        /// <param name="SeqNo">用户ID</param>
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

        #region 判断传真用户信息表<Fax_UserInfo>的基本信息中，Email是否重复
        ///<summary>
        ///更新传真用户信息表<Fax_UserInfo>的基本信息
        ///</summary>
        /// <param name="SeqNo">用户ID</param>
        /// <param name="Email">需要提醒的电子邮件，如果多个则需要使用半角的分号隔开";"</param>
        /// <param name="Repeat">邮件是否重复 0 为不重复，1位重复</param>
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

        #region 更新传真用户信息表<Fax_UserInfo>的基本信息
        ///<summary>
        ///更新传真用户信息表<Fax_UserInfo>的基本信息
        ///</summary>
        /// <param name="IsEmail">是否需要Email提醒；1 为需要；0 为不需要</param>
        /// <param name="IsSms">是否需要短信提醒；1 为需要；0 为不需要</param>
        /// <param name="Mobile">需要提醒的手机号</param>
        /// <param name="Email">需要提醒的电子邮件，如果多个则需要使用半角的分号隔开";"</param>
        /// <param name="Sender">发送人</param>
        /// <param name="SenderCompany">发送公司名称</param>
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

        #region 根据用户ID（SeqNo）得到传真用户信息表Fax_UserInfo，Fax_UserFaxNumber，IB_Account的基本信息
        ///<summary>
        ///根据用户ID（SeqNo）得到传真用户信息表Fax_UserInfo，Fax_UserFaxNumber，IB_Account的基本信息
        ///</summary>
        /// <param name="IAppCode">应用编号</param>
        /// <param name="SeqNo">用户ID</param>
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

        #region 升级为直拨用户的情况下，更新传真用户信息表<Fax_UserInfo>的基本信息
        ///<summary>
        ///升级为直拨用户的情况下，更新传真用户信息表<Fax_UserInfo>的基本信息
        ///</summary>
        /// <param name="SeqNo">用户系统编号 标识 传真参数</param>
        /// <param name="UserType">     1	 直拨用户
	                                               ///2	 分机用户
	                                               ///3	 企业用户
	                                               ///4  企业用户下分机用户
                                                   ///5 企业总机用户
	                                               ///6  400
	                                               ///7	   只发用户
	                                               ///8	   运营商（暂时不用）
	                                               ///9	   原来的后付费
	                                               ///10	终身免费用户
	                                               ///11	800
	                                               ///12	分机管理员</param>
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

        #region 根据邮箱地址获取用户信息
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

        #endregion  成员方法
    }
}

