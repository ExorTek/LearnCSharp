using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Database sqlServerDatabase = new SqlServer();
            sqlServerDatabase.Add();
            sqlServerDatabase.Delete();

            Console.WriteLine();

            Database oracleDatabase = new Oracle();
            oracleDatabase.Add();
            oracleDatabase.Delete();

            Console.ReadLine();
        }
    }

    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }

        public abstract void Delete();
    }

    class SqlServer:Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by SqlServer");
        }
    }

    class Oracle:Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}
