using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Bus:AbstractCar
    {
        public override void Run()
        {
            if (peple != null)
                peple.Drive();
            Console.Write("巴士在");
        }
    }
}
