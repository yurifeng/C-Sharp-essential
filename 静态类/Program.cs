namespace 静态类
{
    public static class Arrays
    {
        //1.静态类不能实例化对象
        //2.静态类中不能写非静态类的成员(字段,属性,方法)
        public static int B;

        public static int A
        {
            set { B = value; }
        }

        public static void Show()
        {

        }

        /// <summary>
        /// 静态的构造方法不能有访问权限修饰符和参数
        /// </summary>
        static Arrays()
        {

        }
    }


    public class Program
    {
        public static void Main()
        {

        }
    }
}