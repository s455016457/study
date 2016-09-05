using Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.TestFiles
{
    public class TestSingleton : TestBase
    {
        private IList<Task> totalTaskList = new List<Task>();
        public override void Test(Action<Task[]> callBack)
        {
            TestSingletonOne();
            Console.WriteLine("");
            TestSingletonTwo();
            Console.WriteLine("");
            TestSingletonThree();
            Console.WriteLine("");

            Task.Factory.ContinueWhenAll(totalTaskList.ToArray(), callBack);
        }

        private void TestSingletonOne()
        {
            Console.WriteLine("********************Begin线程锁+双重判断实现单例模式**********************");
            var singletonOne = SingletonOne.CreateInstance();
            var taskList = new List<Task>();
            for (int i = 0; i < 10; i++)
            {
                var task = Task.Factory.StartNew(() => singletonOne.Show());
                taskList.Add(task);
                totalTaskList.Add(task);
            }

            //Task.Factory.ContinueWhenAll(taskList.ToArray(), p =>
            //{
            //    Console.WriteLine("**********************END线程锁+双重判断实现单例模式************************");
            //});
        }

        private void TestSingletonTwo()
        {
            Console.WriteLine("************************Begin静态属性实现单例模式**************************");
            var singletonTwo = SingletonTwo.CreateInstance();
            var taskList = new List<Task>();
            for (int i = 0; i < 10; i++)
            {
                var task = Task.Factory.StartNew(() => singletonTwo.Show());
                taskList.Add(task);
                totalTaskList.Add(task);
            }
            //Task.Factory.ContinueWhenAll(taskList.ToArray(), p =>
            //{
            //    Console.WriteLine("************************END静态属性实现单例模式**************************");
            //});
        }

        private void TestSingletonThree()
        {
            Console.WriteLine("************************Begin静态构造函数实现单例模式**************************");
            var singletonThree = SingletonThree.CreateInstance();
            var taskList = new List<Task>();
            for (int i = 0; i < 10; i++)
            {
                var task = Task.Factory.StartNew(() => singletonThree.Show());
                taskList.Add(task);
                totalTaskList.Add(task);
            }
            //Task.Factory.ContinueWhenAll(taskList.ToArray(), p =>
            //{
            //    Console.WriteLine("************************END静态构造函数实现单例模式**************************");
            //});
        }
    }
}
