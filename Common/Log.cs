using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Fax.Common
{
    public class Log
    {
        /// <summary>
        /// 写日志
        /// </summary>
        /// <param name="content">写入内容</param>
        public static void WriteLog(string content)
        {
            try
            {
                string filePath = Path.Combine(Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf('\\') + 1), DateTime.Now.ToString("yyyyMM") + "\\" + DateTime.Now.ToString("dd"));
                if (!Directory.Exists(filePath))
                    Directory.CreateDirectory(filePath);

                string fileName = DateTime.Now.ToString("HH-mm-ss") + ".log";
                string fullName = filePath + "\\" + fileName;
                StreamWriter sw = File.AppendText(fullName);
                sw.WriteLine(content);
                sw.Close();
            }
            catch
            {
                
            }
        }
    }
}
