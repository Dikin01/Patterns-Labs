using System;
using System.Threading;

namespace ExamplesPatterns.AbstractFactory.Queries
{
    public class SqliteQuery : AbstractQuery
    {
        public SqliteQuery(string name, string query)
            : base(name, query) { }

        public override void Execute()
        {
            Thread.Sleep(500); // Имитация выполнения запроса
            Console.WriteLine($"Sqlite Query {_name} was executed");
        }
    }
}
