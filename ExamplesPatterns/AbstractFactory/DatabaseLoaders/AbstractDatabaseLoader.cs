using System;
using System.Collections.Generic;

using ExamplesPatterns.AbstractFactory.Queries;
using ExamplesPatterns.AbstractFactory.Tables;

namespace ExamplesPatterns.AbstractFactory.Databases
{
    // Наша абстрактная фабрика для работы с разными типами БД 
    public abstract class AbstractDatabaseLoader
    {
        // Строка для подключения к БД
        public readonly string ConnectionString;
        public AbstractDatabaseLoader(string connectionString)
        {
            ConnectionString = connectionString;
            Console.WriteLine($"Conneсtion to {ConnectionString}");
        }

        // Фабричные методы для загрузки таблиц и хранимых функций
        public abstract List<AbstractTable> GetTables();
        public abstract List<AbstractQuery> GetQueries();
    }
}
