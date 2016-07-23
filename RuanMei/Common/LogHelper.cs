using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class LogHelper
    {
        private static string LogPath;
        private static string AppPath;

        private static LogHelper log;

        private LogHelper()
        {
            LogPath = ConfigurationManager.AppSettings["LogPath"] ?? "Log";
            AppPath = System.AppDomain.CurrentDomain.BaseDirectory;
        }

        private static Object lock_obj = new Object();

        public static LogHelper Create()
        {
            if (log == null)
            {
                lock (lock_obj)
                {
                    if (log == null)
                    {
                        log = new LogHelper();
                    }
                }
            }
            return log;
        }

        /// <summary>
        /// 写日志
        /// </summary>
        /// <param name="Message"></param>
        /// <param name="objs"></param>
        /// <returns></returns>
        public Boolean WriteLog(String Message,params String[] objs)
        {
            return WriteLog(String.Format(Message, objs));
        }

        /// <summary>
        /// 写日志
        /// </summary>
        /// <param name="Message"></param>
        /// <returns></returns>
        public Boolean WriteLog(String Message)
        {
            var FullPath = Path.Combine(AppPath, LogPath);
            string FullFilePath = Path.Combine(FullPath, DateTime.Now.Hour + ".log");
            lock (lock_obj)
            {
                if (!Directory.Exists(FullPath))
                {
                    Directory.CreateDirectory(FullPath);
                }
                File.AppendAllText(FullFilePath, DateTime.Now.ToString("HH:mm:ss") + "：" + Message + System.Environment.NewLine);
                //Console.WriteLine(Message);
            }
            return true;
        }
    }
}
