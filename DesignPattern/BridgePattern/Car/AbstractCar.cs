using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public abstract class AbstractCar
    {
        protected AbstractPeple peple;
        public AbstractPeple Peple { set{peple=value; } }

        public abstract void Run();
    }
}
