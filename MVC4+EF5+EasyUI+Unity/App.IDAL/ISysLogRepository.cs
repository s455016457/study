#region CopyRight
/**************************************************************
   Copyright (c) 2015 shipengfei. All rights reserved.
   CLR版本        :    4.0.30319.34209
   命名空间名称   :    App.IDAL
   文件名         :    ISysLogRepository
   创建时间       :    2015-12-01 16:38:14
   用户所在的域   :    SHIPENGFEI
   登录用户名     :    Administrator
   文件描述       :    
   版本           :    1.0.0
   历史           :    
   最后更新人     :   
   最后更新时间   :   
 **************************************************************/
#endregion CopyRight

using App.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.IDAL
{
    public interface ISysLogRepository
    {
        /// <summary>
        /// 创建实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        int Create(SysLog entity);
        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="db"></param>
        /// <param name="deleteCollection"></param>
        void Delete(DBContainer db, string[] deleteCollection);
        /// <summary>
        /// 获得实体列表
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        IQueryable<SysLog> GetList(DBContainer db);
        /// <summary>
        /// 获得实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        SysLog GetById(string id);
    }
}

