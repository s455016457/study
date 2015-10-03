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
            Console.Write("输入新博客：");
            var name = Console.ReadLine();

            var blogs = new BlogService();
            var blog = new Blogs { Name = name };
            blogs.Add(blog);

            var query = blogs.Query();
            Console.WriteLine("所有数据：");
            foreach (var item in query)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("输入任意键....");
            Console.ReadKey();
        }
    }

}
