#region CopyRight
/**************************************************************
   Copyright (c) 2016 ShiPengFei. All rights reserved.
   CLR版本        :    4.0.30319.42000
   命名空间名称   :    CacheDome
   文件名         :    CacheBase
   创建时间       :    2016/7/24 12:28:41
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheDome
{
    public abstract class CacheBase:ICache
    {
        public static CacheBase Create;

        public abstract bool Contains(string Key);

        public abstract T Get<T>(string Key);

        public abstract object Get(string Key);

        public abstract void Add(string Key, object Value, int CacheTime = 3000);

        public abstract void Add<T>(string Key, T value, int CacheTime = 3000);

        public abstract void Remove(string Key);

        public abstract void RemoveAll();

        public abstract long Count();
    }
}
