using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class ZhenSanFactory : BaseFactory
    {
        public override IRace CreateFirst()
        {
            return new Wei();
        }

        public override IRace CreateSecond()
        {
            return new Shu();
        }

        public override IRace CreateThird()
        {
            return new Wu();
        }

        public override IRace CreateFourth()
        {
            return new Qun();
        }
    }
}
