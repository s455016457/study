using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class SpeedWay : AbstractRoad
    {
        public override void Run()
        {
            if (car != null)
                car.Run();

            Console.WriteLine("高速公路上行驶");
        }
    }
}
