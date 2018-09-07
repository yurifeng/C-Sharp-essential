
namespace 接口
{
    interface IStupid
    {
        /// <summary>
        /// 接口中可以写属性访问器
        /// </summary>
        int Age { set; get; }
        string Name { get; }
    }

    public class HashiQi : IStupid
    {
        private int _age;

        /// <inheritdoc />
        /// <summary>
        /// 实现类中需要有一个舒心叫做age,并提供set和get访问器
        /// </summary>
        public int Age
        {
            set { }
            get { return 1; }
        }

        public string Name
        {
            get { return "哈士奇"; }
        }
    }
}
