#region CopyRight
/**************************************************************
   Copyright (c) 2015 shipengfei. All rights reserved.
   CLR版本        :    4.0.30319.34209
   命名空间名称   :    App.Common
   文件名         :    ExceptionHander
   创建时间       :    2015-12-13 15:34:40
   用户所在的域   :    SHIPENGFEI
   登录用户名     :    Administrator
   文件描述       :    
   版本           :    1.0.0
   历史           :    
   最后更新人     :   
   最后更新时间   :   
 **************************************************************/
#endregion CopyRight

using System;

namespace App.Common
{
    public static class ExceptionHander
    {

        public static void WriteException(Exception ex)
        {
            WriteExceptionToLg(ex);
        }

        public static void WriteExceptionToLg(Exception ex)
        {
            WriteExceptionToLg(ex.Message.ToString(), ex);
        }

        public static void WriteExceptionToLg(String info,Exception ex)
        {
            LogHander.WriteErrorLog(info, ex);
        }
    }
}

