using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// 下端
    /// </summary>
    public class NE : IRace
    {
        public void ShowKing()
        {
            Console.WriteLine("The king of NE is Moon");
        }
    }
}
