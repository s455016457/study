using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Singleton;
using System.Reflection;
using Factory;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 单例模式
            var singletonOne = SingletonOne.CreateInstance();
            for (int i = 0; i < 10; i++)
            {
                Task.Factory.StartNew(() => singletonOne.Show());
            }

            var singletonTwo = SingletonTwo.CreateInstance();
            for (int i = 0; i < 10; i++)
            {
                Task.Factory.StartNew(() => singletonTwo.Show());
            }

            var singletonThree = SingletonThree.CreateInstance();
            for (int i = 0; i < 10; i++)
            {
                Task.Factory.StartNew(() => singletonThree.Show());
            }

            //Console.WriteLine("**************");
            //List<Task> listTask = new List<Task>();
            //for (int i = 0; i < 10000; i++)
            //{
            //    listTask.Add(Task.Factory.StartNew(() => singletonOne.Show()));
            //}
            //Task.WaitAll(listTask.ToArray());
            //Console.WriteLine(singletonOne.i);//singletonOne.Show方法线程不安全，打印出来的不一定是1008
            #endregion

            Assembly assmebly = Assembly.Load("Singleton");
            var modules = assmebly.GetModules();
            Console.WriteLine(modules);
            Console.WriteLine("GetModules():");
            foreach (var module in modules)
            {
                Console.WriteLine(module);
            }
            Console.WriteLine("GetTypes():");
            foreach (var type in assmebly.GetTypes())
            {
                Console.WriteLine(type);
            }

            Console.WriteLine("创建程序集中的对象：");
            foreach (var obj in ObjectFactory.Createdobject("Factory"))
            {
                Console.WriteLine(obj);
            }
            var str = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile("shipf", "MD5");
            Console.WriteLine(str);
            if ("" == System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile("shipf", "MD5")) { }
            Console.Read();
        }
    }
}
