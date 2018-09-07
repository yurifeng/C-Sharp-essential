
namespace 接口
{
    class Program
    {
        static void Main()
        {

        }
    }

    /// <summary>
    /// 定义接口规范
    ///  1.接口中不能用 "abstract" 和 "访问权限修饰符"
    /// </summary>
    interface IUsb
    {
        void Charge();//充电
        void TransprtData();//传数据
    }

    /// <summary>
    /// 定义一个鼠标来实现接口implements
    /// 重写后的各个方法必须是public
    /// 重写后的各个方法不能写override
    /// </summary>
    class Mouse : Hardware, IUsb
    {
        /// <summary>
        /// 鼠标实现充电的规范
        /// </summary>
        public void Charge()
        {

        }

        /// <summary>
        /// 鼠标实现传输数据的规范
        /// </summary>
        public void TransprtData()
        {

        }
    }

    /// <summary>
    /// 抽象类实现接口也要重写接口中的方法
    /// </summary>
    abstract class Keyboard : Hardware, IUsb
    {

        public void Charge()
        {

        }

        public void TransprtData()
        {

        }
    }


    /// <summary>
    /// 声明一个类让其他类来继承该类
    /// </summary>
    class Hardware
    {
        //一个类既有继承又有实现接口的时候
        //冒号后面先是继承的类型,逗号后面是接口的类型
        //简洁来说就是-->继承类,实现接口
    }
}
