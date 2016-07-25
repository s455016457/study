#region CopyRight
/**************************************************************
   Copyright (c) 2016 ShiPengFei. All rights reserved.
   CLR版本        :    4.0.30319.34209
   命名空间名称   :    $rootnamespace$
   文件名         :    Program
   创建时间       :    2016/6/30 22:19:13
   用户所在的域   :    SHIPENGFEI
   登录用户名     :    admin
   文件描述       :    
   版本           :    1.0.0
   历史           :    
   最后更新人     :   
   最后更新时间   :   
 **************************************************************/
#endregion CopyRight

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        private event Action<String> myEvent;
        static void Main(string[] args)
        {
            Console.WriteLine("***************");
            StringBuilder sb = new StringBuilder();
            Action<StringBuilder> action = s => s.AppendLine("AA");
            action += s => s.AppendLine("BB");
            action(sb);
            Console.WriteLine(sb.ToString());

            Console.WriteLine("========================");
            var test = new Program();
            test.myEvent += s => Console.WriteLine("直接添加匿名方法打印【{0}】",s);
            test.myEvent += new Action<string>(s => Console.WriteLine("添加实例化委托法打印【{0}】", s));
            test.myEvent.Invoke("测试事件");
        }
    }
}
