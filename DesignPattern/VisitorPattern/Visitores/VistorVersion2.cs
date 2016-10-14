using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class VistorVersion2:IVistor
    {
        private Student _student;
        public void Accept(Student student)
        {
            _student = student;
        }

        public void GetVideo()
        {
            if (_student.RegistrationTime < DateTime.Parse("2015-01-01") && _student is StudentFree)
            {
                Console.WriteLine("2015-01-01前的普通学员【{0}】注册时间【{1}】不能获取视频", _student.Name, _student.RegistrationTime.ToString("yyyy-MM-dd"));
            }
            else if (_student.RegistrationTime < DateTime.Parse("2015-01-01") && _student is StudentVip)
            {
                Console.WriteLine("2015-01-01前的VIP学员【{0}】注册时间【{1}】不能获取视频", _student.Name, _student.RegistrationTime.ToString("yyyy-MM-dd"));
            }
            else
            {
                _student.GetVideo();
            }
        }
    }
}
