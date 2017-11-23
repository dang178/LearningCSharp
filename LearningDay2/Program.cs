using System;

namespace LearningDay2
{
    struct TestA    //结构体
    {
        public int a;
        private float b;
        public TestA (int aa, float bb) //构造函数无返回值，且构造函数中必须给结构体所有字段赋值
        {
            a = aa;
            b = bb;
        }
    }
    class TestB //类
    {
        const float c = 3.14F;
        public static int a;
        public TestB (int aa)    //函数默认为保护类型
        {
            a = aa;
        }
        private int b;
        public int add ()
        {
            return a + b;
        }
    }
    //静态类中只包含静态方法跟属性，静态属性必须在调用前初始化
    ///静态类不能有实例构造函数，只能有静态构造函数
    ///且静态构造函数不能有参数
    static class TestC
    {
        static int a = 1;
        static float b = 1.2F;
        static TestC ()
        {

        }
        public static float add ()
        {
            return a + b;
        }
    }
    /// <summary>
    /// 部分类
    /// </summary>
    partial class TestE
    {
        public int a;
        public TestE ()
        {
            a = 1;
            b = 2;
        }
    }

    partial class TestE
    {
        public int b;
        public int add ()
        {
            return a + b;
        }
    }
    /// <summary>
    /// 重写tostring
    /// </summary>
    class TestF
    {
        static int a = 1;
        static int b = 2;
        public override string ToString ()
        {
            int c = a + b;
            return c.ToString("D3");
        }
    }
    class Program
    {
        public static void structFun (ref TestA a) //值类型数据转化为引用参数,要在类内部使用时，必须声明为静态方法
        {
            Console.WriteLine(a.a);
        }
        static void Main (string[] args)
        {
            TestA a = new TestA(1, 1.2F);
            structFun(ref a);
            TestB b = new TestB(3);
            Console.WriteLine(b.add());
            float c = TestC.add();
            Console.WriteLine(c);
            var d = new { First = 1, Second = 2 };//匿名类型
            ///弱引用
            WeakReference we = new WeakReference(new TestB(1));
            TestB e;
            if (we.IsAlive)
            {
                e = we.Target as TestB;
                Console.WriteLine("弱引用：{0}", e.add());
            }

            ///部分类
            TestE f = new TestE();
            Console.WriteLine("部分类：{0}", f.add());

            //重写
            TestF g = new TestF();
            Console.WriteLine("重写tostring:{0}", g.ToString());
            Console.ReadKey();

        }
    }
}
