using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class Human :IRace
    {
        public void ShowKing()
        {
            Console.WriteLine("The king of Human is Sky");
        }
    }
}
