using System;

namespace 自定义异常
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person();
            try
            {
                p.Age = -10;
                //p.SetAge = -10;
            }
            catch (MyException message)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(message);
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
    }

    /// <summary>
    /// 自定义异常
    /// </summary>
    public class MyException : Exception
    {
        public MyException()
        {

        }

        /// <summary>
        /// 调用父类中的Exception(string message)构造方法给异常信息赋值
        /// base(message)
        /// </summary>
        /// <param name="message"></param>
        public MyException(string message) : base(message)
        {

        }


    }

    /// <summary>
    /// Person实体类
    /// </summary>
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (age > 0 && age < 130)
                {
                    age = value;
                }
                else
                {
                    //抛出异常
                    //1.实例化异常对象
                    MyException myException = new MyException("年龄设置不合法....");

                    //2.抛出异常
                    throw myException;
                }
            }
        }

        public Person()
        {

        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        //public void SetAge(int age)
        //{
        //    if (age > 0 && age < 130)
        //    {
        //        this.age = Age;
        //    }
        //    else
        //    {
        //        //抛出异常
        //        //1.实例化异常对象
        //        MyException myException = new MyException("年龄设置不合法....");

        //        //2.抛出异常
        //        throw myException;
        //    }
        //}
    }
}
