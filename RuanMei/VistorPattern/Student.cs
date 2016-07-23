using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistorPattern
{
    public abstract class Student
    {
        public long QQ{get;set;}
        public String Name { get; set; }

        public abstract void GetVideo();
    }
}
