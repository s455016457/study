using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheDome
{
    public interface ICache
    {
        Boolean Contains(String Key);

        T Get<T>(String Key);
        Object Get(String Key);

        void Add(String Key, Object Value, int CacheTime = 3000);

        void Add<T>(String Key, T value, int CacheTime = 3000);

        void Remove(String Key);

        void RemoveAll();

        long Count();
    }
}
