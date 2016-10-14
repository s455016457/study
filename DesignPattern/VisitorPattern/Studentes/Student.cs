using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public abstract class Student
    {
        /// <summary>
        /// 学生ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 学生名册
        /// </summary>
        public String Name { get; set; }
        /// <summary>
        /// 报名时间
        /// </summary>
        public DateTime RegistrationTime { get; set; }

        public abstract void GetVideo();
    }
}
