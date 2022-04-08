using System;
using ExamplesPatterns.AbstractFactory.Databases;
using ExamplesPatterns.AbstractFactory.Tables;
using ExamplesPatterns.AbstractFactory.Queries;
using System.Collections.Generic;

namespace ExamplesPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=(localdb)\\" +
                "mssqllocaldb;Database=helloappdb";
            AbsractDatabase db = 
                new SqlServerDatabase(connectionString);

            List<AbstractTable> tables = db.GetTables();
            Console.WriteLine("Tables");
            foreach (var table in tables)
            {
                table.PrintInfo();
            }

            List<AbstractQuery> queries = db.GetQueries();
            Console.WriteLine("Execute queries");
            foreach (var query in queries)
            {
                query.Execute();
            }

            //--------------------------------------------------

            Console.WriteLine();
            connectionString = "Data Source=Another.db";
            db = new SqliteDatabase(connectionString);

            tables = db.GetTables();
            Console.WriteLine("Tables");
            foreach (var table in tables)
            {
                table.PrintInfo();
            }

            queries = db.GetQueries();
            Console.WriteLine("Execute queries");
            foreach (var query in queries)
            {
                query.Execute();
            }
        }
    }
}
