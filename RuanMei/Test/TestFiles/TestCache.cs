#region CopyRight
/**************************************************************
   Copyright (c) 2016 ShiPengFei. All rights reserved.
   CLR版本        :    4.0.30319.42000
   命名空间名称   :    Test
   文件名         :    TestCache
   创建时间       :    2016/7/24 12:09:11
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
using System.Threading;
using System.Threading.Tasks;
using CacheDome;

namespace Test
{
    public class TestCache:TestBase
    {
        public override void Test()
        {
            var taskF = new TaskFactory();
            for (int i = 0; i < 10; i++)
            {
                taskF.StartNew(() =>
                {
                    var myLoveName = GetMyLoveName();
                    Console.WriteLine("{0}，打印时间：{1}，线程ID：{2}", myLoveName, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), Thread.CurrentThread.ManagedThreadId);
                });
            }
        }

        public String GetMyLoveName()
        {
            String myLoveName = String.Empty;
            var cache = new CacheManager();
            myLoveName = cache.Get<String>("MyLoveName");
            if (myLoveName == null)
            {
                //会有多个线程一起等2秒
                Thread.Sleep(2000);
                myLoveName = "谭雄英";
                cache.Add("MyLove", myLoveName);
            }
            return myLoveName;
        }
    }
}
