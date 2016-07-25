#region CopyRight
/**************************************************************
   Copyright (c) 2016 ShiPengFei. All rights reserved.
   CLR版本        :    4.0.30319.42000
   命名空间名称   :    Test
   文件名         :    TestSingleonOne
   创建时间       :    2016/7/24 8:40:15
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
using System.Windows.Forms;
using Singleton;

namespace Test
{
    public class TestSingleon :TestBase
    {
        public override void Test()
        {
            var taskF = new TaskFactory();
            Console.WriteLine("SingletonOne");
            List<Task> listTask= new List<Task>();
            for (int i = 0; i < 10; i++)
                listTask.Add(taskF.StartNew(() => SingletonOne.CreateInstance().Show()));

            Task.WaitAll(listTask.ToArray());

            Console.WriteLine("SingletonTwo");
            for (int i = 0; i < 10; i++)
                listTask.Add(taskF.StartNew(() => SingletonTwo.CreateInstance().Show()));

            taskF.ContinueWhenAll(listTask.ToArray(), (a) => { Console.WriteLine(a); MessageBox.Show(a.Count().ToString()); });

            Console.WriteLine("SingletonThree");
            for (int i = 0; i < 10; i++)
                listTask.Add(taskF.StartNew(() => SingletonThree.CreateInstance().Show()));
        }
    }
}
