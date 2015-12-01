using App.Common;
using App.IBLL;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC4_EF5_EasyUI_Unity.Controllers
{
    public class MainController : Controller
    {
        /// <summary>
        /// 业务层注入
        /// </summary>
        [Dependency]
        public ISysMenuBLL bal { get; set; }
        //
        // GET: /Main/

        public ActionResult Index()
        {
            Sort sort = new Sort()
            {
                sort = "Sort",
                order = ""
            };
            var list = bal.GetSysFounctionList(new List<QueryParameter>(), sort);
            return View(list);
        }

    }
}
