#region CopyRight
/**************************************************************
   Copyright (c) 2015 shipengfei. All rights reserved.
   CLR版本        :    4.0.30319.34209
   命名空间名称   :    App.BLL
   文件名         :    SysLogBLL
   创建时间       :    2015-12-01 16:48:19
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
using App.Entity;
using App.IBLL;
using App.IDAL;
using App.Models.Sys;
using App.Extensions;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.BLL
{
    public class SysLogBLL : ISysLogBLL
    {
        [Dependency]
        public ISysLogRepository logRepository { get; set; }
        App.Entity.DBContainer db = new App.Entity.DBContainer();

        public List<SysLogModel> GetList(IList<QueryParameter> list, ref GridPager pager)
        {
            var queryData = logRepository.GetList(db);
            var condition = QueryHelp.ToExpression<App.Entity.SysLog>(list);
            queryData = queryData.Where(condition);
            queryData = queryData.OrderBy(pager.sort, pager.order.Equals("desc", StringComparison.CurrentCultureIgnoreCase));
            pager.totalRows = queryData.Count();
            if (pager.totalRows > 0)
            {
                if (pager.page <= 1)
                {
                    queryData = queryData.Take(pager.rows);
                }
                else
                {
                    queryData = queryData.Skip((pager.page - 1) * pager.rows).Take(pager.rows);
                }
            }
            return ToSysLogModelList(ref queryData);
        }

        public List<SysLogModel> ToSysLogModelList(ref IQueryable<SysLog> queryData)
        {
            List<SysLogModel> modelList = (from r in queryData
                                           select new SysLogModel
                                           {
                                               CreateTime = r.CreateTime,
                                               Id = r.Id,
                                               Message = r.Message,
                                               Module = r.Module,
                                               Operator = r.Operator,
                                               Result = r.Result,
                                               Type = r.Type
                                           }).ToList();

            return modelList;
        }

        public SysLogModel GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}