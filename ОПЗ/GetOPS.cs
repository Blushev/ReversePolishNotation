using System;
using System.Collections.Generic;
using System.Text;

namespace ОПЗ
{
    class GetOPS
    {
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


        public void SignAfter()
        {

        }
    }
}
