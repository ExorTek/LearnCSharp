using System;

namespace RecapDemoTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExorTek(Mehmet Demirel)

            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new DatabaseLogger();
            customerManager.Add();

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        public ILogger Logger { get; set; }//Property injection
        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Customer Added");
        }
    }

    class DatabaseLogger:ILogger
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
    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Sms");
        }
    }

    interface ILogger
    {
        void Log();
    }
}
