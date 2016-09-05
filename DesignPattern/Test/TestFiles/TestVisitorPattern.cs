using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern;

namespace Test
{
    public class TestVisitorPattern:TestBase
    {
        public override void Test(Action<Task[]> callBack)
        {
            List<Student> studentList = GetSutdentes();
            TestVistorVersion1(studentList);
            Console.WriteLine("");
            TestVistorVersion2(studentList);
            callBack.Invoke(null);
        }

        public void TestVistorVersion1(List<Student> studentList)
        {
            Console.WriteLine("*************Begin测试访问者版本1****************");
            IVistor visotr = new VistorVersion1();
            foreach (var student in studentList)
            {
                visotr.Accept(student);
                visotr.GetVideo();
            }
            Console.WriteLine("*************End测试访问者版本1****************");
        }

        public void TestVistorVersion2(List<Student> studentList)
        {
            Console.WriteLine("*************Begin测试访问者版本2****************");
            IVistor visotr = new VistorVersion2();
            foreach (var student in studentList)
            {
                visotr.Accept(student);
                visotr.GetVideo();
            }
            Console.WriteLine("*************End测试访问者版本2****************");
        } 

        private List<Student> GetSutdentes()
        {
            var studentes = new List<Student>();
            studentes.Add(new StudentFree()
            {
                ID = 1,
                Name = "普通学员1",
                RegistrationTime = DateTime.Now
            });
            studentes.Add(new StudentFree()
            {
                ID = 2,
                Name = "普通学员2",
                RegistrationTime = DateTime.Parse("2015-01-01")
            });
            studentes.Add(new StudentFree()
            {
                ID = 3,
                Name = "普通学员3",
                RegistrationTime = DateTime.Parse("2014-01-01")
            });
            studentes.Add(new StudentFree()
            {
                ID = 4,
                Name = "普通学员4",
                RegistrationTime = DateTime.Parse("2013-01-01")
            });
            studentes.Add(new StudentFree()
            {
                ID = 5,
                Name = "普通学员5",
                RegistrationTime = DateTime.Parse("2012-01-01")
            });

            studentes.Add(new StudentVip()
            {
                ID = 1,
                Name = "VIP学员1",
                RegistrationTime = DateTime.Now
            });
            studentes.Add(new StudentVip()
            {
                ID = 2,
                Name = "VIP学员2",
                RegistrationTime = DateTime.Parse("2015-01-01")
            });
            studentes.Add(new StudentVip()
            {
                ID = 3,
                Name = "VIP学员3",
                RegistrationTime = DateTime.Parse("2014-01-01")
            });
            studentes.Add(new StudentVip()
            {
                ID = 4,
                Name = "VIP学员4",
                RegistrationTime = DateTime.Parse("2013-01-01")
            });
            studentes.Add(new StudentVip()
            {
                ID = 5,
                Name = "VIP学员5",
                RegistrationTime = DateTime.Parse("2012-01-01")
            });

            return studentes;
        }
    }
}
