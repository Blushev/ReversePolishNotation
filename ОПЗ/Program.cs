using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ОПЗ
{
    class Program
    {
        static List<string> massiveOfLine = new List<string>();
        static List<string> numbers = new List<string>();
        static List<string> chars = new List<string>();
        static string path = "input.txt";
        static string[] line;
        static string[] example;

        public static void GetExampleFromText(string path)
        {
            line = File.ReadAllLines(path);
            example = line[0].Split(" "); //line[0] отвечает именно за первую строку нашего блокнота!
        }

        static void Main(string[] args)
        {
            GetExampleFromText(path);
            GetOPS deductionOfExample = new GetOPS();
            string reversePolishNotation = deductionOfExample.SignAfter(example);
            string[] virashenie = reversePolishNotation.Split(" ");
            Console.WriteLine(reversePolishNotation);

            CountSumm gg = new CountSumm();         
            Console.WriteLine(gg.GetSumm(virashenie));
            Console.ReadKey();
        }
    }
}
