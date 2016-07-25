using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// 单利模式，sealed不能被继承，防止子类多次创建
    /// </summary>
    public sealed class SingletonOne
    {
        private SingletonOne()
        {
            Console.WriteLine("SingletonOne，构造函数被调用一次");
        }
        private static SingletonOne _Singleton = null;

        private static object Singleton_lock = new object();
        /// <summary>
        /// 创建对象
        /// </summary>
        /// <returns></returns>
        public static SingletonOne CreateInstance()
        {
            //为空创建对象
            if (_Singleton == null)
            {
                //多线程，加锁，同一时间只有一个进程进入锁，这里会有多个进程在等待锁
                lock (Singleton_lock)
                {
                    //进程进锁后再次判断对象是否为空
                    if (_Singleton == null)
                    {
                        _Singleton = new SingletonOne();
                    }
                }
            }
            return _Singleton;
        }

        public int i = 0;
        public void Show()
        {
            //多线程这里的打印是无序的
            int k = i++;
            Console.WriteLine("这里是SingletonOne.Show{0}", i);
        }
    }
}
