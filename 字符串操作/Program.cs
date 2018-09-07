namespace 字符串操作
{
    class Program
    {
        static void Main()
        {
            #region 判断一个数字是不是质数(质数只能被1和自身整除)


            //while (true)
            //{
            //    Console.WriteLine("输入数字:\n\t");
            //    int number = Convert.ToInt32(Console.ReadLine());
            //    bool result = true;//假设所有的数字都是质数

            //    for (int i = 2; i < number; i++)
            //    {
            //        if (number % i == 0)//被整除
            //        {
            //            result = false;//置false,已证明不是质数
            //            break;
            //        }
            //    }

            //    //根据result的值判断一个数字是否是质数
            //    string message = result ? "是" : "不是";
            //    Console.WriteLine($"数字{number}{message}一个质数");
            //}

            #endregion


            #region 输出100以内的质数



            //for (int number = 2; number <= 100; number++)
            //{
            //    bool result = true;//假设所有的数字都是质数

            //    for (int i = 2; i < number; i++)
            //    {
            //        if (number % i == 0)//被整除
            //        {
            //            result = false;//置false,已证明不是质数
            //            break;
            //        }
            //    }

            //    if (result)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            #endregion


            #region 斐波那契数列

            //int number0 = 1, number1 = 1;
            //for (int i = 1; i <= 30; i++)
            //{
            //    int num = number0;
            //    Console.WriteLine(number0);
            //    number0 = number1;
            //    number1 = num + number1;
            //}

            #endregion


            #region 十行五列

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        Console.Write("* ");
            //    }

            //    Console.WriteLine();
            //}

            #endregion


            #region 直角三角形星号

            //for (int line = 1; line <= 50; line++)
            //{
            //    for (int colmn = 1; colmn <= line; colmn++)
            //    {
            //        Console.Write("* ");
            //    }

            //    Console.WriteLine();
            //}

            #endregion


            #region 九九乘法表(外部九行)

            //for (int line = 1; line <= 9; line++)
            //{
            //    for (int colmn = 1; colmn <= line; colmn++)
            //    {
            //        Console.Write(colmn + "x" + line + "=" + line * colmn + "\t");
            //    }

            //    Console.WriteLine();
            //}

            #endregion


            #region 更多图形打印(正三角形)

            //for (int line = 1; line <= 10; line++)
            //{
            //    for (int colmn = 1; colmn <= 10; colmn++)
            //    {
            //        Console.Write(line + colmn <= 10 ? " " : "* ");
            //    }

            //    Console.WriteLine();
            //}

            #endregion


            #region 更多图形打印(反直角三角形)

            //for (int line = 1; line <= 10; line++)
            //{
            //    for (int colmn = 1; colmn <= 10; colmn++)
            //    {
            //        Console.Write(line + colmn <= 10 ? " " : "*");
            //    }

            //    Console.WriteLine();
            //}

            #endregion




        }
    }
}
