
using System;

namespace 抽象类
{

    abstract class TrafficTools
    {
        public abstract void Transport();

    }

    class Bus : TrafficTools
    {
        public override void Transport()
        {
            Console.WriteLine(typeof(Bus));
        }
    }

    class Bike : TrafficTools
    {
        public override void Transport()
        {
            Console.WriteLine(typeof(Bike));
        }
    }

}
