using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultParameterMetods
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
