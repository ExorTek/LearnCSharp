using System;
using AccessModifiers;

namespace AccessModifiersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            PubClass pubClass = new PubClass();
            pubClass.Sex = "Male";
        }
    }
}
