using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgePattern;

namespace Test
{
    public class TestBridge:TestBase
    {
        public override void Test(Action<Task[]> callBack)
        {
            AbstractPeple man = new Man();
            AbstractPeple woMan = new WoMan();
            AbstractCar car = new Car();
            AbstractCar bus = new Bus();
            AbstractRoad speedWay = new SpeedWay();
            AbstractRoad street = new Street();

            speedWay.Car = car;
            speedWay.Run();
            speedWay.Car = bus;
            speedWay.Run();

            street.Car = car;
            street.Run();
            street.Car = bus;
            street.Run();

            car.Peple = man;
            speedWay.Car = car;
            street.Car = car;
            speedWay.Run();
            street.Run();

            car.Peple = woMan;
            speedWay.Car = car;
            street.Car = car;
            speedWay.Run();
            street.Run();

            bus.Peple = man;
            speedWay.Car = bus;
            street.Car = bus;
            speedWay.Run();
            street.Run();

            bus.Peple = woMan;
            speedWay.Car = bus;
            street.Car = bus;
            speedWay.Run();
            street.Run();

            callBack.Invoke(null);
        }
    }
}
