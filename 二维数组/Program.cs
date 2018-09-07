using System;

namespace 二维数组
{
    class Program
    {
        private static void Main()
        {
            //指定数组的长度为10
            int[][] array0 = new int[10][];

            //常用的二维数组的初始化
            int[][] array1 =
            {
                new[] {1, 2, 4, 5},
                new[] {4, 6, 87, 889},
            };

            //打印数组的长度,结果为2(具体看初始化中有多少个new)
            Console.WriteLine(array1.Length.ToString());

            //将新数组赋值给array1的第一位
            //array1[0] = new[] { 3, 3, 3, 3 };

            //打印array1的第一位元素(依然是数组)
            //foreach (int i in array1[0])
            //{
            //    Console.WriteLine(i);
            //}

            //两次遍历打印出二维数组的全部内容
            //foreach (int[] ints in array1)
            //{
            //    foreach (int i in ints)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //显示的是该二维数组中第二个元素的第三个元素
            Console.WriteLine(array1[1][2]);
        }
    }
}
