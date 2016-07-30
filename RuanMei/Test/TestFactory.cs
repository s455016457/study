#region CopyRight
/**************************************************************
   Copyright (c) 2016 ShiPengFei. All rights reserved.
   CLR版本        :    4.0.30319.42000
   命名空间名称   :    Test
   文件名         :    TestFactory
   创建时间       :    2016/7/28 16:42:32
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
using Factory;

namespace Test
{
    public class TestFactory:TestBase
    {
        public override void Test()
        {
            var objs = ObjectFactory.CreatedobjectByFullPath("E:\\study\\ComplicatingTestTool\\TestSwerpPRApproveRequest\\bin\\Debug\\TestSwerpPRApproveRequest.dll");
            foreach (var obj in objs) { }
        }
    }
}
