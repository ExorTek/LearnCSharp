﻿using System;

namespace MethodsOverloading
{
    class Program
    {//ExorTek(Mehmet Demirel)
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
