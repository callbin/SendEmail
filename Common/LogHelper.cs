using System;
using System.Collections.Generic;
using System.Text;

namespace Fax.Common
{
    public class LogHelper
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void Debug(string debug)
        {
            log.Debug(debug);
        }

        public static void Error(string error)
        {
            log.Error(error);
        }

        public static void Info(string info)
        {
            log.Info(info);
        }
    }
}
