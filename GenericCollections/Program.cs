using System;
using System.Collections.Generic;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            

            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");
            cities.Add("İzmir");
            cities.Add("Adana");



            Console.WriteLine("------------------- Content Search(Returns true or false) ------------------------");
            Console.WriteLine("There are : " + cities.Contains("Ankara"));
            Console.WriteLine("There aren't :  " + cities.Contains("Bolu"));


            Console.WriteLine("------------------- Returns string list ------------------------");

            foreach (var city in cities)
            {
                Console.WriteLine(" " + city);
            }

            Console.WriteLine("------------------- Returns integer list ------------------------");

            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            foreach (var number in numbers)
            {
                Console.WriteLine(" " + number);
            }

            List<Customer> customersOne = new List<Customer>();
            customersOne.Add(new Customer { FirstName = "Mehmet", Id = 1 });
            customersOne.Add(new Customer { FirstName = "Ahmet", Id = 2 });

            List<Customer> customersTwo = new List<Customer>
            {
                new Customer
                {
                    FirstName = "Yağmur",
                    Id = 3
                },
                new Customer
                {
                    FirstName = "Nisa",
                    Id = 4
                }
            };
            
            Console.WriteLine("------------------- New Methods 1 ------------------------");

            foreach (var customer in customersOne)
            {
                Console.WriteLine(" ID : " + customer.Id + " | Name : " + customer.FirstName);
            }
            Console.WriteLine("------------------- New Methods 2 ------------------------");

            foreach (var customer in customersTwo)
            {
                Console.WriteLine(" ID : " + customer.Id + " | Name : " + customer.FirstName);
            }

            Console.WriteLine("------------------- Count ------------------------");
            var count = customersTwo.Count;
            Console.WriteLine(" Amount of it : " + count);

            Console.WriteLine("------------------- Adding Function ------------------------");
            var customerr = new Customer
            {
                FirstName = " Emir",
                Id = 5
            };
            Console.WriteLine(" ID : " + customerr.Id + " | Name : " + customerr.FirstName);
            Console.WriteLine("------------------- Adding elements to the list ------------------------");
            customersOne.AddRange(new Customer[2]
            {
                new Customer{FirstName = "Leyla",Id = 6},
                new Customer{FirstName = "Ali",Id = 7}
            });
            foreach (var customer in customersOne)
            {
                Console.WriteLine(" ID : " + customer.Id + " | Name : " + customer.FirstName);
            }
            //customersOne.Clear(); Clear the list

            //customersTwo.Remove(customerr);

            Console.WriteLine();
            Console.ReadLine();
        }

    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
