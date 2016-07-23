#region CopyRight
/**************************************************************
   Copyright (c) 2015 StarPeng. All rights reserved.
   CLR版本        :    4.0.30319.34209
   命名空间名称   :    $rootnamespace$
   文件名         :    Class1
   创建时间       :    2015-11-25 14:28:16
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
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace App.Extensions
{
    public static class QueryableExtensions
    {
        /// <summary>
        /// 排序
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="queryable"></param>
        /// <param name="propertyName">排序字段</param>
        /// <returns></returns>
        public static IQueryable<T> OrderBy<T>(this IQueryable<T> queryable, string propertyName)
        {
            return QueryableHelper<T>.OrderBy(queryable, propertyName, false);
        }
        /// <summary>
        /// 排序
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="queryable"></param>
        /// <param name="propertyName">排序字段</param>
        /// <param name="desc">是否倒序</param>
        /// <returns></returns>
        public static IQueryable<T> OrderBy<T>(this IQueryable<T> queryable, string propertyName, bool desc)
        {
            return QueryableHelper<T>.OrderBy(queryable, propertyName, desc);
        }
        static class QueryableHelper<T>
        {
            //private static ConcurrentDictionary<string, LambdaExpression> cache = new ConcurrentDictionary<string, LambdaExpression>();
            public static IQueryable<T> OrderBy(IQueryable<T> queryable, string propertyName, bool desc)
            {
                dynamic keySelector = GetLambdaExpression(propertyName);
                return desc ? Queryable.OrderByDescending(queryable, keySelector) : Queryable.OrderBy(queryable, keySelector);
            }
            /// <summary>
            /// 生成Lambda表达式
            /// </summary>
            /// <param name="propertyName"></param>
            /// <returns></returns>
            private static LambdaExpression GetLambdaExpression(string propertyName)
            {
                //if (cache.ContainsKey(propertyName)) 
                //    return cache[propertyName];

                var param = Expression.Parameter(typeof(T));
                var body = Expression.Property(param, propertyName);
                var keySelector = Expression.Lambda(body, param);
                //cache[propertyName] = keySelector;
                return keySelector;
            }
        }
    }
}
