using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBusiness.Interface;
using IService.Common;

namespace UnityService
{
    public static class UnityService
    {
        private static IUnityContainer _unity;
        private static object lock_obj = new object();

        public static void Start() {
            if (_unity == null)
            {
                lock (lock_obj)
                {
                    if (_unity == null)
                    {
                        _unity = new UnityContainer();
                        RegisterType();
                    }
                }
            }
        }

        public static IUnityContainer GetUnity()
        {
            return _unity;
        }
        
        private static void RegisterType()
        {
            _unity.RegisterType<IBusiness.Interface.Purchase.IPoBusiness, Business.Purchase.PoBusiness>(new InjectionConstructor(SqlServerContextService.GetContext()));//使用一个参数的构造函数实例化对象，并传入指定参数
            _unity.RegisterType<IService.Interface.Purchase.IPOService, Service.Purchase.PoService>();
        }
    }
}
