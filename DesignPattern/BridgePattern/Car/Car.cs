using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Car:AbstractCar
    {
        public override void Run()
        {
            if (peple != null)
                peple.Drive();
            Console.Write("小汽车在");
        }
    }
}
