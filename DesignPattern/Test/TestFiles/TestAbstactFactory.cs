using AbstractFactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.TestFiles
{
    public class TestAbstactFactory:TestBase
    {
        public override void Test(Action<Task[]> callBack)
        {
            BaseFactory factory = new WarFactory();
            IRace human = factory.CreateFirst();
            human.ShowKing();
            IRace NE = factory.CreateSecond();
            NE.ShowKing();

            BaseFactory sanguoshaFactory = new ZhenSanFactory();
            IRace qun = sanguoshaFactory.CreateFourth();
            qun.ShowKing();
            IRace Shu = sanguoshaFactory.CreateSecond();
            Shu.ShowKing();

            callBack.Invoke(null);
        }
    }
}
