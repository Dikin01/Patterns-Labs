using System;
using System.Threading;

namespace ExamplesPatterns.AbstractFactory.Queries
{
    // Хранимая функция для БД типа Sqlite - конкретный продукт для SqliteLoader
    public class SqliteQuery : AbstractQuery
    {
        public SqliteQuery(string name, string query)
            : base(name, query) { }

        // Реализует метод для выполнения функции
        public override void Execute()
        {
            Thread.Sleep(500); // Имитация выполнения запроса
            Console.WriteLine($"Sqlite Query {_name} was executed");
        }
    }
}
