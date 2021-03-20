using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Please enter a number : ");
            //int number = Convert.ToInt32(Console.ReadLine());

            CustomerManager customerManager = new CustomerManager(15 /* number */);
            customerManager.List();

            Product product = new Product()
            {
                Id = 1,
                Name = "Mehmet"
            };

            Product product2 = new Product(2, "Mehmet");

            EmployeeManager employeeManager = new EmployeeManager(new FileLogger());
            //employeeManager.Logger = new DatabaseLogger();
            //employeeManager.Logger = new FileLogger();
            employeeManager.Add();

            PersonManager personManager = new PersonManager("Person");
            personManager.Add();

            Teacher.Number = 65;
            Console.WriteLine(Teacher.Number);

            Utilities.Validate();

            Manager.DoSomething();

            Manager manager = new Manager();
            manager.DoSomethings();

            Console.ReadLine();
        }
        //Use of Constructor 1
        class CustomerManager
        {
            private int _count;
            public CustomerManager(int count = 10)//Overload
            {
                _count = count;
            }

            public void List()
            {
                Console.WriteLine($"Listed {_count} items");
                //Alternatives
                //Console.WriteLine("Listed {0} items", _count);
                //Console.WriteLine("Listed " + _count + " items");
            }

            public void Add()
            {
                Console.WriteLine("Added!");
            }
        }
        //Use of Constructor 2
        class Product
        {
            public Product()
            {

            }

            int _id;
            string _name;
            public Product(int id, string name)
            {
                _id = id;
                _name = name;
            }
            public int Id { get; set; }
            public string Name { get; set; }
        }
        //Constructor Injection
        interface ILogger
        {
            void Log();
        }

        class DatabaseLogger : ILogger
        {
            public void Log()
            {
                Console.WriteLine("Logged to database");
            }
        }
        class FileLogger : ILogger
        {
            public void Log()
            {
                Console.WriteLine("Logged to file");
            }
        }

        class EmployeeManager
        {
            //public ILogger Logger { get; set; }

            private ILogger _logger;

            public EmployeeManager(ILogger logger)
            {
                _logger = logger;
            }
            public void Add()
            {
                //Logger.Log();

                _logger.Log();
                Console.WriteLine("Added!");
            }
        }

        class BaseClass
        {
            private string _entity;

            protected BaseClass(string entity)
            {
                _entity = entity;
            }

            protected void Message()
            {
                Console.WriteLine($"{_entity} message");
            }
        }

        class PersonManager : BaseClass
        {
            public PersonManager(string entity) : base(entity)
            {

            }

            public void Add()
            {
                Console.WriteLine("Added Person");
                Message();
            }
        }

        static class Teacher
        {
            public static int Number { get; set; }
        }
        static class Utilities
        {
            public static void Validate()
            {
                Console.WriteLine("Validation is done");
            }
        }

        class Manager
        {
            public static void DoSomething()
            {
                Console.WriteLine("Done");
            }

            public void DoSomethings()
            {
                Console.WriteLine("Done 2");
            }
        }
    }
}
