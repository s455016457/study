using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheDome
{
    /// <summary>
    /// 缓存是在内存在开辟了个空间存放了静态的字典集合
    /// </summary>
    public class CustomerCache :ICache
    {
        private static CustomerCache customerCache;
        private CustomerCache()
        {
            /***
             * 可以开启一个线程，自动删除已过去缓存
             * 
             * */
        }

        private static Object lock_obj = new object();

        public static CustomerCache Create()
        {
            if (customerCache == null)
            {
                lock (lock_obj)
                {
                    if (customerCache == null)
                    {
                        customerCache = new CustomerCache();
                    }
                }
            }
            return customerCache;
        }

        

        private static Dictionary<String, KeyValuePair<object, DateTime>> DATA = new Dictionary<string, KeyValuePair<object, DateTime>>();
        
        public T Get<T>(string Key)
        {
            if (!this.Contains(Key)) return default(T);

            KeyValuePair<object, DateTime> keyValue = DATA[Key];
            if (keyValue.Value < DateTime.Now)
            {
                this.Remove(Key);
                return default(T);
            }
            return (T)keyValue.Key;
        }

        public Object Get(string Key)
        {
            if (!this.Contains(Key)) return null;

            KeyValuePair<object, DateTime> keyValue = DATA[Key];
            if (keyValue.Value < DateTime.Now)
            {
                this.Remove(Key);
                return null;
            }
            return keyValue.Key;
        }

        public Boolean Contains(String Key)
        {
            return DATA.ContainsKey(Key);
        }

        public void Add(string Key, object Value, int CacheTime = 3000)
        {
            this.Remove(Key);
            DATA.Add(Key, new KeyValuePair<object, DateTime>(Value, DateTime.Now.AddMinutes(CacheTime)));
        }

        public void Add<T>(string Key, T Value, int CacheTime = 3000)
        {
            this.Remove(Key);
            DATA.Add(Key, new KeyValuePair<object, DateTime>(Value, DateTime.Now.AddMinutes(CacheTime)));
        }

        public void Remove(string Key)
        {
            if (this.Contains(Key))
                DATA.Remove(Key);
        }

        public void RemoveAll()
        {
            DATA = new Dictionary<string, KeyValuePair<object, DateTime>>();
        }

        public long Count()
        {
            return DATA.Count;
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
