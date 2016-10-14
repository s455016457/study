using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class MySQLHelper : ISqlHelper
    {
        public void Add()
        {
            Console.WriteLine("这里是{0}的Add", this.GetType());
        }

        public void Delete()
        {
            Console.WriteLine("这里是{0}的Delete", this.GetType());
        }

        public void Update()
        {
            Console.WriteLine("这里是{0}的Update", this.GetType());
        }

        public void Search()
        {
            Console.WriteLine("这里是{0}的Search", this.GetType());
        }
    }
}
