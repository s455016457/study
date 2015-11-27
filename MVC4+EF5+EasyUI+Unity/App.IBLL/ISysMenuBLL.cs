#region CopyRight
/**************************************************************
   Copyright (c) 2015 shipengfei. All rights reserved.
   CLR版本        :    4.0.30319.34209
   命名空间名称   :    App.IBLL
   文件名         :    ISysMenusBLL
   创建时间       :    2015-11-26 17:44:06
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
using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.IBLL
{
    public interface ISysMenuBLL
    {
        #region 系统功能
        /// <summary>
        /// 获取系统功能列表
        /// </summary>
        /// <param name="queryStr">搜索条件</param>
        /// <param name="sort">排序</param>
        /// <returns>系统功能列表</returns>
        List<SysFunction> GetSysFounctionList(String queryStr,Sort sort);
        /// <summary>
        /// 获取系统功能列表
        /// </summary>
        /// <param name="queryStr">搜索条件</param>
        /// <param name="pager">JQgrid分页</param>
        /// <returns>系统功能列表</returns>
        List<SysFunction> GetSysFounctionListPager(String queryStr, ref GridPager pager);
        /// <summary>
        /// 根据ID获得一个系统功能
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>获得一个系统功能</returns>
        SysFunction GetSysFounctionById(String Id);
        /// <summary>
        /// 判断是否存在系统功能
        /// </summary>
        /// <param name="id">系统功能ID</param>
        /// <returns>是否存在</returns>
        bool SysFounctionIsExist(String Id);
        #endregion

        #region 菜单组
        /// <summary>
        /// 获取菜单组列表
        /// </summary>
        /// <param name="queryStr">搜索条件</param>
        /// <param name="sort">排序</param>
        /// <returns>菜单组列表</returns>
        List<MenuGroup> GetMenuGroupList(String queryStr, Sort sort);
        /// <summary>
        /// 获取菜单组列表
        /// </summary>
        /// <param name="queryStr">搜索条件</param>
        /// <param name="pager">JQgrid分页</param>
        /// <returns>菜单组列表</returns>
        List<MenuGroup> GetMenuGroupListPager(String queryStr, ref GridPager pager);
        /// <summary>
        /// 根据ID获得菜单组
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>菜单组</returns>
        MenuGroup GetMenuGroupById(String Id);
        /// <summary>
        /// 判断是否存在菜单组
        /// </summary>
        /// <param name="id">菜单组ID</param>
        /// <returns>是否存在</returns>
        bool MenuGroupIsExist(String Id);
        #endregion

        #region 菜单
        /// <summary>
        /// 获取菜单列表
        /// </summary>
        /// <param name="queryStr">搜索条件</param>
        /// <param name="sort">排序</param>
        /// <returns>菜单列表</returns>
        List<Menu> GetMenuList(String queryStr, Sort sort);
        /// <summary>
        /// 获取菜单列表
        /// </summary>
        /// <param name="queryStr">搜索条件</param>
        /// <param name="pager">JQgrid分页</param>
        /// <returns>菜单列表</returns>
        List<Menu> GetMenuListPager(String queryStr, ref GridPager pager);
        /// <summary>
        /// 根据ID获得菜单
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>菜单</returns>
        Menu GetMenuById(String Id);
        /// <summary>
        /// 判断是否存在菜单
        /// </summary>
        /// <param name="id">菜单ID</param>
        /// <returns>是否存在</returns>
        bool MenuIsExist(String Id);
        #endregion
    }
}

