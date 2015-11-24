#region CopyRight
/**************************************************************
   Copyright (c) 2015 StarPeng. All rights reserved.
   CLR版本        :    4.0.30319.34209
   命名空间名称   :    App.Core
   文件名         :    UnityDependencyResolver
   创建时间       :    2015-11-24 15:59:13
   用户所在的域   :    SHIPENGFEI
   登录用户名     :    Administrator
   文件描述       :    
   版本           :    1.0.0
   历史           :    
   最后更新人     :   
   最后更新时间   :   
 **************************************************************/
#endregion CopyRight

using System;
using System.Collections.Generic;
using Microsoft.Practices.Unity;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web;

namespace App.Core
{
    /// <summary>
    /// 统一的依赖解析器
    /// 实现IDependencyResolver接口(定义可简化服务位置和依赖关系解析的方法)
    /// </summary>
    public class UnityDependencyResolver : IDependencyResolver
    {

        private const string HttpContextKey = "perRequestContainer";

        /// <summary>
        /// 定义统一依赖注入容器的行为的接口。
        /// </summary>
        private readonly IUnityContainer _container;

        /// <summary>
        /// 统一的依赖解析器
        /// </summary>
        /// <param name="container">统一容器</param>
        public UnityDependencyResolver(IUnityContainer container)
        {
            _container = container;
        }

        /// <summary>
        /// 解析支持任意对象创建的一次注册的服务
        /// </summary>
        /// <param name="serviceType">所请求的服务或对象的类型</param>
        /// <returns>请求的服务或对象</returns>
        public object GetService(Type serviceType)
        {
            if (typeof(IController).IsAssignableFrom(serviceType))
            {
                //解析来自容器的默认请求类型的实例
                return ChildContainer.Resolve(serviceType);
            }

            return IsRegistered(serviceType) ? ChildContainer.Resolve(serviceType) : null;
        }

        /// <summary>
        /// 解析多次注册的服务
        /// </summary>
        /// <param name="serviceType">所请求的服务的类型</param>
        /// <returns>请求的服务</returns>
        public IEnumerable<object> GetServices(Type serviceType)
        {
            if (IsRegistered(serviceType))
            {
                //解析来自容器的默认请求类型的实例
                yield return ChildContainer.Resolve(serviceType);
            }

            //返回符合要求的所有已注册类型的返回实例
            foreach (var service in ChildContainer.ResolveAll(serviceType))
            {
                yield return service;
            }
        }

        /// <summary>
        /// 子容器
        /// </summary>
        protected IUnityContainer ChildContainer
        {
            get
            {
                var childContainer = HttpContext.Current.Items[HttpContextKey] as IUnityContainer;

                if (childContainer == null)
                {
                    //将子容器保存在HttpContext.Current中
                    HttpContext.Current.Items[HttpContextKey] = childContainer = _container.CreateChildContainer();
                }

                return childContainer;
            }
        }

        /// <summary>
        /// 释放子容器资源。
        /// </summary>
        public static void DisposeOfChildContainer()
        {
            var childContainer = HttpContext.Current.Items[HttpContextKey] as IUnityContainer;

            if (childContainer != null)
            {
                childContainer.Dispose();
            }
        }
        
        /// <summary>
        /// 对象是否已注册
        /// </summary>
        /// <param name="typeToCheck">对象类型</param>
        /// <returns></returns>
        private bool IsRegistered(Type typeToCheck)
        {
            var isRegistered = true;

            //类型为接口或抽象类
            if (typeToCheck.IsInterface || typeToCheck.IsAbstract)
            {
                //检查某一特定类型是否已注册了容器
                isRegistered = ChildContainer.IsRegistered(typeToCheck);

                //typeToCheck.IsGenericType检查类型是否为泛型
                if (!isRegistered && typeToCheck.IsGenericType)
                {
                    //返回一个表示可用于构造当前泛型类型的泛型类型定义的 System.Type 对象。
                    var openGenericType = typeToCheck.GetGenericTypeDefinition();

                    isRegistered = ChildContainer.IsRegistered(openGenericType);
                }
            }

            return isRegistered;
        }
    }
}
