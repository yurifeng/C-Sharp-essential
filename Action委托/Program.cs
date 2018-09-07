using System;

namespace Action委托
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Action委托

            ////Action内置委托类型,没有返回值(都是参数)
            //Action<int> ac;
            //Action<int, string> acc;
            //Action<int, string, double> accc;


            //Action dcc = () => Console.WriteLine("fkdashkdj");
            //dcc();

            //Action<int> aac = i => Console.WriteLine(i * 12);
            //aac(3);

            #endregion


            #region Func委托

            //Func有返回值的委托(返回值在前面,参数在后面)
            Func<string> fcc;//表示无参数,返回值类型是string类型
            Func<int, string> ffc;//string表示参数,int表示返回值
            Func<int, string, double> ffcc;//返回值是int类型,string和double是2个参数

            Func<int> ff = () => 123;
            Console.WriteLine(ff());

            Func<int, int, int> f1 = (i, i1) => i + i1;
            Console.WriteLine(f1(12, 238));

            #endregion
        }

        //private static void Calc(string str)
        //{
        //    Console.WriteLine("calculate...");
        //}
    }
}
