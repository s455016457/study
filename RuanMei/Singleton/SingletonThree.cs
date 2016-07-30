using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class SingletonThree
    {
        private SingletonThree()
        {
            Console.WriteLine("{0}，构造函数被调用一次", this.GetType().Name);
        }

        /// <summary>
        /// 任何一个类，最多只有一个无参数的静态构造函数
        /// 由CLR保证，在第一次使用类之前执行，而且仅执行一次
        /// </summary>
        static SingletonThree()
        {
            _singletonThree = new SingletonThree();
        }

        private static SingletonThree _singletonThree = null;

        public static SingletonThree CreateInstance()
        {
            return _singletonThree;
        }

        int i = 0;
        public void Show()
        {
            //多线程这里的打印是无序的
            int k = i++;
            Console.WriteLine("这里是SingletonThree.Show{0}", i);
        }
    }
}
