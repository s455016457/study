#region CopyRight
/**************************************************************
   Copyright (c) 2016 ShiPengFei. All rights reserved.
   CLR版本        :    4.0.30319.42000
   命名空间名称   :    Test
   文件名         :    TestIOHelper
   创建时间       :    2016/7/27 21:42:43
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
using Common;

namespace Test
{
    public class TestIOHelper:TestBase
    {
        public override void Test()
        {
            String SourcePath = "D:\\新建 Microsoft Excel 工作表.xlsx", TargetPath = "E:\\";
            var iOhelper = IOHelper.Create();
            iOhelper.CopyFile(SourcePath, TargetPath);
            Console.WriteLine("copy File from{0} to {1}", SourcePath, TargetPath);
        }
    }
}