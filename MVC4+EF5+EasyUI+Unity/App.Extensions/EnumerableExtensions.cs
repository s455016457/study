#region CopyRight
/**************************************************************
   Copyright (c) 2015 shipengfei. All rights reserved.
   CLR版本        :    4.0.30319.34209
   命名空间名称   :    App.Extensions
   文件名         :    EnumerableExtensions
   创建时间       :    2015-11-30 14:39:40
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
using App.Common;

namespace App.Extensions
{
    public static class EnumerableExtensions
    {
        public static TResult AddResultEach<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> func)
        {
            TResult result = default(TResult);
            Boolean first = true;
            foreach (var item in source)
            {
                if (first)
                {
                    result = func.Invoke(item);
                    first = false;
                }
                else
                {
                    result = Operation<TResult>.Add(result, func.Invoke(item));
                }
            }
            return result;
        }
    }
}

