using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;

namespace WebApi
{
    /// <summary>
    /// Unity.WebApi����
    /// </summary>
    public static class UnityConfig
    {
        /// <summary>
        /// ע�����
        /// </summary>
        public static void RegisterComponents()
        {
            UnityService.UnityService.Start();
            var container = UnityService.UnityService.GetUnity();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}