namespace 抽象类
{
    abstract class A
    {
        public abstract void Aa();
    }

    abstract class B : A
    {
        public abstract void Bb();
    }

    abstract class C : B
    {
        public override void Bb()
        {
        }

        public abstract void Cc();

    }

    /// <summary>
    /// D要逐个向上重写所有的抽象方法
    /// 如果已经有抽象方法被别的类重写,则不必重写(不是必须)
    /// </summary>
    class D : C
    {
        public override void Aa()
        {
        }

        public override void Cc()
        {
        }
    }
}
