namespace 继承中的构造方法
{
    class Program
    {
        private static void Main()
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

        }
    }

    class Animal
    {
        public string Name { get; }

        public Animal(string name)
        {
            this.Name = name;
        }

        //public Animal()
        //{
             
        //}
    }

    /// <summary>
    /// 子类继承的时候,父类的构造方法需要考虑
    /// 要么写base();
    /// 要么事先在父类中写好无参构造方法
    /// </summary>
    class Cat : Animal
    {
        public Cat() : base("name")
        {

        }
    }

    class Dog : Animal
    {
        public int Age;

        public Dog() : base("name")
        {

        }
    }
}
