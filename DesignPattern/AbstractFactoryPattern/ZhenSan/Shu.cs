using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class Shu : IRace
    {

        public void ShowKing()
        {
            Console.WriteLine("The king of Shu is 刘备");
        }
    }
}
