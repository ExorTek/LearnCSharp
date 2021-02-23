using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesProp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Mehmet";
            customer.LastName = "Demirel";
            customer.City = "Adana";

            Customer customerTwo = new Customer()
            {
                Id = 2,FirstName = "Emir Can",LastName = "Dalman",City = "Giresun"
            };

            Console.WriteLine("ID: "+customer.Id+" | Name : "+customer.FirstName+ " | Surname : " + customer.LastName+ " | City : " + customer.City);
            Console.WriteLine("ID: " + customerTwo.Id + " | Name : " + customerTwo.FirstName + " | Surname : " + customerTwo.LastName + " | City : " + customerTwo.City);
            Console.ReadLine();
        }
    }
}
