#region CopyRight
/**************************************************************
   Copyright (c) 2016 ShiPengFei. All rights reserved.
   CLR版本        :    4.0.30319.42000
   命名空间名称   :    CacheDome
   文件名         :    CacheManager
   创建时间       :    2016/7/24 10:25:06
   用户所在的域   :    SHIPENGFEI
   登录用户名     :    admin
   文件描述       :    
   版本           :    1.0.0
   历史           :    
   最后更新人     :   
   最后更新时间   :   
 **************************************************************/
#endregion CopyRight

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CacheDome
{
    public class CacheManager
    {
        private static ICache cache;

        static CacheManager()
        {
            var cacheAssemblyRef = "CacheDome";
            var cacheClassName = ConfigurationManager.AppSettings["CacheClassName"] ?? "CacheDome.CustomerCache";

            var assembly = Assembly.Load(cacheAssemblyRef);
            var type = assembly.GetType(cacheClassName, false);
            var createMethod = type.GetMethod("Create");
            cache = (CacheBase)createMethod.Invoke(null, new object[] { });
        }
        /// <summary>
        /// 确认缓存是否存在
        /// </summary>
        /// <param name="Key"></param>
        /// <returns></returns>
        public bool Contains(string Key)
        {
            return cache.Contains(Key);
        }

        public T Get<T>(string Key)
        {
            return cache.Get<T>(Key);
        }

        public object Get(String Key)
        {
            return cache.Get(Key);
        }

        public void Add(string Key, object Value, int CacheTime = 3000)
        {
            cache.Add(Key, Value, CacheTime); ;
        }

        public void Add<T>(string Key, T Value, int CacheTime = 3000)
        {
            cache.Add<T>(Key, Value, CacheTime);
        }

        public void Remove(string Key)
        {
            if (this.Contains(Key))
                cache.Remove(Key);
        }

        public void RemoveAll()
        {
            cache.RemoveAll();
        }

        public long Count()
        {
            return cache.Count();
        }

        public Object this[String key]
        {
            get
            {
                return this.Get(key);
            }
        }
    }
}
