#region CopyRight
/**************************************************************
   Copyright (c) 2015 StarPeng. All rights reserved.
   CLR版本        :    4.0.30319.34209
   命名空间名称   :    $rootnamespace$
   文件名         :    FilterConfig
   创建时间       :    2015-11-23 17:08:48
   用户所在的域   :    SHIPENGFEI
   登录用户名     :    Administrator
   文件描述       :    
   版本           :    1.0.0
   历史           :    
   最后更新人     :   
   最后更新时间   :   
 **************************************************************/
#endregion CopyRight

using System.Web;
using System.Web.Mvc;

namespace MVC4_EF5_EasyUI_Unity
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
