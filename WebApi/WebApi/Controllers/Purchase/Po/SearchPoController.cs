using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers.Purchase.Po
{
    /// <summary>
    /// 获取订单列表
    /// </summary>
    public class SearchPoController : ApiController
    {
        /// <summary>
        /// 获取订单列表
        /// </summary>
        /// <param name="beginDate">开始日期</param>
        /// <param name="endDate">结束日期</param>
        /// <param name="poNum">订单号</param>
        /// <param name="buyer">采购员</param>
        /// <returns></returns>
        public string Get(String beginDate, String endDate,String poNum,String buyer)
        {
            return "value";
        }
        /// <summary>
        /// 获取订单列表，分页
        /// </summary>
        /// <param name="paramater"></param>
        public void Post([FromBody]SearchPoController.Paramater paramater)
        {
        }

        /// <summary>
        /// 查询参数
        /// </summary>
        public class Paramater
        {
            /// <summary>
            /// 开始日期
            /// </summary>
            public String beginDate { get; set; }
            /// <summary>
            /// 结束日期
            /// </summary>
            public String endDate { get; set; }
            /// <summary>
            /// 订单号
            /// </summary>
            public String poNum { get; set; }
            /// <summary>
            /// 采购员
            /// </summary>
            public String buyer { get; set; }
            /// <summary>
            /// 分页
            /// </summary>
            public Models.GridPager pager { get; set; }
        }
    }
}