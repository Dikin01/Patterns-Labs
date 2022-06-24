using System;
using System.Threading;

namespace ExamplesPatterns.AbstractFactory.Queries
{
    // Функции для БД типа SqlServer - конкретный продукт для SqlServerLoader
    // Реализуем и расширим AbstractQuery, сохраняя время выполнения функции
    public class SqlServerQuery : AbstractQuery
    {
        private int executionTime;
        public SqlServerQuery(string name, string query)
            : base(name, query) { }
        
        public override void Execute()
        {
            executionTime = 300;
            Thread.Sleep(300); // Имитация выполнения запроса
            Console.WriteLine($"SqlServer Query {_name}" +
                $" was executed, execution time = {executionTime}");
        }
    }
}
