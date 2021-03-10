using System;
using System.Collections;
namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console Text Color
            Console.ForegroundColor = ConsoleColor.Green;
            //Console Text Color

            ArrayList cities = new ArrayList();
            cities.Add("Adana");
            cities.Add("Ankara");

            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add('A');

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            Console.ReadLine();
        }

    }
}
