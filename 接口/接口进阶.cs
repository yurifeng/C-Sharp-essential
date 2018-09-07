
using System;

namespace 接口
{


    /// <summary>
    /// 空运接口
    /// </summary>
    public interface ITransportOnAir
    {
        void TransportOnAir();

    }

    /// <summary>
    /// 陆运接口
    /// </summary>
    public interface ITransportOnLand
    {
        void TransportOnLand();
    }



    class Shunfen : ITransportOnAir, ITransportOnLand
    {
        public void TransportOnAir()
        {
            Console.WriteLine("顺丰空运....");
        }

        public void TransportOnLand()
        {
            Console.WriteLine("顺丰陆运....");
        }
    }

    class Yunda : ITransportOnLand
    {

        public void TransportOnLand()
        {
            Console.WriteLine("韵达陆运......");
        }
    }

    class Ems : ITransportOnAir
    {
        public void TransportOnAir()
        {
            Console.WriteLine("EMS空运......");
        }
    }

    class People
    {
        //陆运快递
        public void SendPackageOnLand(ITransportOnLand land)
        {
            land.TransportOnLand();

        }

        //空运快递
        public void SendPackageOnAir(ITransportOnAir air)
        {
            air.TransportOnAir();
        }
    }
}
