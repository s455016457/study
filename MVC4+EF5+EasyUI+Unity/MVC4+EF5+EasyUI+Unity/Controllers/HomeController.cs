using App.Common;
using Microsoft.Practices.Unity;
using MVC4_EF5_EasyUI_Unity;
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
                return ResultSuccessJson(model);
            }
            else
            {
                return ResultErrorJson(model);
            }

        }
        #endregion

        public ActionResult Detail(string Id)
        {
            return View(bal.GetById(Id));
        }

        #region 更新
        public ActionResult Edit(string Id)
        {
            return View(bal.GetById(Id));
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
#if DEBUG
            using (StackExchange.Profiling.MiniProfiler.StepStatic("查询数据SysSample的数据"))
            {
#endif
                List<App.Models.SysSample> list = bal.GetListPager("", ref pager);
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
#if DEBUG
            }
#endif
        }

    }
}
