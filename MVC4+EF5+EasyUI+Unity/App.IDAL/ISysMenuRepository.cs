#region CopyRight
/**************************************************************
   Copyright (c) 2015 shipengfei. All rights reserved.
   CLR版本        :    4.0.30319.34209
   命名空间名称   :    App.IDAL
   文件名         :    ISysMenusRepository
   创建时间       :    2015-11-26 16:43:29
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
    public interface ISysMenuRepository
    {
        #region 系统功能
        /// <summary>
        /// 获取系统功能列表
        /// </summary>
        /// <param name="db">数据库上下文</param>
        /// <returns>系统功能列表</returns>
        IQueryable<SysFunction> GetSysFunctionList(DBContainer db);
        /// <summary>
        /// 创建一个系统功能
        /// </summary>
        /// <param name="entity">系统功能</param>
        int CreateSysFunction(SysFunction entity);
        /// <summary>
        /// 删除一个系统功能
        /// </summary>
        /// <param name="entity">系统功能ID</param>
        int DeleteSysFunction(string id);

        /// <summary>
        /// 修改一个系统功能
        /// </summary>
        /// <param name="entity">实体</param>
        int EditSysFunction(SysFunction entity);
        /// <summary>
        /// 获得一个系统功能
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>系统功能</returns>
        SysFunction GetSysFunctionById(string id);
        /// <summary>
        /// 判断一个系统功能是否存在
        /// </summary>
        bool SysFunctionIsExist(string id);
        #endregion

        #region 菜单组
        /// <summary>
        /// 获取菜单组列表
        /// </summary>
        /// <param name="db">数据库上下文</param>
        /// <returns>菜单组列表</returns>
        IQueryable<MenuGroup> GetMenuGroupList(DBContainer db);
        /// <summary>
        /// 创建一个菜单组
        /// </summary>
        /// <param name="entity">实体</param>
        int CreateMenuGroup(MenuGroup entity);
        /// <summary>
        /// 删除一个菜单组
        /// </summary>
        /// <param name="entity">菜单组ID</param>
        int DeleteMenuGroup(string id);

        /// <summary>
        /// 修改一个菜单组
        /// </summary>
        /// <param name="entity">菜单组</param>
        int EditMenuGroup(MenuGroup entity);
        /// <summary>
        /// 获得一个菜单组
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>菜单组</returns>
        MenuGroup GetMenuGroupById(string id);
        /// <summary>
        /// 判断一个菜单组是否存在
        /// </summary>
        bool MenuGroupIsExist(string id);
        #endregion

        #region 菜单
        /// <summary>
        /// 获取菜单列表
        /// </summary>
        /// <param name="db">数据库上下文</param>
        /// <returns>菜单列表</returns>
        IQueryable<Menu> GetMenuList(DBContainer db);
        /// <summary>
        /// 创建一个菜单
        /// </summary>
        /// <param name="entity">菜单</param>
        int CreateMenu(Menu entity);
        /// <summary>
        /// 删除一个菜单
        /// </summary>
        /// <param name="entity">菜单ID</param>
        int DeleteMenu(string id);
        /// <summary>
        /// 修改一个菜单
        /// </summary>
        /// <param name="entity">菜单</param>
        int EditMenu(Menu entity);
        /// <summary>
        /// 获得一个菜单
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>菜单</returns>
        Menu GetMenuById(string id);
        /// <summary>
        /// 判断一个菜单是否存在
        /// </summary>
        bool MenuIsExist(string id);
        #endregion
    }
}

