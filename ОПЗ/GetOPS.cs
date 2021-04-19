using System;
using System.Collections.Generic;
using System.Text;

namespace ОПЗ
{
    class GetOPS
    {
        List<string> lineofWithDrawal = new List<string>();
        List<string> stac = new List<string>();
        public int Priority(string _prioritySign)
        {
            int priority = 0;
            switch (_prioritySign)
            {
                case "+":
                case "-":
                    {
                        priority = 1;
                        break;
                    }

                case "*":
                case "/":
                    {
                        priority = 2;
                        break;
                    }

                case "^":
                    {
                        priority = 3;
                        break;
                    }

                case "(":
                    {
                        priority = 0;
                        break;
                    }
            }
            return priority;
        }


        public string SignAfter(string[] _text)
        {
            string result = "";

            try
            {
                for (int i = 0; i < _text.Length; i++)
                {
                    if (int.TryParse(_text[i], out int k))
                    {
                        lineofWithDrawal.Add(k.ToString() + " ");
                    }
                    else
                    {
                        switch (_text[i])
                        {
                            case "(":
                                {
                                    stac.Add(_text[i]);
                                    break;
                                }

                            case ")":
                                {
                                    while(stac[stac.Count - 1] != "(")
                                    {
                                        lineofWithDrawal.Add(stac[stac.Count - 1] + " ");
                                        stac.RemoveAt(stac.Count - 1);
                                    }

                                    stac.RemoveAt(stac.Count - 1);
                                    break;
                                }
                            default:
                                {
                                    if (stac.Count == 0)
                                        stac.Add(_text[i]);
                                    else
                                    {
                                        int pr = Priority(_text[i]);
                                        int prLeft = Priority(stac[stac.Count - 1]);
                                        if (prLeft >= pr)
                                        {
                                            lineofWithDrawal.Add(stac[stac.Count - 1] + " ");
                                            stac.RemoveAt(stac.Count - 1);
                                            stac.Add(_text[i]);
                                        }
                                        else
                                            stac.Add(_text[i]);
                                    }
                                    break;
                                }
                        }
                    }
                }

                for(int i = stac.Count - 1; i >= 0; i--)
                {
                    lineofWithDrawal.Add(stac[i] + " ");

                }
                
                for(int i = 0; i < lineofWithDrawal.Count; i++)
                {
                    result += lineofWithDrawal[i];
                }
                
            }

            catch
            {
                Console.WriteLine("Неправильная запись!");
            }
            return result;
        }
    }
}
