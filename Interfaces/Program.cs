using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console Text Color
            Console.ForegroundColor = ConsoleColor.Green;
            //Console Text Color

            //InterfacesIntro();

            //InterfacePolymorphism();

            //ForTheNewDatabaseInInterface();



            Console.ReadLine();
        }

        private static void ForTheNewDatabaseInInterface()
        {
            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleServerCustomerDal(),
                new MySqlServerCustomerDal()
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
        }

        private static void InterfacePolymorphism()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            customerManager.Add(new OracleServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            personManager.Add(new Customer() //Metod 1
            {
                Id = 1,
                Name = "Customer Mehmet",
                Surname = "Demirel",
                Adress = "Ankara"
            });

            Student student = new Student() //Metod 2
            {
                Id = 2,
                Name = "Student Mehmet",
                Surname = "Demirel",
                Departmant = "Programming"
            };
            personManager.Add(student);
        }
    }

    interface IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Adress { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Departmant { get; set; }
    }

    class PersonManager
    {

        public void Add(IPerson person)
        {
            Console.WriteLine("ID: " + person.Id + " | Name :" + person.Name + " | Surname: " + person.Surname);
        }


    }
}
