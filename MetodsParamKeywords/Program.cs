using System;
using System.Linq;

namespace MethodsParamsKeywords
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
