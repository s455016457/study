using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using App.IBLL;
using App.Common;

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
            bal.GetSysFounctionList("MyJob", sort);
            return View();
        }

    }
}
