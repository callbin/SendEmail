//********************************************************************************************************
//Copyright(C) 2008  远特技术部 
//文件名：Fax_Send_TranFile_NodeDb.cs
//作  者：王勋
//日　期：2008/04/22
//描　述：文件转换数据层DB操作类
//版　本：2.00
//修改历史记录
//版　本　　　　　修改时间　　　　　　修改人　　　　　变更内容
//  2.00                                  2008/04/22                               王勋　　　　　　新建
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
	/// 数据访问类Fax_Send_TranFile_NodeDb。
	/// </summary>
	public class Fax_Send_TranFile_NodeDb
	{
        private const string RECV_SERVER = "ytRecv_DB";
        private const string SEND_SERVER = "ytFax_DB";
		public Fax_Send_TranFile_NodeDb()
		{}
        #region  成员方法
        /// <summary>
        /// 根据服务器IP得到需要转换的文件列表
        /// </summary>
        /// <param name="ServerIP">服务器IP</param>
        /// <param name="TableIndex">存放数据的表索引</param>
        /// <param name="Rows">每次提取的行数</param>
        /// <returns>需要转换的文件列表</returns>
        public DataSet Fax_Send_GetListForTranFile(string ServerIP, int TableIndex, int Rows, int SendType)
        {
            DataSet ds = null;
            SqlParameter[] parameters = 
			{
                new SqlParameter("@ServerIP", SqlDbType.VarChar),
                new SqlParameter("@TableIndex", SqlDbType.VarChar),
                new SqlParameter("@Rows", SqlDbType.VarChar),
                new SqlParameter("@SendType", SqlDbType.VarChar)
			};
            parameters[0].Value = ServerIP;
            parameters[1].Value = TableIndex.ToString();
            parameters[2].Value = Rows.ToString();
            parameters[3].Value = SendType.ToString();
            try
            {
                ds = MainDAC.ExecuteDataset(SqlHelper.ConnectionStringytFax_DB, CommandType.StoredProcedure, "UP_Fax_Send_GetListForTranFile", parameters);
                if (ds.Tables[0].Rows.Count == 0) ds = null;
                return ds;
            }
            catch
            {
                return null;
            }
            finally
            {
                parameters = null;
            }
        }
        /// <summary>
        /// 根据服务器IP得到需要同步的数据列表
        /// </summary>
        /// <param name="ServerIP">服务器IP</param>
        /// <param name="TableIndex">存放数据的表索引</param>
        /// <param name="Rows">每次提取的行数</param>
        /// <returns>需要同步的数据列表</returns>
        public DataSet Fax_Send_GetListForSync(string ServerIP, int TableIndex, int Rows, int SendType)
        {
            DataSet ds = null;
            SqlParameter[] parameters = 
			{
                new SqlParameter("@TranServerIP", SqlDbType.VarChar),
                new SqlParameter("@TableIndex", SqlDbType.VarChar),
                new SqlParameter("@Rows", SqlDbType.VarChar),
                new SqlParameter("@SendType", SqlDbType.VarChar)
			};
            parameters[0].Value = ServerIP;
            parameters[1].Value = TableIndex.ToString();
            parameters[2].Value = Rows.ToString();
            parameters[3].Value = SendType.ToString();
            try
            {                
                ds = SqlHelper.ExecuteDataset(SqlHelper.ConnectionStringytFax_DB, CommandType.StoredProcedure, "UP_Fax_Send_GetListForSyncData", parameters);
                if (ds.Tables[0].Rows.Count == 0) ds = null;
                return ds;
            }
            catch
            {
                return null;
            }
            finally
            {
                parameters = null;
            }
        }
        /// <summary>
        /// 根据转换服务器IP得到需要同步的发送状态数据列表
        /// </summary>
        /// <param name="ServerIP">服务器IP</param>
        /// <param name="SendType">发送类型</param>
        /// <param name="Rows">每次提取的行数</param>
        /// <returns>根据转换服务器IP得到需要同步的发送状态数据列表</returns>
        //public DataSet SyncFaxSendSts(string ServerIP, int SendType, int Rows)
        //{
        //    DataSet ds = null;
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@TranServerIP", SqlDbType.VarChar),
        //        new SqlParameter("@SendType", SqlDbType.VarChar),
        //        new SqlParameter("@Rows", SqlDbType.VarChar)
        //    };
        //    parameters[0].Value = ServerIP;
        //    parameters[1].Value = SendType.ToString();
        //    parameters[2].Value = Rows.ToString();
        //    try
        //    {
        //        ds = SqlHelper.ExecuteDataset(SqlHelper.ConnectionStringytSend_DB, CommandType.StoredProcedure, "UP_Fax_Send_GetReturnStatsDataList", parameters);
        //        if (ds.Tables[0].Rows.Count == 0) ds = null;
        //        return ds;
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //    finally
        //    {
        //        parameters = null;
        //    }
        //}
        ///<summary>
        ///更新转换后的状态信息
        ///</summary>
        /// <param name="model">Fax.Model.Fax_Send_TranFile_NodeInf 类型节点</param>
        /// <returns></returns>
        public int Fax_Send_TranFile_Node_Update(Fax_Send_TranFile_NodeInf model, int SendType, int TableIndex, string TranServerName)
        {
            int rowsAffected = 0;
            SqlParameter[] parameters = {
                new SqlParameter("@FlowCode", SqlDbType.VarChar),  
                new SqlParameter("@BatchNo", SqlDbType.VarChar),
                new SqlParameter("@SendType", SqlDbType.VarChar),
                new SqlParameter("@TableIndex", SqlDbType.VarChar),
                new SqlParameter("@RemoteFile", SqlDbType.VarChar),
                new SqlParameter("@Pages", SqlDbType.Int),
                new SqlParameter("@CurrentFlow", SqlDbType.Int),
                new SqlParameter("@FailedIndex", SqlDbType.Int),
                new SqlParameter("@AddID", SqlDbType.Int),
                new SqlParameter("@TranServerName", SqlDbType.VarChar),
                new SqlParameter("@Result", SqlDbType.Int)
                };
            parameters[0].Value = model.FlowCode;
            parameters[1].Value = model.BatchNo;
            parameters[2].Value = SendType;
            parameters[3].Value = TableIndex;
            parameters[4].Value = model.RemoteFile;
            parameters[5].Value = model.Pages;
            parameters[6].Value = model.CurrentFlow;
            parameters[7].Value = model.FailedIndex;
            parameters[8].Value = model.AddID;
            parameters[9].Value = TranServerName;
            parameters[10].Direction = ParameterDirection.Output;
            try
            {
                SqlHelper.RunProcedure(SqlHelper.ConnectionStringytFax_DB, "UP_Fax_Send_TranFile_Node_Update", parameters, out rowsAffected);
                return (int)parameters[8].Value;
            }
            catch
            {
                return 5;
            }
        }
        ///<summary>
        ///在发送服务器上保存从转换服务器上同步过来的信息
        ///</summary>
        /// <param name="model">Fax.Model.Fax_Send_TranFile_NodeInf 类型节点</param>
        /// <returns></returns>
        //public int Fax_Sync_Save_TranInfo(Fax_Send_SyncData_NodeInf model)
        //{
        //    int rowsAffected = 0;
        //    SqlParameter[] parameters = {
        //        new SqlParameter("@BatchNo", SqlDbType.VarChar,20),
        //            new SqlParameter("@SysID", SqlDbType.Int,4),
        //            new SqlParameter("@SendType", SqlDbType.Int,4),
        //            new SqlParameter("@SeqNo", SqlDbType.Int,4),
        //            new SqlParameter("@CallerNum", SqlDbType.VarChar,30),
        //            new SqlParameter("@FaxNum", SqlDbType.VarChar,30),
        //            new SqlParameter("@LocalCSID", SqlDbType.NVarChar),
        //            new SqlParameter("@ResendDelay", SqlDbType.Int,4),
        //            new SqlParameter("@ResendTimes", SqlDbType.Int,4),
        //            new SqlParameter("@SubmitTime", SqlDbType.VarChar),
        //            new SqlParameter("@SendTime", SqlDbType.VarChar),
        //            new SqlParameter("@RemoteFilePath", SqlDbType.VarChar,30),
        //            new SqlParameter("@RemoteFile", SqlDbType.VarChar,30),
        //            new SqlParameter("@FaxPages", SqlDbType.Int,4),
        //            new SqlParameter("@TranServerName", SqlDbType.VarChar,20),
        //            new SqlParameter("@SendServerName", SqlDbType.VarChar,20),
        //            new SqlParameter("@Priority", SqlDbType.Int,4),
        //            new SqlParameter("@ClsID", SqlDbType.Int,4),
        //            new SqlParameter("@FailedReason", SqlDbType.Int,4),
        //            new SqlParameter("@Sts", SqlDbType.Int,4),
        //            new SqlParameter("@IAppCode", SqlDbType.VarChar),
        //            new SqlParameter("@FlowCode", SqlDbType.VarChar),
        //            new SqlParameter("@Result", SqlDbType.Int,4)};
        //    parameters[0].Value = model.BatchNo;
        //    parameters[1].Value = model.SysID;
        //    parameters[2].Value = model.SendType;
        //    parameters[3].Value = model.SeqNo;
        //    parameters[4].Value = model.CallerNum;

        //    parameters[5].Value = model.FaxNum;
        //    parameters[6].Value = model.LocalCSID;
        //    parameters[7].Value = model.ResendDelay;
        //    parameters[8].Value = model.ResendTimes;
        //    parameters[9].Value = model.SubmitTime;

        //    parameters[10].Value = model.SendTime;
        //    parameters[11].Value = model.RemoteFilePath;
        //    parameters[12].Value = model.RemoteFile;
        //    parameters[13].Value = model.FaxPages;
        //    parameters[14].Value = model.TranServerName;

        //    parameters[15].Value = model.SendServerName;   
        //    parameters[16].Value = model.Priority;
        //    parameters[17].Value = model.ClsID;
        //    parameters[18].Value = model.FailedReason;
        //    parameters[19].Value = model.Sts;

        //    parameters[20].Value = model.IAppCode;
        //    parameters[21].Value = model.FlowCode;            
        //    parameters[22].Direction = ParameterDirection.Output;
        //    try
        //    {
        //        SqlHelper.RunProcedure(SqlHelper.ConnectionStringytSend_DB, "UP_Fax_Send_Bill_Sync_ADD", parameters, out rowsAffected);
        //        return (int)parameters[22].Value;
        //    }
        //    catch
        //    {
        //        return 2;
        //    }
        //}
        ///<summary>
        ///保存从转换服务器到发送服务器同步的状态信息
        ///</summary>
        /// <param name="model">Fax.Model.Fax_Send_TranFile_NodeInf 类型节点</param>
        /// <returns></returns>
        public int Fax_Sync_Save_Sts_V1(Fax_Send_SyncData_NodeInf model, int flag, int tableindex)
        {
            int rowsAffected = 0;
            SqlParameter[] parameters = {
                    new SqlParameter("@BatchNo", SqlDbType.VarChar,20),
                    new SqlParameter("@SysID", SqlDbType.Int,4),
					new SqlParameter("@SendType", SqlDbType.Int,4),
					new SqlParameter("@SeqNo", SqlDbType.Int,4),
					new SqlParameter("@SendServerName", SqlDbType.VarChar,20),

                    new SqlParameter("@RetryTimes", SqlDbType.Int,4),
					new SqlParameter("@Sts", SqlDbType.Int,4),
                    new SqlParameter("@Flag", SqlDbType.Int,4),
                    new SqlParameter("@FlowCode", SqlDbType.VarChar),
                    new SqlParameter("@TableIndex", SqlDbType.Int,4),
					new SqlParameter("@Result", SqlDbType.Int,4)};
            parameters[0].Value = model.BatchNo;
            parameters[1].Value = model.SysID;
            parameters[2].Value = model.SendType;
            parameters[3].Value = model.SeqNo;
            parameters[4].Value = model.SendServerName;

            parameters[5].Value = model.RetryTimes;            
            parameters[6].Value = model.Sts;
            parameters[7].Value = flag;
            parameters[8].Value = model.FlowCode;
            parameters[9].Value = tableindex;
            parameters[10].Direction = ParameterDirection.Output;
            try
            {
                SqlHelper.RunProcedure(SqlHelper.ConnectionStringytFax_DB, "UP_Fax_Sync_Save_Sts_V1", parameters, out rowsAffected);
                return (int)parameters[10].Value;
            }
            catch
            {
                return 2;
            }
        }
        ///<summary>
        ///保存从转换服务器到发送服务器同步的状态信息（内部发）
        ///</summary>
        /// <param name="model">Fax.Model.Fax_Send_TranFile_NodeInf 类型节点</param>
        /// <returns></returns>
        public int Fax_Sync_Save_Sts_V2(Fax_Send_SyncData_NodeInf model)
        {
            int rowsAffected = 0;
            SqlParameter[] parameters = {
                    new SqlParameter("@BatchNo", SqlDbType.VarChar,20),
                    new SqlParameter("@SysID", SqlDbType.Int,4),
					new SqlParameter("@SendType", SqlDbType.Int,4),
					new SqlParameter("@SeqNo", SqlDbType.Int,4),
					new SqlParameter("@SendServerName", SqlDbType.VarChar,20),

                    new SqlParameter("@FaxPages", SqlDbType.Int,4),
					new SqlParameter("@Result", SqlDbType.Int,4)};
            parameters[0].Value = model.BatchNo;
            parameters[1].Value = model.SysID;
            parameters[2].Value = model.SendType;
            parameters[3].Value = model.SeqNo;
            parameters[4].Value = model.SendServerName;

            parameters[5].Value = model.FaxPages;

            parameters[6].Direction = ParameterDirection.Output;
            try
            {
                SqlHelper.RunProcedure(SqlHelper.ConnectionStringytFax_DB, "UP_Fax_Sync_Save_Sts_V2", parameters, out rowsAffected);
                return (int)parameters[6].Value;
            }
            catch
            {
                return 4;
            }
        }

        ///<summary>
        ///保存从发送服务器得到的状态信息
        ///</summary>
        /// <param name="model"></param>
        /// <returns>0 成功；1 修改 Fax_Send_Bill失败；2 修改 Fax_Send_FlowLogs失败；3 程序异常</returns>
        public int Fax_Sync_Save_Sts_V3(Fax_Send_ReturnStatsLogInf model)
        {
            int rowsAffected = 0;
            SqlParameter[] parameters = {
                new SqlParameter("@IAppCode", SqlDbType.VarChar),
                new SqlParameter("@FlowCode", SqlDbType.VarChar),
                new SqlParameter("@SeqNo", SqlDbType.Int,4),
                new SqlParameter("@SendType", SqlDbType.Int,4),
                new SqlParameter("@BatchNo", SqlDbType.VarChar,20),

                new SqlParameter("@SysID", SqlDbType.Int,4),    
                new SqlParameter("@SendServerName", SqlDbType.VarChar,20),
                new SqlParameter("@SentPages", SqlDbType.Int,4),
                new SqlParameter("@SendEndTime", SqlDbType.VarChar),

                new SqlParameter("@Seconds", SqlDbType.Int,4),
                new SqlParameter("@DonatedAmount", SqlDbType.Int,4),                
                new SqlParameter("@OriAmount", SqlDbType.Int,4),
                new SqlParameter("@Percents", SqlDbType.Int,4),                 
                new SqlParameter("@Sts", SqlDbType.Int,4),

                new SqlParameter("@FailedReason", SqlDbType.Int,4),
                new SqlParameter("@Result", SqlDbType.Int,4)};
            parameters[0].Value = model.IAppCode;
            parameters[1].Value = model.FlowCode;
            parameters[2].Value = model.SeqNo;
            parameters[3].Value = model.SendType;
            parameters[4].Value = model.BatchNo;

            parameters[5].Value = model.SysID;   
            parameters[6].Value = model.SendServerName;
            parameters[7].Value = model.SentPages;
            parameters[8].Value = model.SendEndTime;

            parameters[9].Value = model.Seconds;            
            parameters[10].Value = model.DonatedAmount;
            parameters[11].Value = model.OriAmount;
            parameters[12].Value = model.Percents;
            parameters[13].Value = model.Sts;

            parameters[14].Value = model.FailedReason;
            parameters[15].Direction = ParameterDirection.Output;
            try
            {
                SqlHelper.RunProcedure(SqlHelper.ConnectionStringytFax_DB, "UP_Fax_Sync_Save_Sts_V3", parameters, out rowsAffected);
                return (int)parameters[15].Value;
            }
            catch
            {
                return 3;
            }
        }
        ///<summary>
        ///更新发送服务器同步的状态结果信息
        ///</summary>
        /// <param name="model"></param>
        /// <returns>0 成功；1 修改 Fax_Send_Bill失败；2 修改 Fax_Send_FlowLogs失败；3 程序异常</returns>
        //public int Fax_Sync_Save_Sts_V4(string _batchno, int _sysid, int _sendtype, int _maxid, int _result)
        //{
        //    int rowsAffected = 0;
        //    SqlParameter[] parameters = {
        //        new SqlParameter("@SendType", SqlDbType.Int,4),
        //        new SqlParameter("@BatchNo", SqlDbType.VarChar,20),

        //        new SqlParameter("@SysID", SqlDbType.Int,4),    
        //        new SqlParameter("@MaxID", SqlDbType.Int,4),
        //        new SqlParameter("@Sts", SqlDbType.Int,4),
        //        new SqlParameter("@Result", SqlDbType.Int,4)};

        //    parameters[0].Value = _sendtype;
        //    parameters[1].Value = _batchno;

        //    parameters[2].Value = _sysid;
        //    parameters[3].Value = _maxid;
        //    parameters[4].Value = _result;
        //    parameters[5].Direction = ParameterDirection.Output;
        //    try
        //    {
        //        SqlHelper.RunProcedure(SqlHelper.ConnectionStringytSend_DB, "UP_Fax_Sync_Save_Sts_V4", parameters, out rowsAffected);
        //        return (int)parameters[5].Value;
        //    }
        //    catch
        //    {
        //        return 3;
        //    }
        //}
        #endregion  成员方法
        #region DoInnerSend
        ///<summary>
        ///添加接收传真信息
        ///</summary>
        /// <param name="model"></param>
        /// <returns>0 成功；1 失败；2 程序异常</returns>
        public int Fax_Sync_DoInnerSend(Fax_Recv_BillInf model)
        {
            int rowsAffected = 0;
            SqlParameter[] parameters = {
                new SqlParameter("@IAppCode", SqlDbType.VarChar),
                new SqlParameter("@CallerNum", SqlDbType.VarChar),
                new SqlParameter("@FaxNum", SqlDbType.VarChar),
                new SqlParameter("@FaxFilePath", SqlDbType.VarChar),                
                new SqlParameter("@FaxFile", SqlDbType.VarChar),

                new SqlParameter("@ReceivePages", SqlDbType.Int,4),
                new SqlParameter("@ServerName", SqlDbType.VarChar),
                new SqlParameter("@SrcServerName", SqlDbType.VarChar),
                new SqlParameter("@FileSize", SqlDbType.Int,4),
                new SqlParameter("@HoldTime", SqlDbType.Int,4),

                new SqlParameter("@Result", SqlDbType.Int,4)};
            parameters[0].Value = model.IAppCode;
            //parameters[1].Value = model.SeqNo;
            parameters[1].Value = model.CallerNum;
            parameters[2].Value = model.FaxNum;
            parameters[3].Value = model.FaxFilePath;
            parameters[4].Value = model.FaxFile;

            parameters[5].Value = model.ReceivePages;
            parameters[6].Value = model.ServerName;
            parameters[7].Value = model.ObjServerName;
            parameters[8].Value = model.RFileSize;
            parameters[9].Value = model.HoldTime;
            parameters[10].Direction = ParameterDirection.Output;
            try
            {
                SqlHelper.RunProcedure(SqlHelper.ConnectionStringytFax_DB, "UP_Fax_Recv_Bill_ADD", parameters, out rowsAffected);
                return (int)parameters[10].Value;
            }
            catch
            {
                return 2;
            }
        }
        public DataSet Fax_Sync_DoInnerSendFileCopy(string ServerIP, int SendType, int Rows)
        {
            DataSet ds = null;
            SqlParameter[] parameters = 
			{
                new SqlParameter("@TranServerIP", SqlDbType.VarChar),
                new SqlParameter("@SendType", SqlDbType.VarChar),
                new SqlParameter("@Rows", SqlDbType.VarChar)
			};
            parameters[0].Value = ServerIP;
            parameters[1].Value = SendType;
            parameters[2].Value = Rows;
            try
            {
                ds = MainDAC.ExecuteDataset(SEND_SERVER, CommandType.StoredProcedure, "UP_Fax_Sync_DoInnerSendFileCopy", parameters);
                if (ds.Tables[0].Rows.Count == 0) ds = null;
                return ds;
            }
            catch
            {
                return null;
            }
            finally
            {
                parameters = null;
            }
        }
        public int Fax_Sync_DoInnerSendFileCopy_SavaSts(int SendType,string BatchNo,int SeqNo,int Flag)
        {
            int rowsAffected = 0;
            SqlParameter[] parameters = {
                new SqlParameter("@SendType", SqlDbType.Int,4),
                new SqlParameter("@BatchNo", SqlDbType.VarChar),
                new SqlParameter("@SeqNo", SqlDbType.Int,4),
                new SqlParameter("@Flag", SqlDbType.Int,4),
                new SqlParameter("@Result", SqlDbType.Int,4)};

            parameters[0].Value = SendType;
            parameters[1].Value = BatchNo;
            parameters[2].Value = SeqNo;
            parameters[3].Value = Flag;
            parameters[4].Direction = ParameterDirection.Output;
            try
            {
                MainDAC.RunProcedure(SEND_SERVER, "UP_Fax_Sync_DoInnerSendFileCopy_SavaSts", parameters, out rowsAffected);
                return (int)parameters[4].Value;
            }
            catch
            {
                return 2;
            }
        }
        #endregion
        #region Recv
        public DataSet Fax_Recv_GetListForSync(int Rows)
        {
            DataSet ds = null;
            SqlParameter[] parameters = 
			{
                new SqlParameter("@Rows", SqlDbType.VarChar)
			};
            parameters[0].Value = Rows;
            try
            {
                ds = MainDAC.ExecuteDataset(RECV_SERVER, CommandType.StoredProcedure, "UP_Fax_Recv_Sync_GetList", parameters);
                if (ds.Tables[0].Rows.Count == 0) ds = null;
                return ds;
            }
            catch
            {
                return null;
            }
            finally
            {
                parameters = null;
            }
        }
        ///添加接收传真信息
        ///</summary>
        /// <param name="model"></param>
        /// <returns>0 成功；1 失败；2 程序异常</returns>
        public int DoSyncRecvData(Fax_Recv_BillInf model)
        {
            int rowsAffected = 0;
            SqlParameter[] parameters = {
                new SqlParameter("@IAppCode", SqlDbType.VarChar),
                new SqlParameter("@CallerNum", SqlDbType.VarChar),
                new SqlParameter("@FaxNum", SqlDbType.VarChar),
                new SqlParameter("@FaxFilePath", SqlDbType.VarChar),                
                new SqlParameter("@FaxFile", SqlDbType.VarChar),

                new SqlParameter("@ReceivePages", SqlDbType.Int,4),
                new SqlParameter("@ServerName", SqlDbType.VarChar),
                new SqlParameter("@SrcServerName", SqlDbType.VarChar),
                new SqlParameter("@FileSize", SqlDbType.Int,4),
                new SqlParameter("@HoldTime", SqlDbType.Int,4),

                new SqlParameter("@Result", SqlDbType.Int,4)};
            parameters[0].Value = model.IAppCode;
            //parameters[1].Value = model.SeqNo;
            parameters[1].Value = model.CallerNum;
            parameters[2].Value = model.FaxNum;
            parameters[3].Value = model.FaxFilePath;
            parameters[4].Value = model.FaxFile;

            parameters[5].Value = model.ReceivePages;
            parameters[6].Value = model.ServerName;
            parameters[7].Value = model.ObjServerName;
            parameters[8].Value = model.RFileSize;
            parameters[9].Value = model.HoldTime;
            parameters[10].Direction = ParameterDirection.Output;
            try
            {
                MainDAC.RunProcedure(SEND_SERVER, "UP_Fax_Recv_Bill_ADD", parameters, out rowsAffected);
                return (int)parameters[10].Value;
            }
            catch
            {
                return 2;
            }
        }
        public int Fax_Sync_Recv_Save_Sts_V1(int _sysid,int _result)
        {
            int rowsAffected = 0;
            SqlParameter[] parameters = {
                new SqlParameter("@SysID", SqlDbType.Int,4),    
                new SqlParameter("@Sts", SqlDbType.Int,4)};

            parameters[0].Value = _sysid;
            parameters[1].Value = _result;
            try
            {
                MainDAC.RunProcedure(RECV_SERVER, "UP_Fax_Sync_Recv_Save_Sts_V1", parameters, out rowsAffected);
                return 0;
            }
            catch
            {
                return 1;
            }
        }
        #endregion
    }
}