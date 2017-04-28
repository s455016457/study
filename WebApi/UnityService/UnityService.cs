using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    }
                }
            }
        }

        public static IUnityContainer GetUnity()
        {
            return _unity;
        }

        public static void RegisterType()
        {

        }
    }
}
