using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;

namespace LearningDay6
{
    class TestA : IComparable<TestA>, IFormattable
    {
        public TestA (int i)
        {
            index = i;
        }
        public int index { get; set; }
        public int CompareTo (TestA other)
        {
            return (this.index > other.index) ? 1 : (this.index == other.index) ? 0 : -1;
        }
        public string ToString (string format, IFormatProvider formatProvider)
        {
            return index.ToString();
        }
    }
    class Program
    {
        static void Main (string[] args)
        {
            string str1 = "aa";//System.String
            StringBuilder str2 = new StringBuilder("a dsad sfasfnnkjjlkasdfoioadfoajidf", 50);//System.Text.StringBuilder
            Console.WriteLine(str1.Replace('a', 'b'));
            Console.WriteLine(str2.Replace('a', 'b'));
            Console.WriteLine(str2);
            float money = 123.122F;
            Console.WriteLine("money:{0,5:C}", money);

            string pattern = @"\bd(\S+)";
            MatchCollection matchs = Regex.Matches(str2.ToString(), pattern);
            foreach (var match in matchs)
            {
                Console.WriteLine((match as Match).Index);
            }

            List<TestA> listObj = new List<TestA>(5) { new TestA(1), new TestA(2) };
            listObj.Add(new TestA(3));
            foreach (var obj in listObj)
            {
                Console.WriteLine("index:{0},tostring:{1}", obj.index, obj.ToString("n", null));
                Console.WriteLine("index at {0},value is{1}", 0, listObj[0]);
            }
            Console.ReadKey();
        }
    }
}
