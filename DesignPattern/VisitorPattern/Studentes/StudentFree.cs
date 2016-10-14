using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class StudentFree:Student
    {
        public override void GetVideo()
        {
            Console.WriteLine("普通学生【{0}】注册时间【{1}】获取公开课视频", Name, RegistrationTime.ToString("yyyy-MM-dd"));
        }
    }
}
