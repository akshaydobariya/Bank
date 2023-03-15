
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4countDatatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int intCount, stringCount, floatCount, charCount;
            countDatatypes(out intCount, out stringCount, out floatCount, out charCount, 1, 2, 1.23f, 1.23f, 12, 'a', 's', 'r', "akshay", "dobariya");

            Console.WriteLine($"total intgers is: {intCount}");
            Console.WriteLine($"total strings is: {stringCount}");

            Console.WriteLine($"total float is: {floatCount}");

            Console.WriteLine($"total char is: {charCount}");
            Console.ReadKey();

        }

        static void countDatatypes(out int intCount,out int stringCount,out int floatCount,out int charCount,params Object[] arr)
        {
            intCount= stringCount= floatCount=charCount= 0;
            
            foreach(object a in arr)
            {
                if(a is int )
                {
                    intCount += 1;
                    
                }
                else if(a is string)
                {
                    stringCount += 1;
                }
                else if (a is float)
                {
                    floatCount += 1;
                }
                else if (a is char)
                {
                    charCount += 1;
                }
            }
        }
    }
}
