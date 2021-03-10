using System;
using AccessModifiers;

namespace AccessModifiersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console Text Color
            Console.ForegroundColor = ConsoleColor.Green;
            //Console Text Color
            PubClass pubClass = new PubClass();
            pubClass.Sex = "Male";
        }
    }
}
