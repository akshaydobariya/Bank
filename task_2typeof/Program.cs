using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2typeof
{
    class Program
    {
        static void Main(string[] args)
        {
            Object one=1.0f,two=2;
            Object two1 = "akshay";

            DataType d = new DataType();
            d.checkDataType('c',two1);
            d.checkDataType("aksh", 'c');
         
            d.checkDataType(one, two);
            Console.ReadKey();
        }
    }
}
