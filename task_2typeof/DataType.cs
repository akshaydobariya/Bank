using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2typeof
{
    class DataType
    {
        public void checkDataType(object one,object two)
        {
            if(one is int && two is int)
            {
                Console.WriteLine($"your enter value is a int");
            }
            else if(one is string && two is string)
            {
                Console.WriteLine($"your enter value is a string");
            }
            else if (one is float && two is float)
            {
                Console.WriteLine($"your enter value is a float");
            }
            else if (one is char && two is char)
            {
                Console.WriteLine($"your enter value is a charactor");
            }
            else if (one is string && two is char)
            {
                Console.WriteLine($"your enter value is a string");
            }
            else if (one is char && two is string)
            {
                Console.WriteLine($"your enter value is a char");
            }
            else if (one is string && two is float)
            {
                Console.WriteLine($"your enter value is a string");
            }
            else if (one is float && two is string)
            {
                Console.WriteLine($"your enter value is a float");
            }
            else if (one is float && two is int)
            {
                Console.WriteLine($"your enter value is a float");
            }
        }
           
        }

    }

