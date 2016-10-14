#region CopyRight
/**************************************************************
   Copyright (c) 2016 ShiPengFei. All rights reserved.
   CLR版本        :    4.0.30319.42000
   命名空间名称   :    DecoratorPattern
   文件名         :    XML_News
   创建时间       :    2016/8/19 12:07:11
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
    public class XML_News:IComponent_News
    {
        public List<News> getListOfNews()
        {
            List<News> _list = new List<News>();
            Console.WriteLine("从XML文件中获取新闻数据");
            return _list;
        }
    }
}
