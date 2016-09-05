using FactoryMethodPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.TestFiles
{
    public class TestFactoryMethod:TestBase
    {
        public override void Test(Action<Task[]> callBack)
        {
            IFactoryMethod factory = new HumanFactory();
            IRace race = factory.CreateInstance();
            race.ShowKing();
            callBack.Invoke(null);
        }
    }
}
