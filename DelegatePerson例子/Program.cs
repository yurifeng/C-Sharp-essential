using System;
using System.Collections.Generic;

namespace DelegatePerson例子
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> persons = new List<Person>
            {
                new Person("livir",23),
                new Person("owen",56),
                new Person("jsd",88),
                new Person("yty",44),
                new Person("htt",52),
                new Person("jietong",45),
            };

            //foreach (Person person in persons)
            //{
            //    Console.WriteLine(person);
            //}

            //找到所有年龄为奇数的Person
            List<Person> resultList = persons.FindAll(item => item.Age % 2 == 1);
            foreach (Person person in resultList)
            {
                Console.WriteLine(person);
            }

            //判断集合中是否存在某个Person
            bool exists = persons.Exists(item => item.Name == "yty");
            Console.WriteLine(exists);
        }
    }

    class Person
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

        public Person()
        {

        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return string.Format("姓名:{0},年龄:{1}", name, age);
        }
    }
}
