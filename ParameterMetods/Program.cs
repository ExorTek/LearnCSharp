using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterMetods
{
    class Program
    {
        static void Main(string[] args)
        {
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
