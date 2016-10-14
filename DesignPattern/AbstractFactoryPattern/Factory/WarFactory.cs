using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class WarFactory : BaseFactory
    {
        public override IRace CreateFirst()
        {
            return new Human();
        }

        public override IRace CreateSecond()
        {
            return new NE();
        }

        public override IRace CreateThird()
        {
            return new Orc();
        }

        public override IRace CreateFourth()
        {
            return new Undead();
        }
    }
}
