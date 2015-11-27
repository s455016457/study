#region CopyRight
/**************************************************************
   Copyright (c) 2015 shipengfei. All rights reserved.
   CLR版本        :    4.0.30319.34209
   命名空间名称   :    App.Models
   文件名         :    SysFunction
   创建时间       :    2015-11-26 17:47:57
   用户所在的域   :    SHIPENGFEI
   登录用户名     :    Administrator
   文件描述       :    
   版本           :    1.0.0
   历史           :    
   最后更新人     :   
   最后更新时间   :   
 **************************************************************/
#endregion CopyRight

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace App.Models
{
    public class SysFunction
    {
        [Display(Name = "系统功能ID")]
        [Key]
        public String SysFunction_Id { get; set; }

        [Display(Name = "功能模块名称")]
        public String Name { get; set; }

        [Display(Name = "英文名称")]
        public String EnglishName { get; set; }

        [Display(Name = "图标")]
        public String Iconic { get; set; }

        [Display(Name = "排序")]
        public int? Sort { get; set; }

        [Display(Name = "说明")]
        public String Remark { get; set; }

        [Display(Name = "状态")]
        public Boolean State { get; set; }

        [Display(Name = "创建人")]
        public String CreatePerson { get; set; }

        [Display(Name = "创建时间")]
        public DateTime? CreateTime { get; set; }

        [Display(Name = "版本")]
        public String Version { get; set; }
    }
}

