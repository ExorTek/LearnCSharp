using System;

namespace ClassesFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console Text Color
            Console.ForegroundColor = ConsoleColor.Green;
            //Console Text Color

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Updated();

            Console.WriteLine("");

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Updated();

            Console.WriteLine("");

            CustomerManagers customerManagers = new CustomerManagers();
            customerManagers.Add();
            customerManagers.Updated();

            Console.WriteLine("");

            ProductManagers productManagers = new ProductManagers();
            productManagers.Add();
            productManagers.Updated();


            Console.ReadLine();
        }

        class CustomerManager
        {
            public void Add()
            {
                Console.WriteLine("Added Customer");
            }

            public void Updated()
            {
                Console.WriteLine("Updated Customer");
            }
        }   

        class ProductManager
        {
            public void Add()
            {
                Console.WriteLine("Added Product");
            }

            public void Updated()
            {
                Console.WriteLine("Updated Product");
            }
        }
    }
}
