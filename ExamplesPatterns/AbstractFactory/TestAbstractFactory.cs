using System;
using System.Collections.Generic;

using ExamplesPatterns.AbstractFactory.Databases;
using ExamplesPatterns.AbstractFactory.Queries;
using ExamplesPatterns.AbstractFactory.Tables;

namespace ExamplesPatterns.AbstractFactory
{
    //Тестовый сценарий для паттерна Абстрактная фабрика
    public class TestAbstractFactory : ITestable
    {
        public void Test()
        {
            // Теперь проверим, что сделали
            // Объявим наши абстрактные объекты и строку подключения к БД
            AbstractDatabaseLoader db;
            List<AbstractTable> tables;
            List<AbstractQuery> queries;
            string connectionString;

            // Создадим подключение для Sqlite и посмотрим содержимое такой БД
            connectionString = "Data Source=foobar.db";
            db = new SqliteLoader(connectionString);
            tables = db.GetTables();
            queries = db.GetQueries();

            Console.WriteLine("Tables");
            foreach (var table in tables)
            {
                table.PrintInfo();
            }
            
            Console.WriteLine("Execute queries");
            foreach (var query in queries)
            {
                query.Execute();
            }

            //Выполним аналогично для SqlServer
            Console.WriteLine();        

            connectionString = "Server=(localdb)\\mssqllocaldb;Database=helloappdb";
            db = new SqlServerLoader(connectionString);
            tables = db.GetTables();
            queries = db.GetQueries();

            Console.WriteLine("Tables");
            foreach (var table in tables)
            {
                table.PrintInfo();
            }

            Console.WriteLine("Execute queries");
            foreach (var query in queries)
            {
                query.Execute();
            }
        }
    }
}
