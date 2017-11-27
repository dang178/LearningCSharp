using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 继承
/// </summary>
namespace LearningDay3
{
    abstract class TestA
    {
        private int a;  //字段
        public int A    //属性
        {
            get
            {
                return a;
            }
            set
            {
                A = value;
            }
        }
        public abstract int add (); //抽象函数不能是私有的，且不能有实现
        public TestA (int aa)
        {
            a = aa;
        }
        public int sub ()   //抽象类可以有非抽象函数
        {
            return a;
        }
    }

    class TestB : TestA
    {
        public int a;
        public TestB () : base(1)
        { }
        public override int add ()  //重写继承的抽象函数
        {
            return 0;
        }
    }
    class TestC
    {
        public virtual int add ()
        {
            return 0;
        }
    }
    class TestD : TestC
    {
        public override int add ()  //重写父类函数
        {
            return 1;
        }
    }
    interface ITestD    //声明接口
    {
        //public int a;//接口不能包含字段
        int add (); //接口不能有修饰符
        int A { get; set; }//属性
    }
    class TestE : ITestD    //继承接口必须实现所有成员
    {
        public int add ()
        {
            return 0;
        }
        public int A
        {
            get { return 0; }
            set { A = 1; }
        }
    }
    class Program
    {
        static void Main (string[] args)
        {
            //  TestA a = new TestA();//不能实例化抽象类
            //TestC c = new TestC();
            //TestD d = new TestD();
            //Console.WriteLine(c.add());
            //Console.WriteLine(d.add());
            //链表
            //LinkList linkList = new LinkList();
            //linkList.AddLastNode(1);
            //linkList.AddLastNode(2);
            //linkList.AddLastNode(3);
            //linkList.AddLastNode(4);
            //foreach (int node in linkList)
            //{
            //    Console.Write("{0}\t", node);
            //}
            //Console.WriteLine();
            //LinkList<string> linkList1 = new LinkList<string>();
            //linkList1.AddLastNode("a");
            //linkList1.AddLastNode("b");
            //linkList1.AddLastNode("c");
            //linkList1.AddLastNode("d");
            //foreach (string node in linkList1)
            //{
            //    Console.Write("{0}\t", node);
            //}
            ArraySample.NewArray();

            Console.ReadKey();
        }
    }
}
