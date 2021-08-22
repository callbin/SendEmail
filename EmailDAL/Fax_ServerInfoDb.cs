//********************************************************************************************************
//Copyright(C) 2008  远特技术部 
//文件名：Fax_ServerInfoDb.cs
//作  者：王勋
//日　期：2008/04/30
//描　述：服务器信息的数据层DB操作类
//版　本：2.00
//修改历史记录
//版　本　　　　　修改时间　　　　　　修改人　　　　　变更内容
//  2.00                                  2008/04/18                               徐文波　　　　　　新建
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
    /// 数据访问类FileTranDb。
    /// </summary>
    public class Fax_ServerInfoDb
    {
        public Fax_ServerInfoDb() { }
        public Sys_Server_Tran_ListInf GetServerInfo(int ClsID)
        {
            SqlParameter[] parameters = {
					new SqlParameter("@ClsID", SqlDbType.Int,4)};
            parameters[0].Value = ClsID;
            int rows = 0;
            Sys_Server_Tran_ListInf model = new Sys_Server_Tran_ListInf();
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.ConnectionStringytSys, "UP_Common_GetTranServeInfoByClsID", parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                model.ServerIP = ds.Tables[0].Rows[0]["ServerIP"].ToString();
                model.AppUrl = ds.Tables[0].Rows[0]["AppUrl"].ToString();
                model.ServerCode = ds.Tables[0].Rows[0]["ServerCode"].ToString();
                model.ExField1 = ds.Tables[0].Rows[0]["SyncURL"].ToString();
                return model;
            }
            else
            {
                return null;
            }
        }
        public Sys_Server_Tran_ListInf GetSendServerInfo(int ClsID)
        {
            SqlParameter[] parameters = {
					new SqlParameter("@ClsID", SqlDbType.Int,4),
            new SqlParameter("@SpecialFlag", SqlDbType.Int,4)};
            parameters[0].Value = ClsID;
            parameters[1].Value = 0;
            int rows = 0;
            Sys_Server_Tran_ListInf model = new Sys_Server_Tran_ListInf();
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.ConnectionStringytSys, "UP_Common_GetSendServeInfoByClsID", parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                model.ServerIP = ds.Tables[0].Rows[0]["ServerIP"].ToString();
                model.AppUrl = ds.Tables[0].Rows[0]["AppUrl"].ToString();
                model.ServerCode = ds.Tables[0].Rows[0]["ServerCode"].ToString();
                model.Lines = int.Parse(ds.Tables[0].Rows[0]["Lines"].ToString());
                return model;
            }
            else
            {
                return null;
            }
        }
        public DataSet GetSendServerList(string TranServerIP, int ClsID, int SpecialFlag)
        {
            SqlParameter[] parameters = {
					new SqlParameter("@ServerIP", SqlDbType.VarChar),
            new SqlParameter("@ClsID", SqlDbType.Int,4),
            new SqlParameter("@SpecialFlag", SqlDbType.Int,4)};
            parameters[0].Value = TranServerIP;
            parameters[1].Value = ClsID;
            parameters[2].Value = SpecialFlag;

            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.ConnectionStringytSys, "UP_Sync_GetSendServeInfoByClsID", parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return ds;
            }
            else
            {
                return null;
            }
        }
   }
}
