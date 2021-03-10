
using System;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console Text Color
            Console.ForegroundColor = ConsoleColor.Green;
            //Console Text Color

            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            sqlServer.Delete();

            Console.WriteLine();

            MySqlServer mySqlServer = new MySqlServer();
            mySqlServer.Add();
            mySqlServer.Delete();

            Console.ReadLine();
        }
        
    }

    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }

        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }

    class SqlServer:Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by SqlServer");
            base.Add();
        }
        public override void Delete()
        {
            Console.WriteLine("Deleted by SqlServer");
            base.Delete();
        }
    }

    class MySqlServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by MySql");
            base.Add();
        }

        public override void Delete()
        {
            Console.WriteLine("Deleted by MySql");
            //base.Delete();
        }
    }
}
