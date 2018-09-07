namespace 抽象类
{
    class Program
    {
        static void Main()
        {
        }
    }

    /// <summary>
    /// 抽象类
    /// </summary>
    abstract class Animal
    {
        public string Name;

        public void Bark()
        {

        }

        /// <summary>
        /// 抽象方法,抽象方法没有实现方法体
        /// </summary>
        public abstract void Show();


    }

    class Cat : Animal
    {

        /// <summary>
        /// 子类继承了抽象类,必须要实现父类的抽象方法
        /// </summary>
        public override void Show()
        {

        }
    }
}
