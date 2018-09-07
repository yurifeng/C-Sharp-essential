using System;
using System.Collections;

namespace HashTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //声明一个HashTable
            Hashtable ht = new Hashtable();

            Add(hashtable: ht);

            Remove(hashtable: ht);

            Update(hashtable: ht);

            Select(hashtable: ht);

            //循环遍历的结果输出键值对的内容
            foreach (DictionaryEntry dictionaryEntry in ht)
            {
                //Console.WriteLine(dictionaryEntry.Key + "--->" + dictionaryEntry.Value);

                Console.WriteLine("[{0}=={1}]", dictionaryEntry.Key, dictionaryEntry.Value);
            }

        }

        /// <summary>
        /// 增
        /// </summary>
        /// <param name="hashtable"></param>
        public static void Add(Hashtable hashtable)
        {
            hashtable.Add("01", "0xaa55h");
            hashtable.Add("02", "0x00001");
            hashtable.Add("03", "0x00002");
            hashtable.Add("04", "0x00003");
            hashtable.Add("05", "0x00004");
        }

        /// <summary>
        /// 删
        /// </summary>
        /// <param name="hashtable"></param>
        public static void Remove(Hashtable hashtable)
        {
            hashtable.Remove("03");

            //清空
            //hashtable.Clear();
        }

        /// <summary>
        /// 改
        /// </summary>
        /// <param name="hashtable"></param>
        public static void Update(Hashtable hashtable)
        {
            hashtable["01"] = "哈哈";

            //索引器的作用:--->之前没有的key,都可以添加
            hashtable["0600"] = "889";
        }

        /// <summary>
        /// 查
        /// </summary>
        /// <param name="hashtable"></param>
        public static void Select(Hashtable hashtable)
        {
            object o = hashtable["01"];
            Console.WriteLine(o);
        }


        public static void FunctionTools(Hashtable hashtable)
        {
            bool containsKey = hashtable.ContainsKey("01");
            bool containsValue = hashtable.ContainsValue("0xaa55h");
            bool contains = hashtable.Contains("02");
        }
    }
}
