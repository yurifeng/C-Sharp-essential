using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 接口回调
{
    class Program
    {
        static void Main()
        {
            Person p = new Person();
            p.Download("http://www.baidu.com/");
        }

    }

    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void Download(string url)
        {
            Thunder th = new Thunder();
            th.Download(url);
        }
    }

    class Thunder
    {
        /// <summary>
        /// 迅雷下载
        /// </summary>
        /// <param name="url"></param>
        public void Download(string url)
        {
            for (int i = 0; i <= 100; i++)
            {
                //Console.Clear();
                Console.WriteLine("数据下载中...{0}%", i);
                Thread.Sleep(80);
            }

            string data = "windows 10 file";

            Console.WriteLine(data);
        }
    }
}
