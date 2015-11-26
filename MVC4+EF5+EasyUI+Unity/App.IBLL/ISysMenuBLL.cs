#region CopyRight
/**************************************************************
   Copyright (c) 2015 shipengfei. All rights reserved.
   CLR版本        :    4.0.30319.34209
   命名空间名称   :    App.IBLL
   文件名         :    ISysMenusBLL
   创建时间       :    2015-11-26 17:44:06
   用户所在的域   :    SHIPENGFEI
   登录用户名     :    Administrator
   文件描述       :    
   版本           :    1.0.0
   历史           :    
   最后更新人     :   
   最后更新时间   :   
 **************************************************************/
#endregion CopyRight

using App.Common;
using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.IBLL
{
    public interface ISysMenuBLL
    {
        List<SysFunction> GetSysFounctionList(string queryStr, ref GridPager pager);
    }
}

