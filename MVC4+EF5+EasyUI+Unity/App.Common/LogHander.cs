#region CopyRight
/**************************************************************
   Copyright (c) 2015 shipengfei. All rights reserved.
   CLR版本        :    4.0.30319.34209
   命名空间名称   :    App.Common
   文件名         :    LogHander
   创建时间       :    2015-12-13 16:00:24
   用户所在的域   :    SHIPENGFEI
   登录用户名     :    Administrator
   文件描述       :    
   版本           :    1.0.0
   历史           :    
   最后更新人     :   
   最后更新时间   :   
 **************************************************************/
#endregion CopyRight

using log4net;
using log4net.Config;
using System;
using System.IO;

namespace App.Common
{
    public class LogHander
    {
        public static readonly log4net.ILog LogInfo = LogManager.GetLogger("LogInfo");
        public static readonly log4net.ILog LogError = LogManager.GetLogger("LogError");

        /// <summary>
        /// 自动配置log4net
        /// </summary>
        public static void SetConfig()
        {
            XmlConfigurator.Configure();
        }

        /// <summary>
        /// 使用指定配置文件配置log4net
        /// </summary>
        /// <param name="configFile">指定配置文件</param>
        public static void SetConfig(FileInfo configFile)
        {
            XmlConfigurator.Configure(configFile);
        }

        /// <summary>
        /// 输出日志
        /// </summary>
        /// <param name="info"></param>
        public static void WriteInfoLog(string info)
        {
            if (LogInfo.IsInfoEnabled)
            {
                LogInfo.Info(info);
            }
        }

        /// <summary>
        /// 输出日志
        /// </summary>
        /// <param name="info"></param>
        /// <param name="ex"></param>
        public static void WriteInfoLog(string info, Exception ex)
        {
            if (LogInfo.IsInfoEnabled)
            {
                LogInfo.Info(info, ex);
            }
        }

        public static void WriteErrorLog(String info)
        {
            if (LogError.IsErrorEnabled)
            {
                LogError.Error(info);
            }
        }

        public static void WriteErrorLog(String info, Exception ex)
        {
            if (LogError.IsErrorEnabled)
            {
                LogError.Error(info, ex);
            }
        }
    }
}

