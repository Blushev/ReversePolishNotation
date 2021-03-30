using System;
using System.Collections.Generic;
using System.Text;

namespace ОПЗ
{
    class GetOPS
    {
        List<char> str = new List<char>();
        List<char> stac = new List<char>();
        public int Priority(char _prioritySign)
        {
            int priority = 0;
            switch (_prioritySign)
            {
                case '+':
                case '-':
                    {
                        priority = 1;
                        break;
                    }

                case '*':
                case '/':
                    {
                        priority = 2;
                        break;
                    }

                case '^':
                    {
                        priority = 3;
                        break;
                    }
            }
            return priority;
        }


        public void SignAfter(string _text)
        {
            try
            {
                for(int i = 0; i < _text.Length; i++)
                {
                    if (int.TryParse(_text[i].ToString(), out int k)) //переделать
                    {
                        str.Add(Char.Parse(k.ToString())); 
                    }
                    else
                    {
                        if (_text[i] == '(')
                            stac.Add(_text[i]);
                        if(_text[i] == ')')
                        {
                            if (stac[stac.Count - 1] == '(')
                                stac.RemoveAt(stac.Count - 1);
                            else
                            {
                                str.Add(stac[stac.Count - 1]);
                                stac.RemoveAt(stac.Count - 1); //написать проверку на колличество скобок
                            }

                        }
                        else
                        {
                            if(stac[stac.Count - 1] == '(' || stac.Count == 0)
                            {
                                stac.Add(_text[i]);
                            }

                            else
                            {
                                int p = Priority(_text[i]);
                                int pleft = Priority(stac[stac.Count - 1]);
                                if (pleft >= p)
                                {
                                    str.Add(stac[stac.Count - 1]);
                                    stac.RemoveAt(stac.Count - 1);
                                }
                                else
                                    stac.Add(_text[i]);
                                
                            }
                        }
                       
                    }
                }


                for(int i = stac.Count - 1; i >= 0; i--)
                {

                }
            }

            catch
            {
                Console.WriteLine("Неправильная запись!");
            }
        }
    }
}
