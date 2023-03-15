using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5countDatatypes2
{
    class Program
    {
        static void Main(string[] args)
        {
            int evenCount, oddCount, blankCount,max;
            string stringConcat;

            countDataType(out evenCount, out oddCount, out stringConcat, out blankCount,out max, 1, 2, 3, 4, 5, 6, "akshay", "dobariya", "  ", "          ");
            Console.WriteLine($"sum of even number is :{evenCount}");
            Console.WriteLine($"sum of odd number is :{oddCount}");
            Console.WriteLine($"concat of all string is:{stringConcat}");
            Console.WriteLine($"blank is:{blankCount}");
            Console.WriteLine($"max string length is :{max}");
            Console.ReadKey();

        }

        static void countDataType(out int evenCount, out int oddCount, out string stringConcat, out int blankCount, out int max,params Object[] arr)
        {
            evenCount = oddCount = blankCount= max=0;
            stringConcat = "";
            foreach(Object a in arr)
            {
                // check method parameters is integers 
                if(a is int)
                {
                    //check integer is even or odd
                    if((int)a % 2==0)
                    {
                        evenCount += (int)a;
                    }
                    else
                    {
                        oddCount += (int)a;
                    }
                }

                //check method parameter is string
                else if(a is string)
                {

                    //concating two strings
                    stringConcat = string.Join(" ",stringConcat, a);

                    //check string is empty 
                    string blank = (string)a;
                    char starttrim = ' ' ;
                    char endtrim = ' ';
                    string trim = blank.TrimStart(starttrim);
                     trim = blank.TrimStart(endtrim);
                    if(trim.Length == 0)
                    {

                    blankCount += 1;

                    }


                    // find a maximum length of a string
                    max = max < trim.Length ? trim.Length : max;
                }
               

            }
        }
    }
} 
