#region CopyRight
/**************************************************************
   Copyright (c) 2015 StarPeng. All rights reserved.
   CLR版本        :    4.0.30319.34209
   命名空间名称   :    $rootnamespace$
   文件名         :    Class1
   创建时间       :    2015-11-24 10:51:14
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
    public class SysSample : BaseModel
    {
        [Display(Name = "ID")]
        public string Id { get; set; }


        [Display(Name = "名称")]
        public string Name { get; set; }


        [Display(Name = "年龄")]
        [Range(0, 10000)]
        public int? Age { get; set; }

        [Display(Name = "生日")]
        public DateTime? Bir { get; set; }

        [Display(Name = "照片")]
        public string Photo { get; set; }


        [Display(Name = "简介")]
        public string Note { get; set; }

        [Display(Name = "创建时间")]
        public DateTime? CreateTime { get; set; }
    }
}
