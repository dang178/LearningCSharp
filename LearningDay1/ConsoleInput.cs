using System;
using System;

namespace LearningDay1
{
    /// <summary>
    /// 常见的控制台输入
    /// </summary>
    public class ConsoleInput
    {
        /// <summary>
        /// 输入一个整数
        /// </summary>
        public static void InputInt ()
        {
            Console.Write("请输入整形数：");
            int i = Console.Read();//读取整形数
            Console.Write(i);//转换成ASCII码输出
        }
        /// <summary>
        /// 读取输入的一行字符，并输出字符串
        /// </summary>
        public static void InputString ()
        {
            Console.Write("请输入字符串：");
            string str = Console.ReadLine();
            Console.WriteLine(str);
        }
        /// <summary>
        /// 输入5个元素的数组，并输出
        /// </summary>
        public static void InputArray ()
        {
            Console.Write("请输入5个整数的数组：");
            int[] arraryA = new int[5];
            string str = Console.ReadLine();
            string[] strArray = str.Split(' ');
            for (int i = 0; i < strArray.Length; i++)
            {
                arraryA[i] = int.Parse(strArray[i]);
                Console.Write(arraryA[i] + "\t");
            }
            Console.WriteLine("\n");
        }
        /// <summary>
        /// 首先输入一个整数，作为数组个数，
        /// 然后输入n个整数作为数组
        /// 当两个Read连用时，必须在中间读出第一个输入的换行符
        /// </summary>
        public static void InputCompos ()
        {
            //Console.WriteLine("输入数组长度：");
            int length = Console.Read();
            Console.ReadLine();//如果没有这句则会造成数组输入失败
            int[] arrayA = new int[length];
            //Console.WriteLine("输入{0}个整数：");
            string str = Console.ReadLine();
            string[] strArray = str.Split(' ');
            for (int i = 0; i < strArray.Length; i++)
            {
                arrayA[i] = int.Parse(strArray[i]);
                Console.Write(arrayA[i] + "\t");
            }
            Console.WriteLine("\n");
        }
        /// <summary>
        /// 输入第一个为数组元素个数,换行
        /// 之后每行输入一个元素
        /// </summary>
        public static void InputCompos1 ()
        {
            int length = int.Parse(Console.ReadLine());//读入数组长度
            int[] arr = new int[length];
            while (length-- != 0)
            {
                Console.Read();
                arr[length] = int.Parse(Console.ReadLine());
            }
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
