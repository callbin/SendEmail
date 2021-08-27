using System;
using System.Text;
using System.IO;
using System.Configuration;
using System.Data;

/// <summary>
/// SysFile 的摘要说明
/// </summary>
/// namespace Fax.Common
namespace Fax.Common
{
    public class FileHelper
{
    private static string dfIndex = ConfigurationManager.AppSettings["LinkDirIndex"].ToString();
    private static string rootdir = ConfigurationManager.AppSettings["RootPath"].ToString();

    /// <summary>
    /// 获取完整路径
    /// </summary>
    /// <param name="seqNo"></param>
    /// <param name="compID"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public static string GetFullPath(int seqNo, int compID, int type)
    {
        string fullPath = rootdir + GetFilePath(seqNo, compID, type);
        if (!Directory.Exists(fullPath))
        {
            Directory.CreateDirectory(fullPath);
        }
        return fullPath;
    }

    /// <summary>
    /// 获取文件路径
    /// </summary>
    /// <param name="seqNo">用户编号</param>
    /// <param name="compID">企业编号</param>
    /// <param name="type">1.彩铃目录（Ring）；2.语音提示（VMF）；3.录音（Record）；4.传真接收（Fax）；5.传真发送（Doc）；6.传真转换（Tif）；7.传真预览（Preview）</param>
    /// <returns>格式为"0\201001\01\"</returns>
    public static string GetFilePath(int seqNo, int compID, int type)
    {
        return GetFilePath(seqNo, compID, type, true);
    }

    /// <summary>
    /// 获取文件路径
    /// </summary>
    /// <param name="seqNo"></param>
    /// <param name="type">1.彩铃目录（Ring）；2.语音提示（VMF）；3.录音（Record）；4.传真接收（Fax）；5.传真发送（Doc）；6.传真转换（Tif）；7.传真预览（Preview）</param>
    /// <param name="autoCreateDir">true：创建；false：不创建</param>
    /// <returns>格式为"0\201001\01\"</returns>
    public static string GetFilePath(int seqNo, int compID, int type, bool autoCreateDir)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("\\DF").Append(dfIndex).Append("\\");
        if (compID > 0)
        {
            sb.Append(compID).Append("\\").Append(GetDirName(type)).Append("\\").Append(DateTime.Now.ToString("yyyyMM")).Append("\\").Append(DateTime.Now.ToString("dd")).Append("\\");
        }
        else
        {
            sb.Append("0\\").Append(seqNo / 2000).Append("\\").Append(seqNo).Append("\\").Append(GetDirName(type)).Append("\\").Append(DateTime.Now.ToString("yyyyMM")).Append("\\");
        }

        string path = sb.ToString();

        //if (autoCreateDir && !Directory.Exists(path))
        //{
        //    Directory.CreateDirectory(path);
        //}

        return path;
    }

    private static string GetDirName(int type)
    {
        switch (type)
        {
            case 1:
                return "Ring";
            case 2:
                return "VMF";
            case 3:
                return "Record";
            case 4:
                return "Fax";
            case 5:
                return "Doc";
            case 6:
                return "Tif";
            case 7:
                return "Preview";
            default:
                return "Other";
        }
    }

    public static void SaveFile(string filePath, string fileContent)
    {
        StreamWriter writer = new StreamWriter(filePath,false, Encoding.GetEncoding("gb2312"));
        writer.Write(fileContent);
        writer.Flush();
    }
 }
}