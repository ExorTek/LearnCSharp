using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[]
            {
                new Customer {
                    Id = 1,
                    Name = "Customer Mehmet",
                    Surname = "Demirel",
                    City = "Ankara"},

                new Person
                {
                    Id = 2,
                    Name = "Person Mehmet",
                    Surname = "Demirel"
                },

                new Student {Id = 3,
                    Name = "Student Mehmet",
                    Surname = "Demirel",
                    Department = "Programming"}
            };
            foreach (var person in persons)
            {
                Console.WriteLine("ID: "+person.Id+" | Name: "+person.Name+" | Surname: "+person.Surname);
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }

    class Customer : Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }
}
