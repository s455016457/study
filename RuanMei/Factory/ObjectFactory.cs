using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public static class ObjectFactory
    {
        static ObjectFactory() { }
        /// <summary>
        /// 实例化对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T CreateObject<T>() where T : new()
        {
            return new T();
        }

        public static object CreateObject(String classNamePath, String assemblyRef, params object[] activationAttributes)
        {
            return Activator.CreateInstance(assemblyRef, classNamePath, activationAttributes).Unwrap();
        }

        /// <summary>
        /// 反射创建对象
        /// </summary>
        /// <param name="type">对象的类型</param>
        /// <returns></returns>
        public static Object CreatedObject(Type type, params object[] objects)
        {
            return Activator.CreateInstance(type, objects);
        }

        /// <summary>
        /// 反射创建对象
        /// </summary>
        /// <typeparam name="T">对象</typeparam>
        /// <returns></returns>
        public static T CreatedObject<T>()
        {
            return Activator.CreateInstance<T>();
        }

        public static IEnumerable<Object> Createdobject(String assemblyRef)
        {
            try
            {
                var assembly = Assembly.Load(assemblyRef);
                foreach (var type in assembly.GetTypes())
                {
                    if (type.IsClass)
                    {
                        //获取无参数的构造函数
                        var contsturctor = type.GetConstructor(new Type[] { });
                        if (type.IsAbstract || contsturctor == null) continue;
                        yield return Activator.CreateInstance(type, true);
                    }
                }
            }
            finally { }
        }

        public static IEnumerable<Object> CreatedobjectByFullPath(String assemblyRef)
        {
            try
            {
                var assembly = Assembly.LoadFile(assemblyRef);
                foreach (var type in assembly.GetTypes())
                {
                    if (type.IsClass)
                    {
                        //获取无参数的构造函数
                        var contsturctor = type.GetConstructor(new Type[] { });
                        if (type.IsAbstract || contsturctor == null) continue;
                        yield return Activator.CreateInstance(type, true);
                    }
                }
            }
            finally { }
        }
    }
}
