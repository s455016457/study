using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Street:AbstractRoad
    {
        public override void Run()
        {
            if (car != null)
                car.Run();
            Console.WriteLine("市区公路上行驶");
        }
    }
}
