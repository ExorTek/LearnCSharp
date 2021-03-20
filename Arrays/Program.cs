using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string[] students = new[] {"Tom","Jack","Anna"};
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.ReadLine();
        }
    }
}
