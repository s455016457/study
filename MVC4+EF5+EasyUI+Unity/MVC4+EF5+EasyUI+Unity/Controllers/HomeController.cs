using App.Common;
using Microsoft.Practices.Unity;
using MVC4_EF5_EasyUI_Unity.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC4_EF5_EasyUI_Unity.Controllers
{
    public class HomeController : BaseContorller
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

        #region 创建
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Create(App.Models.SysSample model)
        {
            if (bal.Create(model))
            {
                return Json(1, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(0, JsonRequestBehavior.AllowGet);
            }

        }
        #endregion

        public ActionResult Detail()
        {
            return View();
        }

        #region 更新
        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Edit(App.Models.SysSample model)
        {


            if (bal.Edit(model))
            {
                return Json(1, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(0, JsonRequestBehavior.AllowGet);
            }

        }
        #endregion

        public JsonResult GetList(GridPager pager)
        {
            List<App.Models.SysSample> list = bal.GetList("",ref pager);
            var json = new
            {
                total = pager.totalRows,
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
