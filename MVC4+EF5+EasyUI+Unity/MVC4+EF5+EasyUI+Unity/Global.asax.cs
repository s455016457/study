#region CopyRight
/**************************************************************
   Copyright (c) 2015 StarPeng. All rights reserved.
   CLR版本        :    4.0.30319.34209
   命名空间名称   :    $rootnamespace$
   文件名         :    Global
   创建时间       :    2015-11-23 17:08:48
   用户所在的域   :    SHIPENGFEI
   登录用户名     :    Administrator
   文件描述       :    
   版本           :    1.0.0
   历史           :    
   最后更新人     :   
   最后更新时间   :   
 **************************************************************/
#endregion CopyRight

using App.Common;
using App.Core;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using StackExchange.Profiling;

namespace MVC4_EF5_EasyUI_Unity
{
    // 注意: 有关启用 IIS6 或 IIS7 经典模式的说明，
    // 请访问 http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();
            //启用压缩
            BundleTable.EnableOptimizations = true;
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();

            //注入 Ioc
            var container = new UnityContainer();//初始化统一容器
            DependencyRegisterType.Container_Sys(ref container);//系统注入
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));//使用指定的依赖关系解析程序接口，为依赖关系解析程序提供一个注册点。

            //使用Log.config配置log4net
            String logConfigUrl = HttpContext.Current.Server.MapPath("Log.config");
            FileInfo fileInfo = new FileInfo(logConfigUrl);
            LogHander.SetConfig(fileInfo);

#if DEBUG
            //采用MiniProfiler监控EF与.NET MVC 配置
            //StackExchange.Profiling.
            MiniProfilerEF.InitializeEF42();
#endif
        }

        /// <summary>
        /// 全局异常处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Application_Error(object sender, EventArgs e)
        {
            String strUrl = HttpContext.Current.Request.Url.ToString();
            HttpServerUtility server = HttpContext.Current.Server;
            Exception lastError = server.GetLastError();
            if (lastError != null)
            {
                // 此处进行异常记录，可以记录到数据库或文本，也可以使用其他日志记录组件。
                ExceptionHander.WriteException(lastError);
                Application["LastError"] = lastError;
                int statusCode = HttpContext.Current.Response.StatusCode;
                //string exceptionOperator = "/SysException/Error";
                //try
                //{
                //    if (!String.IsNullOrEmpty(exceptionOperator))
                //    {
                //        exceptionOperator = new System.Web.UI.Control().ResolveUrl(exceptionOperator);
                //        string url = string.Format("{0}?ErrorUrl={1}", exceptionOperator, server.UrlEncode(strUrl));
                //        string script = String.Format("<script language='javascript' type='text/javascript'>window.top.location='{0}';</script>", url);
                //        Response.Write(script);
                //        Response.End();
                //    }
                //}
                //catch { }
            }
        }

        protected void Application_BeginRequest()
        {
            if (Request.IsLocal)//这里是允许本地访问启动监控,可不写
            {
#if DEBUG
                //采用MiniProfiler监控EF与.NET MVC 配置
                MiniProfiler.Start();
#endif
            }
        }

        protected void Application_EndRequest()
        {
#if DEBUG
            //采用MiniProfiler监控EF与.NET MVC 配置
            MiniProfiler.Stop();
#endif
        }
    }
}
