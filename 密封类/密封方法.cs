namespace 密封类
{
    class Animal01
    {
        public virtual void Show()
        {

        }
    }

    /// <summary>
    /// 1.只有Override的方法可以被密封
    /// </summary>
    class Dog :Animal01
    {
        public override void Show()
        {

        }
    }

    class Hashiqi:Dog
    {
        public override void Show()
        {

        }
    }
}
