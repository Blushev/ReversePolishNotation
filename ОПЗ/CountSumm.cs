using System;
using System.Collections.Generic;
using System.Text;

namespace ОПЗ
{
    class CountSumm
    {
        List<int> numbers = new List<int>();
        public int GetSumm(string[] _text)
        {
            for(int i = 0; i < _text.Length; i++)
            {
                int number;
                if(int.TryParse(_text[i], out number))
                    numbers.Add(number);
                else
                {
                    switch (_text[i])
                    {
                        case "+":
                            {
                               int summ = numbers[numbers.Count - 1] + numbers[numbers.Count - 2];
                                numbers.RemoveAt(numbers.Count - 1);
                                numbers.RemoveAt(numbers.Count - 1);
                                numbers.Add(summ);
                                break;
                            }
                        case "-":
                            {
                                int summ = numbers[numbers.Count - 1] - numbers[numbers.Count - 2];
                                numbers.RemoveAt(numbers.Count - 1);
                                numbers.RemoveAt(numbers.Count - 1);
                                numbers.Add(summ);
                                break;
                            }
                        case "*":
                            {
                                int summ = numbers[numbers.Count - 1] * numbers[numbers.Count - 2];
                                numbers.RemoveAt(numbers.Count - 1);
                                numbers.RemoveAt(numbers.Count - 1);
                                numbers.Add(summ);
                                break;
                            }
                        case "/":
                            {
                                int summ = numbers[numbers.Count - 1] / numbers[numbers.Count - 2];
                                numbers.RemoveAt(numbers.Count - 1);
                                numbers.RemoveAt(numbers.Count - 1);
                                numbers.Add(summ);
                                break;
                            }
                        case "^":
                            {
                                int summ = (int)Math.Pow(numbers[numbers.Count - 2], numbers[numbers.Count - 1]);
                                numbers.RemoveAt(numbers.Count - 1);
                                numbers.RemoveAt(numbers.Count - 1);
                                numbers.Add(summ);
                                break;
                            }
                    }
                }

            }
            return numbers[0];
        }
    }
}
