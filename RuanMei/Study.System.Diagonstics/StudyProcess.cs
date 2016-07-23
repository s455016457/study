using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.System.Diagnostics
{
    /// <summary>
    /// 提供对本地和远程进程的访问权限并使你能够启动和停止本地系统进程。
    /// </summary>
    public class StudyProcess
    {
        /// <summary>
        /// 关机
        /// </summary>
        /// <returns></returns>
        public void CloseWindow()
        {
            using (Process myProcess = new Process())
            {

                try
                {
                    //获取或设置一个值，该值指示是否使用操作系统 shell 启动进程。
                    //如果应在启动进程时使用 shell，则为 true；如果直接从可执行文件创建进程，则为 false。 默认值为 true。
                    myProcess.StartInfo.UseShellExecute = false;

                    //获取或设置要启动的应用程序或文档。
                    //要启动的应用程序的名称或某文件类型的文档的名称，该文件类型与应用程序关联并且拥有可用的默认打开操作。 默认值为空字符串 ("")。
                    myProcess.StartInfo.FileName = "shutdown"; 

                    //获取或设置启动应用程序时要使用的一组命令行参数。
                    //特定文件类型的参数，系统可将它们与 System.Diagnostics.ProcessStartInfo.FileName 属性中指定的应用程序相关联。
                    myProcess.StartInfo.Arguments = "/s /t 120";//两分钟后自动关闭

                    //获取或设置指示是否在新窗口中启动该进程的值。
                    //如果应启动该进程而不创建包含它的新窗口，则为 true；否则为 false。 默认值为 false。
                    myProcess.StartInfo.CreateNoWindow = true;

                    // 启动（或重用）此 System.Diagnostics.Process 组件的 System.Diagnostics.Process.StartInfo
                    // 属性指定的进程资源，并将其与该组件关联。
                    // 如果启动了进程资源，则为 true；如果没有启动新的进程资源（例如，如果重用了现有进程），则为 false。
                    myProcess.Start();
                    myProcess.WaitForExit();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        /// <summary>
        /// 取消关机
        /// </summary>
        /// <returns></returns>
        public void UnCloseWindow()
        {
            using (Process myProcess = new Process())
            {
                try
                {
                    //获取或设置一个值，该值指示是否使用操作系统 shell 启动进程。
                    //如果应在启动进程时使用 shell，则为 true；如果直接从可执行文件创建进程，则为 false。 默认值为 true。
                    myProcess.StartInfo.UseShellExecute = false;

                    //获取或设置要启动的应用程序或文档。
                    //要启动的应用程序的名称或某文件类型的文档的名称，该文件类型与应用程序关联并且拥有可用的默认打开操作。 默认值为空字符串 ("")。
                    myProcess.StartInfo.FileName = "shutdown"; 

                    //获取或设置启动应用程序时要使用的一组命令行参数。
                    //特定文件类型的参数，系统可将它们与 System.Diagnostics.ProcessStartInfo.FileName 属性中指定的应用程序相关联。
                    myProcess.StartInfo.Arguments = "/a";//取消关机

                    //获取或设置指示是否在新窗口中启动该进程的值。
                    //如果应启动该进程而不创建包含它的新窗口，则为 true；否则为 false。 默认值为 false。
                    myProcess.StartInfo.CreateNoWindow = true;

                    // 启动（或重用）此 System.Diagnostics.Process 组件的 System.Diagnostics.Process.StartInfo
                    // 属性指定的进程资源，并将其与该组件关联。
                    // 如果启动了进程资源，则为 true；如果没有启动新的进程资源（例如，如果重用了现有进程），则为 false。
                    myProcess.Start();
                    myProcess.WaitForExit();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
