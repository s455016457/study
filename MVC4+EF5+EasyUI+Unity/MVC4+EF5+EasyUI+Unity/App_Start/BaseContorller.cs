#region CopyRight
/**************************************************************
   Copyright (c) 2015 StarPeng. All rights reserved.
   CLR版本        :    4.0.30319.34209
   命名空间名称   :    MVC4_EF5_EasyUI_Unity.App_Start
   文件名         :    BaseContorller
   创建时间       :    2015-11-25 18:03:15
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
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC4_EF5_EasyUI_Unity
{
    public class BaseContorller : Controller
    {
        //
        // 摘要:
        //     创建一个将视图呈现给响应的 System.Web.Mvc.ViewResult 对象。
        //
        // 返回结果:
        //     将视图呈现给响应的视图结果。
        protected new ViewResult View()
        {
            AddIsBrowserNewTab();
            return base.View();
        }

        //
        // 摘要:
        //     创建一个呈现指定的 System.Web.Mvc.IView 对象的 System.Web.Mvc.ViewResult 对象。
        //
        // 参数:
        //   view:
        //     为响应呈现的视图。
        //
        // 返回结果:
        //     视图结果。
        protected new ViewResult View(IView view)
        {
            AddIsBrowserNewTab();
            return base.View(view);
        }

        //
        // 摘要:
        //     使用模型创建一个将视图呈现给响应的 System.Web.Mvc.ViewResult 对象。
        //
        // 参数:
        //   model:
        //     视图呈现的模型。
        //
        // 返回结果:
        //     视图结果。
        protected new ViewResult View(object model)
        {
            AddIsBrowserNewTab();
            return base.View(model);
        }

        //
        // 摘要:
        //     使用视图名称创建一个呈现视图的 System.Web.Mvc.ViewResult 对象。
        //
        // 参数:
        //   viewName:
        //     为响应呈现的视图的名称。
        //
        // 返回结果:
        //     视图结果。
        protected new ViewResult View(string viewName)
        {
            AddIsBrowserNewTab();
            return base.View(viewName);
        }

        //
        // 摘要:
        //     创建一个呈现指定的 System.Web.Mvc.IView 对象的 System.Web.Mvc.ViewResult 对象。
        //
        // 参数:
        //   view:
        //     为响应呈现的视图。
        //
        //   model:
        //     视图呈现的模型。
        //
        // 返回结果:
        //     视图结果。
        protected override ViewResult View(IView view, object model)
        {
            AddIsBrowserNewTab();
            return base.View(view, model);
        }

        //
        // 摘要:
        //     使用视图名称和模型创建一个将视图呈现给响应的 System.Web.Mvc.ViewResult 对象。
        //
        // 参数:
        //   viewName:
        //     为响应呈现的视图的名称。
        //
        //   model:
        //     视图呈现的模型。
        //
        // 返回结果:
        //     视图结果。
        protected new ViewResult View(string viewName, object model)
        {
            AddIsBrowserNewTab();
            return base.View(viewName, model);
        }

        //
        // 摘要:
        //     使用视图名称和母版页名称创建一个将视图呈现给响应的 System.Web.Mvc.ViewResult 对象。
        //
        // 参数:
        //   viewName:
        //     为响应呈现的视图的名称。
        //
        //   masterName:
        //     在呈现视图时要使用的母版页或模板的名称。
        //
        // 返回结果:
        //     视图结果。
        protected new ViewResult View(string viewName, string masterName)
        {
            AddIsBrowserNewTab();
            return base.View(viewName, masterName);
        }

        //
        // 摘要:
        //     使用视图名称、母版页名称和模型创建一个呈现视图的 System.Web.Mvc.ViewResult 对象。
        //
        // 参数:
        //   viewName:
        //     为响应呈现的视图的名称。
        //
        //   masterName:
        //     在呈现视图时要使用的母版页或模板的名称。
        //
        //   model:
        //     视图呈现的模型。
        //
        // 返回结果:
        //     视图结果。
        protected override ViewResult View(string viewName, string masterName, object model)
        {
            AddIsBrowserNewTab();
            return base.View(viewName, masterName, model);
        }

        protected JsonResult ResultSuccessJson(Object obj = null, string message = null)
        {
            Dictionary<String, Object> json = new Dictionary<string, object>();
            json.Add("ret", true);
            json.Add("data", obj);
            json.Add("message", message);
            return Json(json, JsonRequestBehavior.AllowGet);
        }

        protected JsonResult ResultErrorJson(Object obj = null, string message = null)
        {
            Dictionary<String, Object> json = new Dictionary<string, object>();
            json.Add("ret", false);
            json.Add("data", obj);
            json.Add("message", message);
            return Json(json, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 向ViewData添加页面是否是从新选项卡打开标识
        /// </summary>
        private void AddIsBrowserNewTab()
        {
            Boolean isBrowserNewTab = false;
            if (Request["isBrowserNewTab"] != null && Boolean.Parse(Request["isBrowserNewTab"].ToString()))
            {
                isBrowserNewTab = true;
            }

            ViewData.Remove("isBrowserNewTab");
            ViewData.Add("isBrowserNewTab", isBrowserNewTab);
        }
    }
}
