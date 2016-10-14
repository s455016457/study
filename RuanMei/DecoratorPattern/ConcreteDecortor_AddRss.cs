#region CopyRight
/**************************************************************
   Copyright (c) 2016 ShiPengFei. All rights reserved.
   CLR版本        :    4.0.30319.42000
   命名空间名称   :    DecoratorPattern
   文件名         :    ConcreteDecortor_AddRss
   创建时间       :    2016/8/19 12:17:02
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

namespace DecoratorPattern
{
    /// <summary>
    /// 扩展新闻组件: 把新闻加入到RSS中的方法类
    /// </summary>
    public class ConcreteDecortor_AddRss :Decorator_News
    {
        /// <summary>
        /// 新闻标题被RSS收录
        /// </summary>
        /// <returns></returns>
        public String AddRss()
        {
            String message = "新闻标题已经加入到RSS中";
            Console.WriteLine(message);
            return message;
        }

        public ConcreteDecortor_AddRss(IComponent_News compontent_News)
            : base(compontent_News)
        {

        }
        /// <summary>
        /// 重写父类中读取新闻的方法,把新闻加入到RSS中的方法类
        /// </summary>
        /// <returns></returns>
        public override List<News> getListOfNews()
        {
            //把新闻加入到RSS中的方法类
            AddRss();
            return base.getListOfNews();
        }
    }
}
