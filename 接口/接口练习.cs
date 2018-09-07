
using System;

namespace 接口
{
    interface IHouseService
    {
        void Clean();
        void Wash();
        void Cook();
    }

    class Person
    {
        public string Name;

        public void LetDo()
        {
            //Robot robot = new Robot();

            //将实现类型转型为接口类型,(只要实现了接口,就能这么写)
            //向上转型,由实现类型转型为接口类型
            IHouseService i = new Robot();
            IHouseService ii = new GirlFriend();
            IHouseService iii = new Baomu();
            ITakecareService iiii = new GirlFriend();

            //向下转型
            Robot robot = (Robot)i;
            GirlFriend g = (GirlFriend)iiii;

        }
    }

    class Baomu : Person, IHouseService
    {
        public void Clean()
        {
            Console.WriteLine(Name + "清洗....");
        }

        public void Wash()
        {
            Console.WriteLine(Name + "洗衣服.....");
        }

        public void Cook()
        {
            Console.WriteLine(Name + "煮饭.....");
        }
    }

    class Robot : IHouseService
    {
        public void Clean()
        {

        }

        public void Wash()
        {

        }

        public void Cook()
        {

        }
    }

    interface ITakecareService
    {
        void Cook();
        void WarmBed();
        void SingSong();
    }

    class GirlFriend : Person, IHouseService, ITakecareService
    {
        public void Clean()
        {

        }

        public void Wash()
        {
        }

        //void IHouseService.Cook()
        //{
        //}

        public void WarmBed()
        {
        }

        public void SingSong()
        {
        }

        //void ITakecareService.Cook()
        //{
        //}

        /// <summary>
        /// 写一个Cook方法也阔以
        /// </summary>
        public void Cook()
        {

        }
    }
}
