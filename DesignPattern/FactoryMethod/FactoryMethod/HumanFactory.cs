using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class HumanFactory:IFactoryMethod
    {
        public IRace CreateInstance()
        {
            Console.WriteLine("在这里创建一个human");
            Console.WriteLine("我可以在这里使用反射去创建");
            Console.WriteLine("我还可以在这里添加很多其他的逻辑");
            return new Human();
        }
    }
}
