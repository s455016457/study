using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using App.IBLL;
using App.Common;
using App.Models;

namespace MVC4_EF5_EasyUI_Unity.Controllers
{
    public class MenuController : Controller
    {
        /// <summary>
        /// 业务层注入
        /// </summary>
        [Dependency]
        public ISysMenuBLL bal { get; set; }
        
        public ActionResult Index()
        {
            Sort sort = new Sort() {
                sort = "Sort",
                order=""
            };
           var list =  bal.GetSysFounctionList(new List<QueryParameter>(), sort);
            return View(list);
        }

        public JsonResult GetMenuGroupTree(String SysFunctionid)
        {
            List<IDictionary<String, Object>> list = new List<IDictionary<string, object>>();
            Sort sort = new Sort() {
                sort = "Sort",
                order=""
            };
            IList<QueryParameter> queryParameters = new List<QueryParameter>();
            queryParameters.Add(new QueryParameter
            {
                FileName = "SysFunction_Id",
                FileValue = SysFunctionid,
                CompareSymbol = CompareSymbol.StartsWith,
                ConnectSysmbol = ConnectSysmbol.And
            });
            var menugroups = bal.GetMenuGroupList(queryParameters, sort);

            foreach (var item in menugroups)
            {
                IDictionary<String, Object> node = new Dictionary<String, Object>();
                node.Add("id", item.MenuGroup_Id);
                node.Add("text", item.Name);
                node.Add("iconCls", item.Iconic);
                queryParameters = new List<QueryParameter>();
                queryParameters.Add(new QueryParameter
                {
                    FileName = "MenuGroup_Id",
                    FileValue = item.MenuGroup_Id,
                    CompareSymbol = CompareSymbol.StartsWith,
                    ConnectSysmbol = ConnectSysmbol.And
                });

                List<IDictionary<String, Object>> childrenNodes = new List<IDictionary<String, Object>>();
                var menus = bal.GetMenuList(queryParameters, sort);
                foreach (var menu in menus)
                {
                    IDictionary<String, Object> childrennode = new Dictionary<String, Object>();
                    childrennode.Add("id", menu.Menu_Id);
                    childrennode.Add("text", menu.Name);
                    childrennode.Add("iconCls", menu.Iconic);
                    IDictionary<String, Object> attributes = new Dictionary<String, Object>();
                    attributes.Add("url", menu.Url);
                    attributes.Add("ModelId", menu.ModelId);
                    childrennode.Add("attributes", attributes);
                    childrenNodes.Add(childrennode);
                }
                if (childrenNodes.Count > 0)
                    node.Add("state", "closed");
                node.Add("children", childrenNodes);
                list.Add(node);
            }

            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}
