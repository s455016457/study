#region CopyRight
/**************************************************************
   Copyright (c) 2016 ShiPengFei. All rights reserved.
   CLR版本        :    4.0.30319.42000
   命名空间名称   :    $rootnamespace$
   文件名         :    Class1
   创建时间       :    2016/8/19 11:44:59
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
    /// 新闻
    /// </summary>
    public class News
    {
        /// <summary>
        /// 新闻标题
        /// </summary>
        private string _news_title;
        public string news_title
        {
            get { return this._news_title; }
            set { this._news_title = value; }

        }
        /// <summary>
        /// 新闻内容
        /// </summary>
        private string _news_content;
        public string news_content
        {
            get { return this._news_content; }
            set { this._news_content = value; }

        }
    }
}
