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

using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace App.Common
{
    public class QueryHelp
    {

        public static String[] CompareSymbols = { "Equals", "GreaterThan", "GreaterThanOrEqual", "LessThan", "LessThanOrEqual", "StartsWith", "EndWith", "Contain" };

        public static Expression<Func<T, bool>> ToExpression<T>(IEnumerable<QueryParameter> enumerable)
        {
            var body = Expression.Equal(Expression.Constant(true), Expression.Constant(true));
            var p = Expression.Parameter(typeof(T), "p");
            var type = typeof(T);
            foreach (var item in enumerable)
            {
                var queryStr = item.FileValue;
                var propertyName = Expression.Property(p, item.FileName);
                var compareSymbol = GetCompareSymbol(item.CompareSymbol);

                if (item.ConnectSysmbol.Equals(ConnectSysmbol.And))
                    body = Expression.And(body, Expression.Call(propertyName, compareSymbol, null, Expression.Constant(queryStr)));
                else
                    body = Expression.OrElse(body, Expression.Call(propertyName, compareSymbol, null, Expression.Constant(queryStr)));
            }
            return Expression.Lambda<Func<T, bool>>(body, p);
        }

        public static String GetCompareSymbol(CompareSymbol param)
        {
            return CompareSymbols[(int)param];
        }
    }

    public class QueryParameter
    {
        public String FileName { get; set; }
        public String FileValue { get; set; }
        public CompareSymbol CompareSymbol { get; set; }
        public ConnectSysmbol ConnectSysmbol { get; set; }
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
        StartsWith = 5,
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
