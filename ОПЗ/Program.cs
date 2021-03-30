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



        public static void GetExampleFromText(string path)
        {
            string[] line = File.ReadAllLines(path);
            string[] example = line[0].Split(" ");
            foreach (var s in example) { massiveOfLine.Add(s); }
            Separator(massiveOfLine);
        }



        public static void Separator(List<string>massiveOfLine)
        {
            string[] sign = new string[] { "+", "-", "/", "*" };
            foreach (var s in massiveOfLine)
            {
                if (s == sign[0] || s == sign[1] || s == sign[2] || s == sign[3])
                    continue;
                numbers.Add(s);
            }
            string[] massiveOfNumbers = numbers.ToArray();


            foreach (var s in massiveOfLine)
            {
                if (s != sign[0] || s != sign[1] || s != sign[2] || s != sign[3])
                    continue;
                chars.Add(s);
            }
            string[] massiveOfChars = chars.ToArray();
            GetSum(massiveOfNumbers, massiveOfChars);
        }


        public static void RemoveIndexOfMassive(ref string[] massiveOfChars, int index)
        {
            index = 0;
            string[] newMassive = new string[massiveOfChars.Length - 1];
            for (int i = index + 1; i < massiveOfChars.Length; i++) newMassive[i-1] = massiveOfChars[i];
            newMassive = massiveOfChars;
        }


        public static void GetSum(string[] massiveOfNumbers, string[] massiveOfChars)
        {
            int sum = 0;
            
        }


        static void Main(string[] args)
        {
            GetExampleFromText(path);
        }
    }
}


/*КЛАСС- ОДНА ЗАДАЧА
 * 0.КЛАСС КОТОРЫЙ СЧИТЫВАЕТ ФАЙЛ
 * 1.КЛАСС КОТОРЫЙ ПЕРЕВОДИТ В ОПЗ
 * 2.КЛАСС КОТОРЫЙ СЧИТАЕТ ОПЗ
 * 
