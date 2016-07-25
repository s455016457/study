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
    public class CustomerCache :CacheBase
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

        public static ICache Create()
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
        
        public override T Get<T>(string Key)
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

        public override Object Get(string Key)
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

        public override Boolean Contains(String Key)
        {
            return DATA.ContainsKey(Key);
        }

        public override void Add(string Key, object Value, int CacheTime = 3000)
        {
            lock (lock_obj)
            {
                this.Remove(Key);
                DATA.Add(Key, new KeyValuePair<object, DateTime>(Value, DateTime.Now.AddMinutes(CacheTime)));
            }
        }

       
        public override void Add<T>(string Key, T Value, int CacheTime = 3000)
        {
            lock (lock_obj)
            {
                this.Remove(Key);
                DATA.Add(Key, new KeyValuePair<object, DateTime>(Value, DateTime.Now.AddMinutes(CacheTime)));
            }
        }

        public override void Remove(string Key)
        {
            if (this.Contains(Key))
                DATA.Remove(Key);
        }

        public override void RemoveAll()
        {
            DATA = new Dictionary<string, KeyValuePair<object, DateTime>>();
        }

        public override long Count()
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
