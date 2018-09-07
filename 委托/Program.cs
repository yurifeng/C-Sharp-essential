using System;

namespace 委托
{
    public delegate int TestDelegate(int x, int y);

    class Program
    {
        public static void Main(string[] args)
        {
            #region 普通方法

            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //if (x > y)
            //{
            //    int add = Add(x, y);
            //    Console.WriteLine(add);
            //}
            //else if (x < y)
            //{
            //    int minus = Minus(x, y);
            //    Console.WriteLine(minus);
            //}

            #endregion

            #region 简单的委托方法

            //实例化delegate对象
            //TestDelegate testDelegate = new TestDelegate(Add);
            TestDelegate testDelegate = Add;

            //delegate的实例对象就是一个方法
            //获取返回值
            int @delegate = testDelegate(100, 200);
            Console.WriteLine(@delegate);

            #endregion
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Minus(int x, int y)
        {
            return x - y;
        }
    }
}