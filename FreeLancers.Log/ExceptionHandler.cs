using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeLancers.Log
{
    public static class ExceptionHandler
    {
        static ExceptionHandler()
        {
            log4net.Config.XmlConfigurator.Configure();
        }

        #region LogThreshold enum

        public enum LogThreshold
        {
            INFO = 0,
            WARN = 1,
            ERROR = 2,
            FATAL = 3,
            DEBUG = 4
        }

        #endregion

        /// <summary>
        /// Log using the Log 4
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exceptionData"></param>
        /// <param name="methodName"></param>
        /// <param name="threshold"></param>
        public static void LogException(Exception ex, string methodName, LogThreshold threshold)
        {
            ILog Logger = LogManager.GetLogger(methodName);
            try
            {             
                switch (threshold)
                {
                    case LogThreshold.INFO:
                        {
                            Logger.Info(ex.Message, ex);
                            break;
                        }
                    case LogThreshold.WARN:
                        {
                            Logger.Warn(ex.Message, ex);
                            break;
                        }
                    case LogThreshold.ERROR:
                        {
                            Logger.Error(ex.Message, ex);
                            break;
                        }
                    case LogThreshold.FATAL:
                        {
                            Logger.Fatal(ex.Message, ex);
                            break;
                        }
                    case LogThreshold.DEBUG:
                        {
                            Logger.Debug(ex.Message, ex);
                            break;
                        }
                    default:
                        {
                            Logger.Info(ex.Message, ex);
                            break;
                        }
                }
            }
            catch (Exception exc)
            {
                try
                {
                    Logger.Error("Error while logging using log4Net parameters:Message=" + ex.Message + "  ,MethodName=" +
                        methodName, exc);
                }
                catch
                {
                }
            }
        }
    }
}
