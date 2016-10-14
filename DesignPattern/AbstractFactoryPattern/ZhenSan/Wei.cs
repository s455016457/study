using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class Wei : IRace
    {

        public void ShowKing()
        {
            Console.WriteLine("The king of Wei is 曹操");
        }
    }
}
