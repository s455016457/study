using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class XiaoMi:IPhone
    {
        public void Call()
        {
            Console.WriteLine("这里是{0}的Call", this.GetType());
        }

        public void Message()
        {
            Console.WriteLine("这里是{0}的Message", this.GetType());
        }
    }
}
