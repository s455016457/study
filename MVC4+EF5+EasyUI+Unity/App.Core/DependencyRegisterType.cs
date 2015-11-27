#region CopyRight
/**************************************************************
   Copyright (c) 2015 StarPeng. All rights reserved.
   CLR版本        :    4.0.30319.34209
   命名空间名称   :    App.Core
   文件名         :    DependencyRegisterType
   创建时间       :    2015-11-24 15:49:47
   用户所在的域   :    SHIPENGFEI
   登录用户名     :    Administrator
   文件描述       :    
   版本           :    1.0.0
   历史           :    
   最后更新人     :   
   最后更新时间   :   
 **************************************************************/
#endregion CopyRight

using App.BLL;
using App.DAL;
using App.IBLL;
using App.IDAL;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Core
{
    /// <summary>
    /// 依赖寄存器类型
    /// </summary>
    public class DependencyRegisterType
    {
        /// <summary>
        /// 系统注入
        /// </summary>
        /// <param name="container"></param>
        public static void Container_Sys(ref UnityContainer container)
        {
            container.RegisterType<ISysSampleBLL, SysSampleBLL>();
            container.RegisterType<ISysSampleRepository, SysSampleRepository>();

            container.RegisterType<ISysMenuRepository, SysMenuRepository>();
            container.RegisterType<ISysMenuBLL, SysMenuBLL>();
        }
    }
}
