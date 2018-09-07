using System;

namespace 委托进阶
{
    /// <summary>
    /// delegate 委托就是一个方法
    /// </summary>
    public delegate void TestDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            //声明一个委托变量,并且赋值为方法1
            TestDelegate testDelegate = Method1;

            //将方法1覆盖,现在是方法2
            testDelegate = Method2;

            //组合委托(结果就是方法2和方法3)
            testDelegate += Method3;

            //组合-=(消除方法,如果没有绑定方法,则不操作)

            //委托就是方法,所以能写括号来执行
            testDelegate();
        }

        public static void Method1()
        {
            Console.WriteLine("方法1");
        }
        public static void Method2()
        {
            Console.WriteLine("方法2");
        }
        public static void Method3()
        {
            Console.WriteLine("方法3");
        }
        public static void Method4()
        {
            Console.WriteLine("方法4");
        }

    }
}
