using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurOwnErrorClass
{
    class Program
    {
        static void Main(string[] args)
        {
            HandleExcepiton(() =>
            {
                Find();
            });


            Console.ReadLine();
        }

        private static void HandleExcepiton(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> student = new List<string> { "Mehmet", "Yağmur", "Derin" };
            if (!student.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record Not Found!");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }
    }
}