#region CopyRight
/**************************************************************
   Copyright (c) 2016 ShiPengFei. All rights reserved.
   CLR版本        :    4.0.30319.42000
   命名空间名称   :    Test
   文件名         :    TestVistor
   创建时间       :    2016/7/23 16:46:23
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
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Test
{
    public class TestSpeech : TestBase
    {
        public override void Test()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();  //开始计时
            var speech = SpeechSynthesizerHepler.Create();
            var log = LogHelper.Create();
            log.WriteLog("程序开始运行");
            speech.SpeakTxt(Path.GetFullPath("config/ReadMe.txt"));
            speech.SpeakContent("程序执行完了");
            Console.WriteLine("程序执行完了");
            log.WriteLog("程序执行完了");
            watch.Stop();
            Console.WriteLine("共用时:{0}ms", watch.ElapsedMilliseconds);
        }
    }
}
