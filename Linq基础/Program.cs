using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Net.WebSockets;

namespace Linq基础
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basic01();
            //Basic02();
            //Basic03();
            //Basic04();
            //Basic05();
            //Basic06();
            //Query07();
            //Query08();
            Query09();
        }

        /// <summary>
        /// 类型查询
        /// </summary>
        public static void Basic01()
        {
            ArrayList list = new ArrayList
            {
                45,56,89,78,40,56,4,48,7,8,
                "yty","likvir","jsd","htt",
                "Washington DC","London","Beijing",
                1.23,3.14f,false
            };

            ////查询list中所有的string类型(ofType)
            //IEnumerable<string> enumerable = list.OfType<string>();
            //foreach (string s in enumerable)
            //{
            //    Console.WriteLine(s);
            //}

            //查询list中所有的int类型(直接foreach循环遍历)
            foreach (int i in list.OfType<int>())
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// 基本查询
        /// </summary>
        public static void Basic02()
        {
            List<Person> list = new List<Person>()
            {
                new Person("yty",10),
                new Person("htt223",23),
                new Person("jsd1710",56),
                new Person("jsd1708",45),
                new Person("杰森斯坦森",20),
                new Person("道恩强森",31),
            };

            ////查询年龄大于50岁的(findAll方法)
            //List<Person> findAll = list.FindAll(item => item.Age > 50);
            //foreach (Person person in findAll)
            //{
            //    Console.WriteLine(person);
            //}

            //linq语法(查询年龄大于50的)
            //linq是延迟查询(就算linq语句结束后,list再添加add,到循环遍历的时候还是会查出来新增加的)
            IEnumerable<Person> enumerable = from person in list
                                             where person.Age > 30 && person.Age < 57
                                             select person;

            list.Add(new Person("马加爵", 56));

            foreach (Person person in enumerable)
            {
                Console.WriteLine(person);
            }
        }

        /// <summary>
        /// 查询结果排序
        /// </summary>
        public static void Basic03()
        {
            List<Person> list = new List<Person>()
            {
                new Person("yty",10),
                new Person("htt223",45),
                new Person("jsd1710",45),
                new Person("jsd1708",12),
                new Person("杰森斯坦森",20),
                new Person("道恩强森",31),
            };

            //linq将查询的结果排序
            //查询年龄大于5的数据,升序排序,年龄相同,按照姓名升序
            IOrderedEnumerable<Person> orderedEnumerable =
                from person in list
                where person.Age > 5
                orderby person.Age, person.Name
                select person;

            foreach (Person person in orderedEnumerable)
            {
                Console.WriteLine(person);
            }
        }

        /// <summary>
        /// 简单查询(搞清楚返回值)
        /// select 后面可以跟person,也可以跟person的属性,比如person.name,person.age
        /// </summary>
        public static void Basic04()
        {
            List<Person> list = new List<Person>()
            {
                new Person("yty",10),
                new Person("htt223",45),
                new Person("jsd1710",45),
                new Person("jsd1708",12),
                new Person("杰森斯坦森",20),
                new Person("道恩强森",31),
            };

            IEnumerable<string> enumerable =
                from person in list
                select person.Name + "," + person.Age;
            foreach (string s in enumerable)
            {
                Console.WriteLine(s);
            }
        }

        /// <summary>
        /// 简单查询的变种(匿名类型)
        /// </summary>
        public static void Basic05()
        {
            List<Person> list = new List<Person>()
            {
                new Person("yty",10),
                new Person("htt223",45),
                new Person("jsd1710",45),
                new Person("jsd1708",12),
                new Person("杰森斯坦森",20),
                new Person("道恩强森",31),
            };

            //匿名类型
            var enumerable = from person in list
                             orderby person.Age descending
                             select new
                             {
                                 name = person.Name,
                                 age = person.Age
                             };
            foreach (var item in enumerable)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// 类型判断
        /// </summary>
        public static void Basic06()
        {
            List<object> list = new List<object>()
            {
                535,7,5,6,88,55,978,98,81,10,
                "fucking yourself","jsd1808",
                true,false,
                3.14,3.14f,3.14m,
                new Person("yty",20)
            };

            //查找int32或者string类型
            IEnumerable<object> enumerable =
                from item in list
                where item is Int32 || item is string
                //orderby item descending
                select item;

            foreach (object o in enumerable)
            {
                Console.WriteLine(o);
            }
        }


        /// <summary>
        /// 复合查询
        /// </summary>
        public static void Query07()
        {
            List<Person> list = new List<Person>()
            {
                new Person("ytys",10)
                {
                    dogs = new List<Dog>()
                    {
                        new Dog("哈士奇",8),
                        new Dog("泰日天",6),
                        new Dog("小奶狗",4)
                    }
                },
                new Person("htt223",23)
                {
                    dogs = new List<Dog>()
                    {
                        new Dog("二哈",8),
                        new Dog("中华田园犬",5),
                    }
                },
                new Person("jsd1710",56)
                {
                    dogs = new List<Dog>()
                    {
                        new Dog("三哈",8),
                        new Dog("柴犬",4),
                        new Dog("金毛",6),
                    }
                },
                new Person("jsd1708",45)
                {
                    dogs = new List<Dog>()
                    {
                        new Dog("德国牧羊犬",4),
                        new Dog("泰日天",4)
                    }
                },
                new Person("Jason stanSam",20),
                new Person("Daoanjiangsam",31)
            };

            #region string中的contains方法查询带有s的人名

            //查询名字中包含t的成员
            //IEnumerable<Person> enumerable =
            //    from person in list
            //    where person.Name.Contains("s")
            //    select person;
            //foreach (Person person in enumerable)
            //{
            //    Console.WriteLine(person);
            //}

            #endregion

            #region 纯用linq的方法查询带有s的人名

            //IEnumerable<Person> enumerable = from person in list
            //                                 from pn in person.Name
            //                                 where pn == 's'
            //                                 select person;
            //foreach (Person person in enumerable)
            //{
            //    Console.WriteLine(person);
            //}

            #endregion

            #region 找出养狗的人

            //IEnumerable<Person> enumerable =
            //    from person in list
            //    where person.dogs.Count > 0
            //    select person;

            //foreach (Person person in enumerable)
            //{
            //    Console.WriteLine(person);
            //}

            #endregion

            //找出所有养泰日天的人
            IEnumerable<Person> enumerable =
                from person in list
                from dog in person.dogs
                where dog.Name == "泰日天"
                select person;

            foreach (Person person in enumerable)
            {
                Console.WriteLine(person);
            }
        }

        /// <summary>
        /// 组合查询
        /// </summary>
        public static void Query08()
        {
            List<Person> list1 = new List<Person>()
            {
                new Person("lilei",10)
                {
                    dogs = new List<Dog>()
                    {
                        new Dog("taidi",4),
                        new Dog("haishiqi",3)
                    }
                },

                new Person("hanmeimei",20)
                {
                    dogs = new List<Dog>()
                    {
                        new Dog("jinmao",3),
                        new Dog("chaiquan",3)
                    }
                }
            };

            List<Person> list2 = new List<Person>()
            {
                new Person("Micheal",10)
                {
                    dogs = new List<Dog>()
                    {
                        new Dog("haishiqi",3)
                    }
                },

                new Person("John",20)
                {
                    dogs = new List<Dog>()
                    {
                        new Dog("chaiquan",3)
                    }
                }
            };

            //找到两个集合中年龄相同的对象
            var enumerable = from person1 in list1
                             join person2 in list2 on person1.Age equals person2.Age
                             select new { name = person1.Name + "," + person2.Name, age = person1.Age };

            foreach (var item in enumerable)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// 并行查询
        /// list.AsParallel()
        /// </summary>
        public static void Query09()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(i);
            }

            //查询集合中
            long time1 = DateTime.Now.ToBinary();//先记录初始时间
            var result1 = from n in list select n;
            Console.WriteLine(result1);

            long time2 = DateTime.Now.ToBinary();
            var result2 = from n in list.AsParallel() select n;
            Console.WriteLine(result2);

            long time3 = DateTime.Now.ToBinary();

            long bravo1 = time2 - time1;//记录result1执行的时间段
            long bravo2 = time3 - time2;//记录result2执行的时间段

            Console.WriteLine(bravo1 + "\n" + bravo2);
        }
    }

    /// <summary>
    /// Person实体类
    /// </summary>
    class Person
    {
        private string name;
        private int age;
        public List<Dog> dogs;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person()
        {

        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            dogs = new List<Dog>();
        }

        public override string ToString()
        {
            return string.Format("[姓名:{0},年龄:{1}]\ndogs=\n{2}\n", name, age, dogs.ToString1());
        }
    }

    /// <summary>
    /// 拓展ToString方法
    /// </summary>
    public static class Extension
    {
        internal static string ToString1(this List<Dog> dogs)
        {
            string str = "";
            foreach (Dog dog in dogs)
            {
                str += dog + "\n";
            }

            return str;
        }
    }

    /// <summary>
    /// Dog的实体类
    /// </summary>
    class Dog
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Dog()
        {

        }

        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return string.Format("Dog:->[name:{0}--age{1}]", name, age);
        }
    }
}
