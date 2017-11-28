using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDay4
{
    class Program
    {
        class TestA
        {
            public int a;
            public string b;
            public static TestA operator + (TestA lhs, TestA rhs)   //重载运算符
            {
                TestA result = new TestA();
                result.a = lhs.a + rhs.a;
                result.b = lhs.b + rhs.b;
                return result;
            }
        }
        struct TestB
        {
            public int a;
            public string b;
        }
        static void Main (string[] args)
        {
            int? b = null;  //定义可空类型
            int a = b ?? 0; //合并空运算符
            Console.WriteLine("a:{0},b:{1}", a, b);

            //类的比较
            TestA testA = new TestA();
            testA.a = 1;
            testA.b = "s";
            TestA testB = new TestA();
            testB.a = 1;
            testB.b = "s";
            if (ReferenceEquals(testA, testB))  //判断两个类是否引用同一个对象，即是否指向同一个地址
            {
                Console.WriteLine("两个对象相同！");
            }
            else
            {
                Console.WriteLine("两个对象不同！");
            }

            if (Equals(testA, testB))
            {
                Console.WriteLine("equals,两个对象相同！");
            }
            else
            {
                Console.WriteLine("equals,两个对象不同！");
            }
            Console.WriteLine("testA+testB={0}", (testA + testB).a);
            //结构的比较
            TestB testC = new TestB();
            testC.a = 1;
            testC.b = "s";
            TestB testD = new TestB();
            testD.a = 1;
            testD.b = "s";
            if (ReferenceEquals(testC, testD))  //判断两个类是否引用同一个对象，即是否指向同一个地址
            {
                Console.WriteLine("两个对象相同！");
            }
            else
            {
                Console.WriteLine("两个对象不同！");
            }

            if (Equals(testC, testD))
            {
                Console.WriteLine("equals,两个对象相同！");
            }
            else
            {
                Console.WriteLine("equals,两个对象不同！");
            }
            //unsafe
            //{
            //    Console.WriteLine(sizeof(TestA));//sizeof适用于不安全模式
            //}
            //byte a = 255;
            //checked     //执行溢出检查，当溢出时，会抛出异常
            //{
            //    a++;
            //}
            //unchecked { //禁止溢出检查
            //    a++;
            //}
            Console.ReadKey();
        }
    }
}
