#region CopyRight
/**************************************************************
   Copyright (c) 2016 ShiPengFei. All rights reserved.
   CLR版本        :    4.0.30319.42000
   命名空间名称   :    DecoratorPattern
   文件名         :    ConcreteDecortor_AddAmount
   创建时间       :    2016/8/19 12:11:31
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
    /// 扩展新闻组件，给新闻添加人气的方法类
    /// </summary>
    public class ConcreteDecortor_AddAmount : Decorator_News
    {
        public String AddAmount()
        {
            String message = "新闻人气已经加一";
            Console.WriteLine(message);
            return message;
        }
        public ConcreteDecortor_AddAmount(IComponent_News component_News)
            : base(component_News)
        {

        }

        /// <summary>
        /// 重写父类读取新闻的方法
        /// </summary>
        /// <returns></returns>
        public override List<News> getListOfNews()
        {
            AddAmount();
            return base.getListOfNews();
        }
    }
}
