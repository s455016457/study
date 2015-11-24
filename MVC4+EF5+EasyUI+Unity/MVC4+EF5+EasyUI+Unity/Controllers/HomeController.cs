using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC4_EF5_EasyUI_Unity.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 业务层注入
        /// </summary>
        [Dependency]
        public App.IBLL.ISysSampleBLL bal { get; set; }

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetList()
        {
            List<App.Models.SysSample> list = bal.GetList("");
            var json = new
            {
                total = list.Count,
                rows = (from r in list
                        select new App.Models.SysSample()
                        {

                            Id = r.Id,
                            Name = r.Name,
                            Age = r.Age,
                            Bir = r.Bir,
                            Photo = r.Photo,
                            Note = r.Note,
                            CreateTime = r.CreateTime,

                        }).ToArray()
            };
            return Json(json, JsonRequestBehavior.AllowGet);
        }

    }
}
