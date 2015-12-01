#region CopyRight
/**************************************************************
   Copyright (c) 2015 shipengfei. All rights reserved.
   CLR版本        :    4.0.30319.34209
   命名空间名称   :    App.Common
   文件名         :    Operation
   创建时间       :    2015-11-30 14:46:27
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
using System.Linq.Expressions;
using System.Text;

namespace App.Common
{
    /// <summary>
    /// 运算类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public static class Operation<T>
    {
        private static Func<T, T, T> func_Add
        {
            get
            {
                if (func_Add == null)
                {
                    if (typeof(T) == typeof(String))
                    {
                        var strAdd = new Func<String, String, String>((a, b) => a + b);
                        func_Add = (Func<T, T, T>)(Object)strAdd;
                    }
                    else
                    {
                        var a = Expression.Parameter(typeof(T), "a");
                        var b = Expression.Parameter(typeof(T), "b");
                        var body = Expression.Add(a, b);
                        var lambda = Expression.Lambda<Func<T, T, T>>(body, a, b);
                        func_Add = lambda.Compile();
                    }
                }
                return func_Add;
            }
            set
            {

            }
        }

        public static T Add(T x, T y)
        {
            return func_Add(x, y);
        }
        
    }
}

