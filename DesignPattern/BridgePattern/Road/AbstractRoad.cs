using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public abstract class AbstractRoad
    {
        protected AbstractCar car;
        public AbstractCar Car { set { car = value; } }

        public abstract void Run();
    }
}
