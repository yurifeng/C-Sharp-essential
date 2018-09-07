using System;

namespace 运算符的重载
{
    class Point
    {
        public double X;
        public double Y;

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// 运算符重载,使+号具有新的功能
        /// 可以实现2个新的Point对象直接相加,得到一个新的点
        /// 必须的:访问权限是Public
        ///       静态的Static
        /// </summary>
        /// <param name="p1">点1</param>
        /// <param name="p2">点2</param>
        /// <returns>返回新的Point</returns>
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }

        /// <summary>
        /// 减法可以只写一个参数
        /// </summary>
        /// <param name="p1"></param>
        /// <returns></returns>
        public static Point operator -(Point p1)
        {
            return new Point(1, 1);
        }

        /// <summary>
        /// 两点的坐标相乘
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static Point operator *(Point p1, Point p2)
        {
            return new Point(p1.X * p2.X, p1.Y * p2.Y);
        }

        /// <summary>
        /// 点的横纵坐标都加上一个int类型的整数
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Point operator +(Point p1, int a)
        {
            return new Point(p1.X + a, p1.Y + a);
        }

        /// <summary>
        /// int类型的在前面和点Point相加
        /// </summary>
        /// <param name="a"></param>
        /// <param name="p1"></param>
        /// <returns></returns>
        public static Point operator +(int a, Point p1)
        {
            return new Point(a + p1.X, a + p1.Y);
        }
    }

    class Program
    {
        static void Main()
        {
            Point p1 = new Point(10, 20);
            Point p2 = new Point(100, 200);

            //Point p3 = p1 + p2;
            //Console.WriteLine(p3.X + " " + p3.Y);

            //Point p3 = p1 * p2;
            //Console.WriteLine(p3.X + " " + p3.Y);

            Point p4 = 3 + p1;
            Console.WriteLine(p4.X + " " + p4.Y);
        }
    }
}
