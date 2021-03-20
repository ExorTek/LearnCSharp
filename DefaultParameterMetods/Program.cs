using System;

namespace DefaultParameterMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine(" --> " + Add());
            Console.ReadLine();
        }

        static int Add(int numberOne = 1, int numberTwo = 2)
        {
            var result = numberOne + numberTwo;
            return result;
        }
    }
}
