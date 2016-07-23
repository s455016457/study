using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudyEntityFramework;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("====================使用现有数据库=========================");
            //Console.Write("输入新博客：");
            //var name = Console.ReadLine();

            //var blogs = new BlogService();
            //var blog = new Blogs { Name = name };
            //blogs.Add(blog);

            //var query = blogs.Query();
            //Console.WriteLine("所有数据：");
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //Console.WriteLine("====================创建新数据库=========================");
            //Console.Write("输入新博客：");
            //var name2 = Console.ReadLine();

            //var blogs2 = new StudyEntityFramework2.Services();
            //var blog2 = new StudyEntityFramework2.Blog { Name = name2 };
            //blogs2.AddBlog(blog2);

            //var query2 = blogs2.QueryBlog();
            //Console.WriteLine("所有数据：");
            //foreach (var item in query2)
            //{
            //    Console.WriteLine(item.Name);
            //}

            Console.WriteLine(Test.test!=null);

            Console.WriteLine("输入任意键....");
            Console.ReadKey();
        }
    }

    public class Test {
        public static Test test;
    }
}
