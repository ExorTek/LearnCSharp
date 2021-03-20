﻿
using System;

namespace VirtualMethods
{
    class Program
    {//ExorTek(Mehmet Demirel)
        static void Main(string[] args)
        {
         

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
