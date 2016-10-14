#region CopyRight
/**************************************************************
   Copyright (c) 2016 ShiPengFei. All rights reserved.
   CLR版本        :    4.0.30319.42000
   命名空间名称   :    WebService
   文件名         :    StudentService
   创建时间       :    2016/7/30 8:33:27
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
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// StudentService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class StudentService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        /// <summary>
        /// 获得学生，返回的是XML数据
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public Student GetStudent()
        {
            return new Student()
            {
                Id = 15
                ,
                Name = "赵六"
                ,
                Gender = "男"
                ,
                IsVip = false
                ,
                CreatedStamp = DateTime.Now
            };
        }

        /// <summary>
        /// 获得学生列表，返回的是XML数据
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        [ScriptMethod(UseHttpGet=true)]
        public List<Student> GetStudentList()
        {
            return new List<Student>() { 
                new Student(){
                    Id=11
                    ,Name="张三"
                    ,Gender="男"
                    ,IsVip=true
                    ,CreatedStamp=DateTime.Now
                },
                new Student(){
                    Id=12
                    ,Name="李四"
                    ,Gender="男"
                    ,IsVip=true
                    ,CreatedStamp=DateTime.Now
                },
                new Student(){
                    Id=13
                    ,Name="王五"
                    ,Gender="男"
                    ,IsVip=true
                    ,CreatedStamp=DateTime.Now
                },
                new Student(){
                    Id=14
                    ,Name="翠花"
                    ,Gender="女"
                    ,IsVip=true
                    ,CreatedStamp=DateTime.Now
                }
            };
        }

    }

    public class Student
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public String Gender { get; set; }

        public Boolean IsVip { get; set; }

        public DateTime CreatedStamp { get; set; }
    }
}
