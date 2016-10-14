#region CopyRight
/**************************************************************
   Copyright (c) 2016 ShiPengFei. All rights reserved.
   CLR版本        :    4.0.30319.42000
   命名空间名称   :    $rootnamespace$
   文件名         :    UnitTest1
   创建时间       :    2016/7/30 8:49:59
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
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    /// <summary>
    /// 单元测试
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        private WebService.StudentServiceSoapClient service;

        /// <summary>
        /// 声明TestInitialize属性，程序先走该方法
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            service = new WebService.StudentServiceSoapClient();

        }

        [TestMethod]
        public void TestHelloWorldMethod()
        {
            var value1 = service.HelloWorld();
            //断言
            Assert.AreEqual("HellWord", value1);
        }

        [TestMethod]
        public void TestGetStudentMethod()
        {
            var value2 = service.GetStudent();
        }

        [TestMethod]
        public void TestGetStudentListMethod()
        {
            var value3 = service.GetStudentList();
        }
    }
}
