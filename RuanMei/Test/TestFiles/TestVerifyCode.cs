#region CopyRight
/**************************************************************
   Copyright (c) 2016 ShiPengFei. All rights reserved.
   CLR版本        :    4.0.30319.42000
   命名空间名称   :    Test
   文件名         :    TestVerfyCode
   创建时间       :    2016/8/19 17:37:05
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
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Test
{
    public class TestVerifyCode:TestBase
    {
        public override void Test()
        {
            VerifyCodeHelper verify = new VerifyCodeHelper(8);
            verify.SetGarbleLineCount(3);
            verify.GarbleLineSize = 1;
            verify.GarbleLineColor = Color.Red;
            String code=String.Empty;
            //verify.RemoveCodeWareroom("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            verify.AddCodeWareroom("~!@#$%^&*()_+|\\<>?/");
            var bitmap = verify.CreateVerifyCode(out code);
            bitmap.Save("VerifyCode.gif", ImageFormat.Gif);
            Console.WriteLine("验证码：{0}", code);
        }
    }
}
