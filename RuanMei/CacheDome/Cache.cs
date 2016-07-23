using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace CacheDome
{
    public class Cache:ICache
    {
        private static MemoryCache cache;
        static Cache()
        {
            cache = MemoryCache.Default;
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
            var obj = this.Get(Key);
            var typeConverter = System.ComponentModel.TypeDescriptor.GetConverter(obj.GetType());
            if (typeConverter.CanConvertTo(typeof(T)))
                return (T)typeConverter.ConvertTo(obj, typeof(T));
            return default(T);
        }

        public object Get(String Key)
        {
            return cache.Get(Key);
        }

        public void Add(string Key, object Value, int CacheTime = 3000)
        {
            var policy = new CacheItemPolicy();
            var cacheItem = new CacheItem(Key, Value);
            policy.SlidingExpiration = TimeSpan.FromMinutes(CacheTime);//设置缓存过期时间
            cache.Add(cacheItem, policy);
        }

        public void Add<T>(string Key, T Value, int CacheTime = 3000)
        {
            var policy = new CacheItemPolicy();
            var cacheItem = new CacheItem(Key, Value);
            policy.SlidingExpiration = TimeSpan.FromMinutes(CacheTime);//设置缓存过期时间
            cache.Add(cacheItem, policy);
        }

        public void Remove(string Key)
        {
            if (this.Contains(Key))
                cache.Remove(Key);
        }

        public void RemoveAll()
        {
            cache = MemoryCache.Default;
        }

        public long Count()
        {
            return cache.GetCount();
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
