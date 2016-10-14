using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class Wu : IRace
    {

        public void ShowKing()
        {
            Console.WriteLine("The king of Wu is 孙权");
        }
    }
}
