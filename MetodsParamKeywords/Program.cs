using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodsParamsKeywords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2, 3, 4, 5));
            Console.ReadLine();
        }

        static int Add(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
