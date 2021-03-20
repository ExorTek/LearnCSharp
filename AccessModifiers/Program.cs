using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Customer
    {
        private int Id { get; set; } 
        protected int Id2 { get; set; }
        public int Id3 { get; set; }    

        public void Save()
        {
            Id = 1;
            Id2 = 1;
            Id3 = 1;
        }

        public void Delete()
        {
            Id = 1;
            Id2 = 1;
            Id3 = 1;
        }
    }

    class Student: Customer//"protected Id2" is only used in inheritance
    {
        public void Saves()
        {
            Id2 = 1;
            Id3 = 1;
        }
    }

    internal class Course//Classes are "internal" by default
    {
        public string Name { get; set; }

        private class NestedClass
        {
            public string LastName { get; set; }    
        }
    }

    public class PubClass
    {
        public string Sex { get; set; }
    }
}
