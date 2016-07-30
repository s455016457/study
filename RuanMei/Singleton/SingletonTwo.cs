using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class SingletonTwo
    {
        private SingletonTwo()
        {
            Console.WriteLine("{0}，构造函数被调用一次", this.GetType().Name);
        }

        private static SingletonTwo _singletonTwo = new SingletonTwo();
        /// <summary>
        /// 静态对象
        /// </summary>
        /// <returns></returns>
        public static SingletonTwo CreateInstance()
        {
            return _singletonTwo;
        }

        int i = 0;
        public void Show()
        {
            //多线程这里的打印是无序的
            int k = i++;
            Console.WriteLine("这里是SingletonTwo.Show{0}", i);
        }
    }
}
