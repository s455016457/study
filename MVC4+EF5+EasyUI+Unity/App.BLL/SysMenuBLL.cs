#region CopyRight
/**************************************************************
   Copyright (c) 2015 shipengfei. All rights reserved.
   CLR版本        :    4.0.30319.34209
   命名空间名称   :    App.BLL
   文件名         :    SysMenuBLL
   创建时间       :    2015-11-27 10:38:47
   用户所在的域   :    SHIPENGFEI
   登录用户名     :    Administrator
   文件描述       :    
   版本           :    1.0.0
   历史           :    
   最后更新人     :   
   最后更新时间   :   
 **************************************************************/
#endregion CopyRight

using App.IBLL;
using App.IDAL;
using App.Models;
using App.Extensions;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App.Common;
using System.Linq.Expressions;
using System.Reflection;

namespace App.BLL
{
    public class SysMenuBLL : ISysMenuBLL
    {
        App.Entity.DBContainer db = new App.Entity.DBContainer();
        /// <summary>
        /// 仓储层注入
        /// </summary>
        [Dependency]//此属性是用来标记属性和参数作为目标的注入
        public ISysMenuRepository Rep { get; set; }
        #region 系统功能
        public List<SysFunction> GetSysFounctionList(IList<QueryParameter> list, Sort sort)
        {
            var queryData = Rep.GetSysFunctionList(db);
            var condition = QueryHelp.ToExpression<App.Entity.SysFunction>(list);
            queryData = queryData.Where(condition);
            queryData = queryData.OrderBy(sort.sort, sort.order.Equals("desc", StringComparison.CurrentCultureIgnoreCase));
            return ToSysFunctionList(ref queryData);
            
        }

        public List<SysFunction> GetSysFounctionListPager(IList<QueryParameter> list, ref GridPager pager)
        {
            var queryData = Rep.GetSysFunctionList(db);
            var condition = QueryHelp.ToExpression<App.Entity.SysFunction>(list);
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
            return ToSysFunctionList(ref queryData);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="queryData"></param>
        /// <returns></returns>
        private List<SysFunction> ToSysFunctionList(ref IQueryable<App.Entity.SysFunction> queryData)
        {

            List<SysFunction> modelList = (from r in queryData
                                           // 外连接
                                           //join b in Rep.GetMenuGroupList(db) on r.SysFunction_Id equals b.SysFunction_Id 
                                           select new SysFunction
                                           {
                                               SysFunction_Id = r.SysFunction_Id,
                                               CreatePerson = r.CreatePerson,
                                               CreateTime = r.CreateTime,
                                               EnglishName = r.EnglishName,
                                               Iconic = r.Iconic,
                                               Name = r.Name,
                                               Remark = r.Remark,
                                               Sort = r.Sort,
                                               State = r.State.HasValue ? r.State.Value : false,
                                               Version = r.Version
                                           }).ToList();

            return modelList;
        }

        public Models.SysFunction GetSysFounctionById(string Id)
        {
            throw new NotImplementedException();
        }

        public bool SysFounctionIsExist(string Id)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region 菜单组
        public List<MenuGroup> GetMenuGroupList(IList<QueryParameter> list, Sort sort)
        {
            var queryData = Rep.GetMenuGroupList(db);
            var condition = QueryHelp.ToExpression<App.Entity.MenuGroup>(list);
            queryData = queryData.Where(condition);
            queryData = queryData.OrderBy(sort.sort, sort.order.Equals("desc", StringComparison.CurrentCultureIgnoreCase));
            return ToMenuGroupList(ref queryData);
        }

        public List<Models.MenuGroup> GetMenuGroupListPager(IList<QueryParameter> list, ref Common.GridPager pager)
        {
            var queryData = Rep.GetMenuGroupList(db);
            var condition = QueryHelp.ToExpression<App.Entity.MenuGroup>(list);
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
            return ToMenuGroupList(ref queryData);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="queryData"></param>
        /// <returns></returns>
        private List<MenuGroup> ToMenuGroupList(ref IQueryable<App.Entity.MenuGroup> queryData)
        {

            List<MenuGroup> modelList = (from r in queryData
                                         // 外连接
                                         //join b in Rep.GetMenuGroupList(db) on r.SysFunction_Id equals b.SysFunction_Id 
                                         select new MenuGroup
                                           {
                                               SysFunction_Id = r.SysFunction_Id,
                                               MenuGroup_Id = r.MenuGroup_Id,
                                               CreatePerson = r.CreatePerson,
                                               CreateTime = r.CreateTime,
                                               EnglishName = r.EnglishName,
                                               Iconic = r.Iconic,
                                               Name = r.Name,
                                               Remark = r.Remark,
                                               Sort = r.Sort,
                                               State = r.State.HasValue ? r.State.Value : false,
                                               Version = r.Version
                                           }).ToList();

            return modelList;
        }

        public Models.MenuGroup GetMenuGroupById(string Id)
        {
            throw new NotImplementedException();
        }

        public bool MenuGroupIsExist(string Id)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region 菜单
        public List<Menu> GetMenuList(IList<QueryParameter> list, Sort sort)
        {
            var queryData = Rep.GetMenuList(db);
            var condition = QueryHelp.ToExpression<App.Entity.Menu>(list);
            queryData = queryData.Where(condition);
            queryData = queryData.OrderBy(sort.sort, sort.order.Equals("desc", StringComparison.CurrentCultureIgnoreCase));
            return ToMenuList(ref queryData);
        }

        public List<Models.Menu> GetMenuListPager(IList<QueryParameter> list, ref Common.GridPager pager)
        {
            var queryData = Rep.GetMenuList(db);
            var condition = QueryHelp.ToExpression<App.Entity.Menu>(list);
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
            return ToMenuList(ref queryData);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="queryData"></param>
        /// <returns></returns>
        private List<Menu> ToMenuList(ref IQueryable<App.Entity.Menu> queryData)
        {

            List<Menu> modelList = (from r in queryData
                                    // 外连接
                                    //join b in Rep.GetMenuGroupList(db) on r.SysFunction_Id equals b.SysFunction_Id 
                                    select new Menu
                                         {
                                             Menu_Id = r.Menu_Id,
                                             MenuGroup_Id = r.MenuGroup_Id,
                                             CreatePerson = r.CreatePerson,
                                             CreateTime = r.CreateTime,
                                             EnglishName = r.EnglishName,
                                             Iconic = r.Iconic,
                                             Name = r.Name,
                                             Remark = r.Remark,
                                             Sort = r.Sort,
                                             State = r.State.HasValue ? r.State.Value : false,
                                             Version = r.Version,
                                             ModelId = r.ModelId,
                                             Url = r.Url
                                         }).ToList();

            return modelList;
        }

        public Models.Menu GetMenuById(string Id)
        {
            throw new NotImplementedException();
        }

        public bool MenuIsExist(string Id)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

