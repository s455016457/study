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

        public Boolean CopyFile(String SourcePath, String TargetPath)
        {
            if (!File.Exists(SourcePath))
            {
                throw new Exception("文件不存在");
            }

            if (!Directory.Exists(TargetPath))
            {
                Directory.CreateDirectory(TargetPath);
            }
            var fileName = Path.GetFileName(SourcePath);
            var TargetPathChars = TargetPath.ToArray();
            TargetPath = TargetPath + (TargetPathChars[TargetPathChars.Count()-1] == '/' || TargetPathChars[TargetPathChars.Count()-2] == '\\' ? fileName : "\\" + fileName);
            File.Copy(SourcePath, TargetPath, true);
            return true;
        }
    }
}
