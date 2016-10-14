using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public abstract class BaseFactory
    {
        public abstract IRace CreateFirst();
        public abstract IRace CreateSecond();
        public abstract IRace CreateThird();
        public abstract IRace CreateFourth();
    }
}
