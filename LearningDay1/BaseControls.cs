using System;//引用命名空间
/// <summary>
/// C#基础
/// </summary>
namespace LearningDay1
{
    /// <summary>
    /// 自动生成XML说明文件
    /// 学习第一天：
    /// 基本操作
    /// </summary>
    public class BaseControls
    {
        private int testA = 0;//私有变量,只能被当前类访问
        static uint testA1 = 12u;//短整型
        static long testA2 = 123123L;//长整型
        static ulong testA3 = 23131ul;//无符号长整型
        public string TestB = "dd";//共有变量，能被其他类访问
        static string TestB1 = @"D:\ddd";//@消除转义字符
        protected float TestC = 1.23F;//声明单精度浮点对象，能被当前类及其子类访问
        static double TestC1 = 1.231;//双精度浮点型
        public static int TestD = 1;//静态变量,能被类中的方法访问
        const int TestE = 2;//常量
        public enum TestF   //枚举类型，不用声明静态变量
        {
            morning = 1,
            afternoon = 2,
            night = 3
        }
        public static void Main ()
        {
            Console.WriteLine("金额{0,4:C3}", TestD);
            Console.WriteLine((int)TestF.morning);
            Console.WriteLine("{0:#.000}", TestC1);//测试占位符
            //ConsoleInput.InputInt();
            //ConsoleInput.InputString();
            //ConsoleInput.InputArray();
            //ConsoleInput.InputCompos();
            ConsoleInput.InputCompos1();
            Console.ReadKey();//等待输入，若没有这句，则窗体闪现
        }
    }
}
