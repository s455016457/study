using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebApi
{
    /// <summary>
    /// 程序入口
    /// </summary>
    public class WebApiApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// 程序入库
        /// </summary>
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            StartApplicationService();
        }

        /// <summary>
        /// 开启应用程序服务
        /// </summary>
        private void StartApplicationService()
        {
            LoggerService.LoggerService.Start();
            LoggerService.LoggerService.ApplicationLogger.Debug("日志服务开启成功！");
        }
    }
}
