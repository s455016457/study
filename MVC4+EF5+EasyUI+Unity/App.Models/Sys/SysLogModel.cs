#region CopyRight
/**************************************************************
   Copyright (c) 2015 shipengfei. All rights reserved.
   CLR版本        :    4.0.30319.34209
   命名空间名称   :    App.Models.Sys
   文件名         :    SysLogModel
   创建时间       :    2015-12-01 16:27:02
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

namespace App.Models.Sys
{
    public class SysLogModel : BaseModel
    {
        [Display(Name = "ID")]
        public string Id { get; set; }

        [Display(Name = "操作人")]
        public string Operator { get; set; }

        [Display(Name = "信息")]
        public string Message { get; set; }

        [Display(Name = "结果")]
        public string Result { get; set; }

        [Display(Name = "类型")]
        public string Type { get; set; }

        [Display(Name = "模块")]
        public string Module { get; set; }

        [Display(Name = "创建时间")]
        public DateTime? CreateTime { get; set; }
    }
}

