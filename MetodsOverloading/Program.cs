using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodsOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" --> " + Multiply(2, 4));
            Console.WriteLine(" Overload --> " + Multiply(2, 4,3));
            Console.ReadLine();
        }

        static int Multiply(int numberOne, int numberTwo)
        {
            return numberOne * numberTwo;
        }

        static int Multiply(int numberOne, int numberTwo, int numberThree)
        {
            return numberOne * numberTwo * numberThree;
        }
    }
}
