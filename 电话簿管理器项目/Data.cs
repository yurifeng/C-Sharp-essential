
namespace 电话簿管理器项目
{
    /// <summary>
    /// 数据模型
    /// </summary>
    class Book
    {
        public string Name;//书名
        public double Price;//价格
        public Author Auther;//作者

    }

    enum Gender { Male, Female }

    class Author
    {
        public string Name;//作者姓名
        public int Age;//坐着年龄
        public Gender Gender;//性别
    }
}
