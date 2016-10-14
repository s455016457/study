using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Singleton;
using System.Reflection;
using Factory;
using Test.TestFiles;
using System.Threading;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("======================Begin测试Singleton======================");
                TestBase test = ObjectFactory.CreatedObject<TestSingleton>();
                test.Test(p =>
                {
                    Console.WriteLine("======================End测试Singleton======================");
                    Console.WriteLine(p);
                });
            }
            Thread.Sleep(100);
            Console.WriteLine("");
            {
                Console.WriteLine("======================Begin测试VisitorPattern======================");
                TestBase test = ObjectFactory.CreatedObject<TestVisitorPattern>();
                test.Test(p =>
                {
                    Console.WriteLine("======================End测试VisitorPattern======================");
                    Console.WriteLine(p);
                });
            }
            Thread.Sleep(100);
            Console.WriteLine("");
            {
                Console.WriteLine("======================Begin测试FactoryMethod======================");
                TestBase test = ObjectFactory.CreatedObject<TestFactoryMethod>();
                test.Test(p =>
                {
                    Console.WriteLine("======================End测试FactoryMethod======================");
                    Console.WriteLine(p);
                });
            }
            Thread.Sleep(100);
            Console.WriteLine("");
            {
                Console.WriteLine("======================Begin测试AbstactFactory======================");
                TestBase test = ObjectFactory.CreatedObject<TestAbstactFactory>();
                test.Test(p =>
                {
                    Console.WriteLine("======================End测试AbstactFactory======================");
                    Console.WriteLine(p);
                });
            }
            Thread.Sleep(100);
            Console.WriteLine("");
            {
                Console.WriteLine("======================Begin测试Adapter======================");
                TestBase test = ObjectFactory.CreatedObject<TestAdapter>();
                test.Test(p =>
                {
                    Console.WriteLine("======================End测试Adapter======================");
                    Console.WriteLine(p);
                });
            }
            Thread.Sleep(100);
            Console.WriteLine("");
            {
                Console.WriteLine("======================Begin测试Bridge======================");
                TestBase test = ObjectFactory.CreatedObject<TestBridge>();
                test.Test(p =>
                {
                    Console.WriteLine("======================End测试Bridge======================");
                    Console.WriteLine(p);
                });
            }

            Console.Read();
        }
    }
}
