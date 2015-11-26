#region CopyRight
/**************************************************************
   Copyright (c) 2015 StarPeng. All rights reserved.
   CLR版本        :    4.0.30319.34209
   命名空间名称   :    $rootnamespace$
   文件名         :    Class1
   创建时间       :    2015-11-24 10:48:51
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
using App.DAL;
using App.IBLL;
using App.IDAL;
using App.Models;
using App.Extensions;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace App.BLL
{
    public class SysSampleBLL : ISysSampleBLL
    {
        App.Entity.DBContainer db = new App.Entity.DBContainer();

        /// <summary>
        /// 仓储层注入
        /// </summary>
        [Dependency]
        public ISysSampleRepository Rep { get; set; }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="queryStr"></param>
        /// <returns></returns>
        public List<SysSample> GetList(string queryStr,ref GridPager pager)
        {
            var queryData = Rep.GetList(db);
            var queryHelp = new QueryHelp();
            var sort = pager.sort;
            //排序
                var type = typeof(SysSample);
                var param = Expression.Parameter(type, type.Name);
                var body = Expression.Property(param, pager.sort);
                dynamic keySelector = Expression.Lambda(body, param);
            if (pager.order == "desc")
            {

                queryData = queryData.OrderBy(sort, true);
            }
            else
            {
                queryData = queryData.OrderBy(sort);
            }
            return CreateModelList(ref queryData,ref pager);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="queryData"></param>
        /// <returns></returns>
        private List<SysSample> CreateModelList(ref IQueryable<App.Entity.SysSample> queryData,ref GridPager pager)
        {
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
            List<SysSample> modelList = (from r in queryData
                                         select new SysSample
                                              {
                                                  Id = r.Id,
                                                  Name = r.Name,
                                                  Age = r.Age,
                                                  Bir = r.Bir,
                                                  Photo = r.Photo,
                                                  Note = r.Note,
                                                  CreateTime = r.CreateTime,

                                              }).ToList();

            return modelList;
        }

        /// <summary>
        /// 创建一个对象
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Create(Models.SysSample model)
        {
            try
            {
                App.Entity.SysSample entity = Rep.GetById(model.Id);
                if (entity != null)
                {
                    return false;
                }
                entity = new Entity.SysSample()
                {
                    Id = model.Id,
                    Name = model.Name,
                    Age = model.Age,
                    Bir = model.Bir,
                    Photo = model.Photo,
                    CreateTime = model.CreateTime,
                    Note = model.Note
                };

                if (Rep.Create(entity) == 1)
                {
                    return true;
                }
                else
                {

                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一个对象
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            try
            {
                if (Rep.Delete(id) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// 更新一个对象
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Edit(Models.SysSample model)
        {
            try
            {
                App.Entity.SysSample entity = Rep.GetById(model.Id);
                if (entity == null)
                {
                    return false;
                }
                entity.Name = model.Name;
                entity.Age = model.Age;
                entity.Bir = model.Bir;
                entity.Photo = model.Photo;
                entity.Note = model.Note;

                if (Rep.Edit(entity) == 1)
                {
                    return true;
                }
                else
                {

                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// 获取一个对象
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Models.SysSample GetById(string id)
        {
            if (IsExist(id))
            {
                App.Entity.SysSample entity = Rep.GetById(id);
                SysSample model = new SysSample();
                model.Id = entity.Id;
                model.Name = entity.Name;
                model.Age = entity.Age;
                model.Bir = entity.Bir;
                model.Photo = entity.Photo;
                model.Note = entity.Note;
                model.CreateTime = entity.CreateTime;

                return model;
            }
            else
            {
                return new SysSample();
            }
        }

        /// <summary>
        /// 判断对象是否存在
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool IsExist(string id)
        {
            return Rep.IsExist(id);
        }
    }
}
