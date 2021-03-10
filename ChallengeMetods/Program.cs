using System;
namespace ChallengeMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console Text Color
            Console.ForegroundColor = ConsoleColor.Green;
            //Console Text Color

            int numberOne = 1;
            int numberTwo = 2;
            var result = Add(numberOne, numberTwo);

            Console.WriteLine(" --> " + result);
            Console.ReadLine();
        }

        static int Add(int numberOne, int numberTwo)
        {
            var result = numberOne + numberTwo;
            return result;
        }
    }
}
