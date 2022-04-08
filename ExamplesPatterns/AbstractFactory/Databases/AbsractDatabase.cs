using ExamplesPatterns.AbstractFactory.Queries;
using ExamplesPatterns.AbstractFactory.Tables;
using System;
using System.Collections.Generic;

namespace ExamplesPatterns.AbstractFactory.Databases
{
    public abstract class AbsractDatabase
    {
        private string _connectionString;
        public AbsractDatabase(string connectionString)
        {
            _connectionString = connectionString;
            Console.WriteLine($"Connetion to {_connectionString}");
        }
        public abstract List<AbstractTable> GetTables();
        public abstract List<AbstractQuery> GetQueries();
    }
}
