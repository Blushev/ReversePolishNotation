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
        static string path = @"C:\Users\My\source\repos\ОПЗ\ОПЗ\input.txt";



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


/*
 * -------ВОПРОСЫ---------
 * 
 * 1. Можно ли проводить операции над операциями?
   К примеру:
   Если я хочу чтобы у меня уже в цикле проводились какие-нибудь операции отталкиваясь от знака в тексте
   (Если эта строчка имеет знак +, то даем какой-нибудь переменной char значение этого знака и у нас выражение 
   будет иметь следующий вид "элементМассива[0] char элементМассива[2] (1 + 2))
   Проблема заключалась в том, что я не мог конверировать тот же "+" во что либо еще...

   2. Как приводить массивы к разным типам данных? (Я слышал это делается как-то через Object)


   3. Возможен ли поочередный цикл массивов по одному разу. Тоесть,
    string[] massiveOfNumbers (массив чисел)
    string[] massiveOfChars (еще какой-то массив. Со знаками тут почему-то не канает. Врядли я могу распарсить знаки)

    Хочу чтобы они сменяли друг друга через раз. Сначала прогналось число, потому что-то из другого массива, опять число, опять что-то...

   4. Можем ли мы из самого кода напрямую взаимодействовать с файлом?
 */