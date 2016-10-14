#region CopyRight
/**************************************************************
   Copyright (c) 2016 ShiPengFei. All rights reserved.
   版本        :    4.0.30319.42000
   命名空间名称   :    Test
   文件名         :    DecoratorPattern
   创建时间       :    2016/8/19 12:22:41
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
using DecoratorPattern;

namespace Test
{
    public class TestDecoratorPattern : TestBase
    {
        public override void Test()
        {
            RunTest(NoDecoratorPattern, "无装饰");
            Console.WriteLine("");
            Console.WriteLine("");
            RunTest(AddAmountDecoratorPattern, "给新闻添加人气装饰");
            Console.WriteLine("");
            Console.WriteLine("");
            RunTest(AddRssDecoratorPattern, "新闻标题入到RSS中装饰");
            Console.WriteLine("");
            Console.WriteLine("");
            RunTest(AddAmountAddRssDecoratorPattern, "先给新闻添加人气，然后新闻标题入到RSS中 装饰");
            Console.WriteLine("");
            Console.WriteLine("");
            RunTest(AddRssAddAmountDecoratorPattern, "先新闻标题入到RSS中，然后给新闻添加人气 装饰");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public void RunTest(Action action, String testTitle)
        {
            Console.WriteLine("*********************开始测试【{0}】*********************", testTitle);
            action.Invoke();
            Console.WriteLine("*********************结束测试【{0}】*********************", testTitle);
        }

        /// <summary>
        /// 无装饰
        /// </summary>
        public void NoDecoratorPattern()
        {
            IComponent_News cn = new DB_News();
            cn.getListOfNews();
        }

        /// <summary>
        /// 给新闻添加人气装饰
        /// </summary>
        public void AddAmountDecoratorPattern()
        {
            IComponent_News cn = new DB_News();
            IComponent_News cn_AddAmount = new ConcreteDecortor_AddAmount(cn);
            cn_AddAmount.getListOfNews();
        }

        /// <summary>
        /// 新闻标题入到RSS中装饰
        /// </summary>
        public void AddRssDecoratorPattern()
        {
            IComponent_News cn = new DB_News();
            IComponent_News cn_AddRss = new ConcreteDecortor_AddRss(cn);
            cn_AddRss.getListOfNews();
        }

        /// <summary>
        /// 先给新闻添加人气，然后新闻标题入到RSS中 装饰
        /// </summary>
        public void AddAmountAddRssDecoratorPattern()
        {
            IComponent_News cn = new DB_News();
            IComponent_News cn_AddRss = new ConcreteDecortor_AddRss(cn);
            IComponent_News cn_AddAmount = new ConcreteDecortor_AddAmount(cn_AddRss);
            cn_AddAmount.getListOfNews();
        }

        /// <summary>
        /// 先新闻标题入到RSS中，然后给新闻添加人气 装饰
        /// </summary>
        public void AddRssAddAmountDecoratorPattern()
        {
            IComponent_News cn = new DB_News();
            IComponent_News cn_AddAmount = new ConcreteDecortor_AddAmount(cn);
            IComponent_News cn_AddRss = new ConcreteDecortor_AddRss(cn_AddAmount);
            cn_AddRss.getListOfNews();
        }
    }
}
