using System;
using System.Threading;

namespace ExamplesPatterns.AbstractFactory.Queries
{
    public class SqlServerQuery : AbstractQuery
    {
        private int _executionTime;
        public SqlServerQuery(string name, string query)
            : base(name, query) { }
        
        public override void Execute()
        {
            _executionTime = 300;
            Thread.Sleep(300); // Имитация выполнения запроса
            Console.WriteLine($"SqlServer Query {_name}" +
                $" was executed, execution time = {_executionTime}");
        }
    }
}
