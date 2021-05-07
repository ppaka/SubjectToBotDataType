using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubjectToBotDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Console.ReadLine();
            var splited = data.Split(',');

            foreach (var s in splited)
            {
                if(s.Equals("컴그"))
                {
                    Console.WriteLine("0");
                }
                if (s.Equals("국어"))
                {
                    Console.WriteLine("1");
                }
                if (s.Equals("영어"))
                {
                    Console.WriteLine("2");
                }
                if (s.Equals("사회"))
                {
                    Console.WriteLine("3");
                }
                if (s.Equals("국사"))
                {
                    Console.WriteLine("4");
                }
                if (s.Equals("수학"))
                {
                    Console.WriteLine("5");
                }
                if (s.Equals("프로"))
                {
                    Console.WriteLine("6");
                }
                if (s.Equals("과학"))
                {
                    Console.WriteLine("7");
                }
                if (s.Equals("진로"))
                {
                    Console.WriteLine("8");
                }
                if (s.Equals("음악"))
                {
                    Console.WriteLine("9");
                }
                if (s.Equals("디자"))
                {
                    Console.WriteLine("10");
                }
                if (s.Equals("체육"))
                {
                    Console.WriteLine("11");
                }
                if (s.Equals("자율"))
                {
                    Console.WriteLine("12");
                }
                if (s.Equals("정처"))
                {
                    Console.WriteLine("13");
                }
                if (s.Equals("파이썬"))
                {
                    Console.WriteLine("14");
                }
            }
            Console.ReadKey();
        }
    }
}
