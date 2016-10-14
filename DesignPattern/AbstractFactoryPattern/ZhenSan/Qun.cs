using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class Qun : IRace
    {

        public void ShowKing()
        {
            Console.WriteLine("The king of Qun is 张角");
        }
    }
}
