#region CopyRight
/**************************************************************
   Copyright (c) 2015 StarPeng. All rights reserved.
   CLR版本        :    4.0.30319.34209
   命名空间名称   :    App.IDAL
   文件名         :    ISysSampleRepository
   创建时间       :    2015-11-24 11:52:01
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
    public interface ISysSampleRepository
    {
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="db">数据库上下文</param>
        /// <returns>数据列表</returns>
        IQueryable<SysSample> GetList(DBContainer db);
        /// <summary>
        /// 创建一个实体
        /// </summary>
        /// <param name="entity">实体</param>
        int Create(SysSample entity);
        /// <summary>
        /// 删除一个实体
        /// </summary>
        /// <param name="entity">主键ID</param>
        int Delete(string id);

        /// <summary>
        /// 修改一个实体
        /// </summary>
        /// <param name="entity">实体</param>
        int Edit(SysSample entity);
        /// <summary>
        /// 获得一个实体
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>实体</returns>
        SysSample GetById(string id);
        /// <summary>
        /// 判断一个实体是否存在
        /// </summary>
        bool IsExist(string id);
    }
}
