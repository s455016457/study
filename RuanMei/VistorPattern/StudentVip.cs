using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistorPattern
{
    public class StudentVip : Student
    {
        private DateTime VipTime;
        public override void GetVideo()
        {
            Console.WriteLine("这里是{0}，{1}", QQ, Name);
            Console.WriteLine("需要视频");
            Console.WriteLine("这里是VIP学员，可以免费学习");
        }
    }
}
