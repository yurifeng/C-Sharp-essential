using System;

namespace 设计模式
{
    class Program
    {
        private static void Main()
        {
            User user01 = User.CurrentUser();
            User user02 = User.CurrentUser();

            //user01和user02是一样的
            Console.WriteLine(user01.Equals(user02));
            Console.WriteLine(user01 == user02);

        }
    }

    /// <summary>
    /// 使用单例模式(重要)
    /// </summary>
    class User
    {
        //1.构造方法私有化(禁止通过new实例化对象)
        private User() { }

        //2.提供一个私有的静态的当前类对象
        private static readonly User Instance = new User();

        //3.提供一个public的权限的方法,
        //  用来返回一个当前类的对象(该方法要设计成静态方法)
        public static User CurrentUser()
        {
            return Instance;
        }

    }
}
