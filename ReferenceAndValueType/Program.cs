using System;
using System.Data;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console Text Color
            Console.ForegroundColor = ConsoleColor.Green;
            //Console Text Color

            int numberOne = 10;
            int numberTwo = 20;
            numberTwo = numberOne;
            numberOne = 30;
            Console.WriteLine(numberTwo);

            string[] citiesOne = new string[] {"Ankara", "Adana","İstanbul"};
            string[] citiesTwo = new string[] {"İzmir","Mus","Tekirdağ" };

            citiesTwo = citiesOne;

            citiesOne[0] = "Bolu";
            Console.WriteLine(citiesTwo[0]);

            DataTable dataTableOne;
            DataTable dataTableTwo = new DataTable();
            dataTableOne = dataTableTwo;

            Console.ReadLine();
        }
    }
}
