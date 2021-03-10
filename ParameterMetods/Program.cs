using System;

namespace ParameterMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console Text Color
            Console.ForegroundColor = ConsoleColor.Green;
            //Console Text Color

            Console.WriteLine(" --> " + Add(1, 2));
            Console.ReadLine();
        }

        static int Add(int numberOne, int numberTwo)
        {
            var result = numberOne + numberTwo;
            return result;
        }
    }
}
