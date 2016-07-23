using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistorPattern
{
    public abstract class StudentFree:Student
    {
        public int Free;
        public override void GetVideo()
        {
            Console.WriteLine("这里是{0}，{1}", QQ, Name);
            Console.WriteLine("需要视频");
            Console.WriteLine("这里是普通学员，需要暗号{0}",Free);
        }
    }
}
