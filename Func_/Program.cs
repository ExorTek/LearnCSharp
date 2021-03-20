using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func_
{
    class Program
    {//ExorTek(Mehmet Demirel)
        static void Main(string[] args)
        {
            Func<int, int, int> add = Sum;

            Console.WriteLine(Sum(3,4));

            Console.WriteLine("-----------------");

            Func<int> getRandomNumberOne = delegate()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };

            Func<int> getRandomNumberTwo = () => new Random().Next(1, 100);

            Console.WriteLine(getRandomNumberOne());
            Console.WriteLine(getRandomNumberTwo());


           //Console.WriteLine(Sum(5,6));

            Console.ReadLine();
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
