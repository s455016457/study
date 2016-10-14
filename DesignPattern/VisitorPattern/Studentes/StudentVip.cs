using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class StudentVip : Student
    {
        public override void GetVideo()
        {
            Console.WriteLine("VIP学生【{0}】注册时间【{1}】获取全部视频", Name, RegistrationTime.ToString("yyyy-MM-dd"));
        }
    }
}
