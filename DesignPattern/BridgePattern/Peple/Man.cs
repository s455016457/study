using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Man:AbstractPeple
    {
        public override void Drive()
        {
            Console.Write("男人开");
        }
    }
}
