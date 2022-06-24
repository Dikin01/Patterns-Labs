using ExamplesPatterns.AbstractFactory.Queries;
using ExamplesPatterns.AbstractFactory.Tables;
using System;
using System.Collections.Generic;

namespace ExamplesPatterns.AbstractFactory.Databases
{
    // Наша абстрактная фабрика для работы с разными типами БД 
    public abstract class AbstractDatabaseLoader
    {
        // Строка для подключения к БД
        public readonly string _connectionString;
        public AbstractDatabaseLoader(string connectionString)
        {
            _connectionString = connectionString;
            Console.WriteLine($"Conneсtion to {_connectionString}");
        }

        // Фабричные методы для загрузки таблиц и хранимых функций
        public abstract List<AbstractTable> GetTables();
        public abstract List<AbstractQuery> GetQueries();
    }
}
