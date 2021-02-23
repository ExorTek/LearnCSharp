using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] regions = new string[4, 3]
            {
                {"December" ,"January","February"},
                {"March" ,"April","May"},
                {"June" ,"July","August" },
                {"September" ,"October","November"}
            };
            
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);

                }
            }
            Console.ReadLine();
        }
    }
}
