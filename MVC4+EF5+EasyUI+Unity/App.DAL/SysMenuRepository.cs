#region CopyRight
/**************************************************************
   Copyright (c) 2015 shipengfei. All rights reserved.
   CLR版本        :    4.0.30319.34209
   命名空间名称   :    App.DAL
   文件名         :    SysMenusRepository
   创建时间       :    2015-11-26 17:00:42
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
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace App.DAL
{
    public class SysMenuRepository : ISysMenuRepository
    {
        #region 系统功能
        /// <summary>
        /// 获取系统功能列表
        /// </summary>
        /// <param name="db">数据上下文</param>
        /// <returns>系统功能</returns>
        public IQueryable<Entity.SysFunction> GetSysFunctionList(DBContainer db)
        {
            return db.SysFunction.AsQueryable<Entity.SysFunction>();
        }

        /// <summary>
        /// 新增系统功能
        /// </summary>
        /// <param name="entity">系统功能</param>
        /// <returns></returns>
        public int CreateSysFunction(Entity.SysFunction entity)
        {
            using (DBContainer db = new DBContainer())
            {
                db.SysFunction.AddObject(entity);
                return db.SaveChanges();
            }
        }

        /// <summary>
        /// 删除系统功能
        /// </summary>
        /// <param name="id">系统功能Id</param>
        /// <returns></returns>
        public int DeleteSysFunction(string id)
        {
            using (DBContainer db = new DBContainer())
            {
                var entity = db.SysFunction.SingleOrDefault(p => p.SysFunction_Id.Equals(id,StringComparison.CurrentCultureIgnoreCase));

                if (entity != null)
                    db.SysFunction.DeleteObject(entity);

                return db.SaveChanges();
            }
        }

        /// <summary>
        /// 更新系统功能
        /// </summary>
        /// <param name="entity">系统功能</param>
        /// <returns></returns>
        public int EditSysFunction(Entity.SysFunction entity)
        {
            using (DBContainer db = new DBContainer())
            {
                db.SysFunction.Attach(entity);
                db.ObjectStateManager.ChangeObjectState(entity, EntityState.Modified);
                return db.SaveChanges();
            }
        }

        /// <summary>
        /// 获取系统功能
        /// </summary>
        /// <param name="id">系统功能Id</param>
        /// <returns></returns>
        public Entity.SysFunction GetSysFunctionById(string id)
        {
            using (DBContainer db = new DBContainer())
            {
                return db.SysFunction.SingleOrDefault(p => p.SysFunction_Id.Equals(id, StringComparison.CurrentCultureIgnoreCase));
            }
        }

        /// <summary>
        /// 系统功能是否已存在
        /// </summary>
        /// <param name="id">系统功能Id</param>
        /// <returns></returns>
        public bool SysFunctionIsExist(string id)
        {
            return GetSysFunctionById(id) != null;
        }
        #endregion

        #region 菜单组
        /// <summary>
        /// 获取菜单组列表
        /// </summary>
        /// <param name="db">数据上下文</param>
        /// <returns></returns>
        public IQueryable<MenuGroup> GetMenuGroupList(DBContainer db)
        {
            return db.MenuGroup.AsQueryable<MenuGroup>();
        }

        /// <summary>
        /// 创建菜单组
        /// </summary>
        /// <param name="entity">菜单组</param>
        /// <returns></returns>
        public int CreateMenuGroup(MenuGroup entity)
        {
            using (DBContainer db = new DBContainer())
            {
                db.MenuGroup.AddObject(entity);
                return db.SaveChanges();
            }
        }

        /// <summary>
        /// 删除菜单组
        /// </summary>
        /// <param name="id">菜单组Id</param>
        /// <returns></returns>
        public int DeleteMenuGroup(string id)
        {
            using (DBContainer db = new DBContainer())
            {
                var entity = db.MenuGroup.SingleOrDefault(p => p.MenuGroup_Id.Equals(id, StringComparison.CurrentCultureIgnoreCase));

                if (entity != null)
                    db.MenuGroup.DeleteObject(entity);
                
                return db.SaveChanges();
            }
        }

        /// <summary>
        /// 更新菜单组
        /// </summary>
        /// <param name="entity">菜单组</param>
        /// <returns></returns>
        public int EditMenuGroup(MenuGroup entity)
        {
            using (DBContainer db = new DBContainer())
            {
                db.MenuGroup.Attach(entity);
                db.ObjectStateManager.ChangeObjectState(entity, EntityState.Modified);
                return db.SaveChanges();
            }
        }

        /// <summary>
        /// 获取菜单组
        /// </summary>
        /// <param name="id">菜单组Id</param>
        /// <returns></returns>
        public MenuGroup GetMenuGroupById(string id)
        {
            using (DBContainer db = new DBContainer())
            {
                return db.MenuGroup.SingleOrDefault(p => p.MenuGroup_Id.Equals(id, StringComparison.CurrentCultureIgnoreCase));
            }
        }

        /// <summary>
        /// 菜单组是否已存在
        /// </summary>
        /// <param name="id">菜单组Id</param>
        /// <returns></returns>
        public bool MenuGroupIsExist(string id)
        {
            return GetMenuGroupById(id) != null;
        }
        #endregion

        #region 菜单
        /// <summary>
        /// 获取菜单列表
        /// </summary>
        /// <param name="db">数据上下文</param>
        /// <returns></returns>
        public IQueryable<Menu> GetMenuList(DBContainer db)
        {
            return db.Menu.AsQueryable<Menu>();
        }

        /// <summary>
        /// 创建菜单
        /// </summary>
        /// <param name="entity">菜单</param>
        /// <returns></returns>
        public int CreateMenu(Menu entity)
        {
            using (DBContainer db = new DBContainer())
            {
                db.Menu.AddObject(entity);
                return db.SaveChanges();
            }
        }
        
        /// <summary>
        /// 删除菜单
        /// </summary>
        /// <param name="id">菜单Id</param>
        /// <returns></returns>
        public int DeleteMenu(string id)
        {
            using (DBContainer db = new DBContainer())
            {
                var entity = db.Menu.SingleOrDefault(p => p.Menu_Id.Equals(id, StringComparison.CurrentCultureIgnoreCase));

                if (entity != null)
                    db.Menu.DeleteObject(entity);

                return db.SaveChanges();
            }
        }

        /// <summary>
        /// 更新菜单
        /// </summary>
        /// <param name="entity">菜单</param>
        /// <returns></returns>
        public int EditMenu(Menu entity)
        {
            using (DBContainer db = new DBContainer())
            {
                db.Menu.Attach(entity);
                db.ObjectStateManager.ChangeObjectState(entity, EntityState.Modified);
                return db.SaveChanges();
            }
        }

        /// <summary>
        /// 获取菜单
        /// </summary>
        /// <param name="id">菜单Id</param>
        /// <returns></returns>
        public Menu GetMenuById(string id)
        {
            using (DBContainer db = new DBContainer())
            {
                return db.Menu.SingleOrDefault(p => p.Menu_Id.Equals(id, StringComparison.CurrentCultureIgnoreCase));
            }
        }

        /// <summary>
        /// 菜单是否已存在
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool MenuIsExist(string id)
        {
            return GetMenuById(id) != null;
        }
        #endregion
    }
}

