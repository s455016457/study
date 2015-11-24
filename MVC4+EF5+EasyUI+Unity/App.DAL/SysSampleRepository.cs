#region CopyRight
/**************************************************************
   Copyright (c) 2015 StarPeng. All rights reserved.
   CLR版本        :    4.0.30319.34209
   命名空间名称   :    $rootnamespace$
   文件名         :    Class1
   创建时间       :    2015-11-24 10:50:36
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
using App.IDAL;
using System;
using System.Data;
using System.Linq;
using System.Text;

namespace App.DAL
{
    public class SysSampleRepository : ISysSampleRepository, IDisposable
    {
        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <returns>数据列表</returns>
        public IQueryable<Entity.SysSample> GetList(DBContainer db)
        {
            IQueryable<SysSample> list = db.SysSample.AsQueryable();
            return list;
        }
        /// <summary>
        /// 创建一个实体
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public int Create(Entity.SysSample entity)
        {
            using (DBContainer db = new DBContainer())
            {
                db.SysSample.AddObject(entity);
                return db.SaveChanges();
            }
        }
        /// <summary>
        /// 删除一个实体
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        public int Delete(string id)
        {
            using (DBContainer db = new DBContainer())
            {
                var entity = db.SysSample.SingleOrDefault(p => p.Id.Equals(id));
                if (entity != null)
                {
                    db.SysSample.DeleteObject(entity);
                }
                return db.SaveChanges();
            }
        }
        /// <summary>
        /// 更新一个实体
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public int Edit(Entity.SysSample entity)
        {
            using (DBContainer db = new DBContainer())
            {
                db.SysSample.Attach(entity);
                db.ObjectStateManager.ChangeObjectState(entity, EntityState.Modified);
                return db.SaveChanges();
            }
        }
        /// <summary>
        /// 获取一个实体
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        public Entity.SysSample GetById(string id)
        {
            using (DBContainer db = new DBContainer())
            {
                return db.SysSample.SingleOrDefault(p => p.Id.Equals(id));
            }
        }
        /// <summary>
        /// 实体是否存在
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        public bool IsExist(string id)
        {
            SysSample entity = GetById(id);
            if (entity != null)
                return true;
            return false;

        }
        /// <summary>
        /// 执行与释放或重置非托管资源相关的应用程序定义的任务。
        /// </summary>
        public void Dispose()
        {

        }
    }
}
