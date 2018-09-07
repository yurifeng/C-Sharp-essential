using System;

namespace 委托实际案例
{
    class Program
    {
        static void Main(string[] args)
        {
            //实例化技能池
            SkillPool skillPool = new SkillPool();

            //将某项技能赋值给 技能池的实例中的number1
            skillPool.number1 = Skills.Shanxian;
            skillPool.number2 = Skills.Baofengyu;
            skillPool.number3 = Skills.Mingyuedao;

            while (true)
            {
                string readLine = Console.ReadLine();
                switch (readLine)
                {
                    case "1":
                        skillPool.number1();
                        break;
                    case "2":
                        skillPool.number2();
                        break;
                    case "3":
                        skillPool.number3();
                        break;
                    default:
                        Console.WriteLine("技能不存在..");
                        break;
                }
            }


        }


    }

    /// <summary>
    /// 创建一个delegate委托方法
    /// </summary>
    public delegate void Skill();

    /// <summary>
    /// 创建一个技能池类
    /// </summary>
    public class SkillPool
    {
        //技能池里面有委托的
        public Skill number1;
        public Skill number2;
        public Skill number3;
    }

    /// <summary>
    /// 创建技能类,里面有很多技能
    /// </summary>
    public static class Skills
    {
        public static void Shanxian()
        {
            Console.WriteLine("闪现....");
        }

        public static void Mingyuedao()
        {
            Console.WriteLine("明月刀....");
        }

        public static void Baofengyu()
        {
            Console.WriteLine("暴风雨...");
        }
    }
}
