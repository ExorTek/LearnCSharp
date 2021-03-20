using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] students = new string[3] {"Mehmet", "Yağmur", "Derin"};
                students[3] = "Nur";
            }
            catch (IndexOutOfRangeException exception)//if the exception type is known
            {
                Console.WriteLine("Exception");
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception");
                Console.WriteLine(exception.Message);
            }


            Console.ReadLine();
        }
    }
}
