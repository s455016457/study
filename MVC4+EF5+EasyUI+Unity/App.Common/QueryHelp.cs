#region CopyRight
/**************************************************************
   Copyright (c) 2015 StarPeng. All rights reserved.
   CLR版本        :    4.0.30319.34209
   命名空间名称   :    App.Common
   文件名         :    QueryHelp
   创建时间       :    2015-11-25 11:31:14
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
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Common
{
    public class QueryHelp
    {

    }

    public class QueryParameter
    {

    } 

    /// <summary>
    /// 比较标记符
    /// </summary>
    public enum CompareSymbol : int
    {
        /// <summary>
        /// 等于比较符
        /// </summary>
        Equal = 0,
        /// <summary>
        /// 大于比较符
        /// </summary>
        GreaterThan = 1,
        /// <summary>
        /// 大于或等于
        /// </summary>
        GreaterThanOrEqual = 2,
        /// <summary>
        /// 小于
        /// </summary>
        LessThan = 3,
        /// <summary>
        /// 小于或等于
        /// </summary>
        LessThanOrEqual = 4,
        /// <summary>
        /// 以XX开始
        /// </summary>
        StartWith = 5,
        /// <summary>
        /// 以XX结束
        /// </summary>
        EndWith = 6,
        /// <summary>
        /// 包含
        /// </summary>
        Contain = 7,
    }

    /// <summary>
    /// 连接符
    /// </summary>
    public enum ConnectSysmbol : int
    {
        And = 1,
        Or = 0,
    }
}
