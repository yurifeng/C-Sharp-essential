using System;

namespace 枚举类
{
    public class Program
    {
        private static void Main()
        {
            //Console.WriteLine(Season.Spring.GetType());

            Season s = Season.Spring;

            //枚举可以使用int类型的加法
            Console.WriteLine(s + 2);

            //枚举类型可以被转化为int类型
            Console.WriteLine((int)s);

            Console.WriteLine((int)Season.Summer);
            Console.WriteLine((int)Season.Autumn);
            Console.WriteLine((int)Season.Winter);

        }
    }

    /// <summary>
    /// 枚举可以使用int类型的加法
    /// 枚举的值就是整形
    /// </summary>
    public enum Season
    {

        Spring,//0
        Summer,//1
        Autumn,//2
        Winter//3
    }


}
