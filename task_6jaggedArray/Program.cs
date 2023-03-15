
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_6jaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jarray = new int[3][];
            jarray[0] = new int[4] { 1, 2, 3, 5 };
            jarray[1] = new int[4] { 0, 5, 6, 7 };
            jarray[2] = new int[3] { 8, 9, 10 };

            foreach (int[] v in jarray)
            {
                int MaxRow = 0;
                int MinRow = int.MaxValue;
                Array.ForEach(v, value => MaxRow = MaxRow < value ? value : MaxRow);
                Console.WriteLine($"row element max value:{MaxRow}");

                Array.ForEach(v, value => MinRow = value < MinRow ? value : MinRow);
                Console.WriteLine($"row element min value:{MinRow}");

                }
                int minCol = jarray[0].Length;
                for (int i = 1; i < jarray.Length; i++)
                {
                    if (jarray[i].Length < minCol)
                    {


                        minCol = jarray[i].Length;
                    }
                }
                for (int j = 0; j < minCol; j++)
                {
                    int min = int.MaxValue;
                    for (int i = 0; i < jarray.Length; i++)
                    {
                        if (j < jarray[i].Length && jarray[i][j] < min)
                        {
                            min = jarray[i][j];
                        }
                    }
                    Console.WriteLine("Min value in column " + j + ": " + min);

            }
            Console.ReadKey();
        }
    }
}


 
