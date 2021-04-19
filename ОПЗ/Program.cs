using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ОПЗ
{
    class Program
    {
        static string path = "input.txt";
        static string[] line;
        static string[] example;

        public static void GetExampleFromText(string path)
        {
            line = File.ReadAllLines(path);
            example = line[0].Split(" "); 
        }

        static void Main(string[] args)
        {
            GetExampleFromText(path);
            GetOPS deductionOfExample = new GetOPS();
            string reversePolishNotation = deductionOfExample.SignAfter(example);
            string[] divideBySpaceExample = reversePolishNotation.Split(" ");
            Console.WriteLine(reversePolishNotation);

            CountSumm countSumm = new CountSumm();         
            Console.WriteLine(countSumm.GetSumm(divideBySpaceExample));
            Console.ReadKey();
        }
    }
}
