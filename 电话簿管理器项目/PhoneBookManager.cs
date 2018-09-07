
namespace 电话簿管理器项目
{
    //用来做数据管理类的核心功能
    //不需要实例化这个类,只要提供功能就行

    static class PhoneBookManager
    {
        //书籍容量
        private static readonly int _capcity = 10;

        //记录当前存储了多少本书
        private static int _count = 0;

        //存储所有的书籍信息的数组
        public static Book[] AllBooks = new Book[10];


        /// <summary>
        /// 增加书籍
        /// </summary>
        /// <param name="book">参数为书籍</param>
        /// <returns>返回bool类型</returns>
        public static bool AddBook(Book book)
        {
            if (_count >= _capcity)//如果数量大于容量,表示已满
            {
                return false;//返回false
            }
            else
            {
                //如果没满,就存在count位,计数器+1
                AllBooks[_count++] = book;
                return true;
            }
        }


        /// <summary>
        /// 删除所有书籍
        /// </summary>
        public static void DeleteAll()
        {
            //将数组中的每个元素全部填充为null
            for (int i = 0; i < _count; i++)//循环遍历count数量的书籍
            {
                AllBooks[i] = null;//每个元素置为null
            }

            _count = 0;//count置为0
        }
    }
}
