using System;
using System.Collections.Generic;

namespace OurOwnErrorClass
{
    class Program
    {//ExorTek(Mehmet Demirel)
        static void Main(string[] args)
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }


            Console.ReadLine();
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
