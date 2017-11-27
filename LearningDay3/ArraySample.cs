using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDay3
{
    class ArraySample
    {
        public static void NewArray ()
        {
            int[] a1 = { 1 };//数组使用前必须赋值，否则会报错：使用了未赋值的局部变量
            int[] a2 = new int[2];//使用new后，会自动初始化
            int[,] a3 = { { 1, 2 }, { 3, 4 } };//多维数组定义,用多个中括号
            int[][] a4 = new int[2][];//这种方法定义锯齿数组
            Console.WriteLine("a1:{0},a2:{1},a3:{2},a4:{3}", a1[0], a2[0], a3[0, 0], a3[0, 1]);
            Array a5 = Array.CreateInstance(typeof(int), 4);
            Array a6 = Array.CreateInstance(typeof(int), new int[] { 3, 3 });
            Console.WriteLine("a5:{0},a6:{1}", a5, a6);
        }
    }
}
