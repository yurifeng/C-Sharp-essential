using System;
using System.Collections.Generic;

namespace List的常用方法
{
    class Program
    {
        static void Main()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(i);
            }


            #region Exists方法

            ////list.Exists();判断集合中是否存在满足指定条件的元素(这个条件就是判断某个事物的方法,如下:Calc就是判断是否是奇数的方法)
            //bool result = list.Exists(Calc);
            //Console.WriteLine(result);

            //bool result2 = list.Exists(Calc2);
            //Console.WriteLine(result2);

            ////lambda表达式判断条件1
            //bool exists = list.Exists(item => item > 100);
            //Console.WriteLine(exists);

            ////lambda表达式判断条件2
            //bool b = list.Exists(item => item % 2 != 0);
            //Console.WriteLine(b);

            #endregion

            #region RemoveAll方法

            ////list.RemoveAll();删除所有符合条件的集合元素(返回值表示要删除的元素的数量)
            ////list.RemoveAll(item => item % 2 == 0);
            //list.RemoveAll(item => item % 2 != 0 && item < 50);//删除小于50的奇数
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region FindAll方法

            ////list.FindAll();//找到符合条件的结果,返回装有结果的list结合
            //List<int> findAll = list.FindAll(item => item >= 10 && item < 50);
            //foreach (int i in findAll)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region FindLast方法

            ////list.FindLast();//返回的是查询的符合条件的最后一个元素
            //int findLast = list.FindLast(item => item > 9 && item < 100);
            //Console.WriteLine(findLast);

            #endregion

            #region FindIndex方法

            ////list.FindIndex();//返回符合条件第一个元素的下标
            //int findIndex = list.FindIndex(item => item > 9 && item < 50);
            //Console.WriteLine(findIndex);

            #endregion

            #region FindLastIndex方法

            //list.FindLastIndex();//返回符合条件最后有一个元素的下标
            int findLastIndex = list.FindLastIndex(item => item > 9 && item < 50);
            Console.WriteLine(findLastIndex);

            #endregion

        }


        /// <summary>
        /// 判断奇数的方法
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool Calc(int item)
        {
            return item % 2 != 0;
        }

        /// <summary>
        /// 判断是否大于100的方法
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool Calc2(int item)
        {
            return item > 100;
        }

    }
}
