using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDay5
{
    class Program
    {
        public static int add (int a, int b)
        {
            return a + b;
        }

        public static int sub (int a, int b)
        {
            return a - b;
        }
        public delegate int delegate1 (int a, int b);//委托定义
        public event delegate1 event1;
        static void Main (string[] args)
        {
            delegate1 dl1 = new delegate1(add);
            dl1 += new delegate1(sub);//多播委托。
            Console.WriteLine("1+3={0}", dl1(1, 3));
            Console.WriteLine("3-1={0}", dl1(3, 1));    //由于委托的顺序不确定,造成输出错误
            foreach (var dl in dl1.GetInvocationList()) //循环多播委托的方法
            {
                Console.WriteLine("1,3={0}", (dl as delegate1)(3, 1));
            }
            Func<int, int, int> dl2 = delegate (int a, int b)   //匿名方法。单行定义委托，有返回值
            {
                return a + b;
            };
            Console.WriteLine("2+4={0}", dl2(2, 4));
            Action<string> dl3 = str => //无返回值委托，lambda表达式
            {
                Console.WriteLine(str += "!");
            };
            dl3("hello world");
            
            
            Console.ReadKey();
        }
    }
}
