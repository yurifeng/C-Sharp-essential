using System;

namespace 委托进阶2
{

    public delegate int TestDelegate(int x, int y);

    class Program
    {
        /// <summary>
        /// 匿名函数delgegate
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
            #region delegate的匿名方法

            //TestDelegate testDelegate = delegate (int x, int y)
            //{
            //    return x + y;
            //};

            //Console.WriteLine("livir...");
            //Console.WriteLine(testDelegate(10, 10));

            #endregion

            #region lambda表达式

            TestDelegate testDelegate = (x, y) => x + y;
            Console.WriteLine(testDelegate(120, 130));

            #endregion
        }

        //public static int Calc(int x, int y)
        //{
        //    return x + y;
        //}

    }
}
