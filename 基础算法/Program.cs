using System;

namespace 基础算法
{
    class Program
    {
        private static void Main()
        {
            #region 二分查找(前提是数组事先排序好的)

            //int[] arr = { 10, 20, 30, 78, 89, 90, 120, 160 };

            //int index = -1;//表示查找到的元素的下标

            ////确定一个要查找的下标的范围
            //int min = 0;
            //int max = arr.Length - 1;//最大值的下标就是元素长度减去1

            //while (max >= min)
            //{
            //    int mid = (min + max) / 2;//中间值

            //    if (arr[mid] == 89)//如果数组的中间值是89
            //    {
            //        index = mid;//mid就是下标
            //        break;
            //    }
            //    else if (arr[mid] > 89)
            //    {
            //        max = mid - 1;
            //    }
            //    else if (arr[mid] < 89)
            //    {
            //        min = mid + 1;
            //    }
            //}

            //Console.WriteLine("中间值的下标为: " + index);



            #endregion

            #region 选择排序进行升序排序

            //int[] arr = new[] { 1, 434, 435, 657, 7, 8867, 8, 689879 };
            //Sort01(arr);
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region 冒泡排序
            //int[] arr = new[] { 1, 434, 435, 657, 7, 8867, 8, 689879 };
            //Sort02(arr);
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}


            #endregion
        }

        /// <summary>
        /// 选择排序进行升序排序
        /// </summary>
        /// <param name="arr"></param>
        private static void Sort01(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)//前面数的下标
            {
                for (int j = i + 1; j < arr.Length; j++)//后面数的下标
                {
                    if (arr[i] > arr[j])//如果前面下标的数大于后面的
                    {
                        int tmp = arr[i];//声明的临时的tmp装大数
                        arr[i] = arr[j];//将小数给前一位
                        arr[j] = tmp;//将大数给后一位
                    }
                }
            }
        }


        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <param name="arr"></param>
        private static void Sort02(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                    }
                }
            }
        }



    }
}
