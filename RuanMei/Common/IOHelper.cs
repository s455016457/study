using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class IOHelper
    {
        private static IOHelper iOHelper;
        private static Object lock_object = new Object();

        private IOHelper() { }

        public static IOHelper Create()
        {
            if (iOHelper == null)
            {
                lock (lock_object)
                {
                    if (iOHelper == null)
                    {
                        iOHelper = new IOHelper();
                    }
                }
            }
            return iOHelper;
        }

        /// <summary>
        /// 读取文件
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public IEnumerable<String> ReadText(String path)
        {
            return File.ReadLines(path);
        }
    }
}
