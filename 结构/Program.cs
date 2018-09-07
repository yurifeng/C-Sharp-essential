using System;

namespace 结构
{
    class Program
    {
        public static void Main()
        {
            Point p = new Point
            {
                X = 10,
                Y = 20
            };
            Change(ref p);
            Console.WriteLine(p.X);
            Console.WriteLine(p.Y);
        }

        /// <summary>
        /// 1.结构是值类型的,这里的结果不影响上面的引用类型的对象的值
        /// 2.添加ref变成引用类型
        /// </summary>
        /// <param name="point"></param>
        private static void Change(ref Point point)
        {
            point.X = 100;
            point.Y = 200;
        }
    }

    /// <summary>
    /// 3.结构体拥有字段,属性,方法,访问修饰符,可以new实例化对象
    /// 4.结构体的对象是在栈上(结构体是值类型,不是引用类型)
    /// 7.结构体中不能写析构方法
    /// 8.结构体只有一个父类是Object(结构体不能继承其他)
    /// </summary>
    public struct Point
    {

        //5.结构体中始终就有无参构造,不用显示的声明结构的构造方法
        //public Point()
        //{

        //}

        /// <summary>
        /// 6.结构的有参构造方法中,必须要给所有的字段赋值
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point(double x, double y)
        {
            Y = y;
            X = x;
        }

        public double X { set; get; }

        public double Y { set; get; }

        public static int A;

        static Point()
        {

        }

        public void Test()
        {

        }


    }


}
