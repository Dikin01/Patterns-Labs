using System;

namespace ExamplesPatterns.AbstractFactory.Tables
{
    public class SqliteTable : AbstractTable
    {
        
        public SqliteTable(string tableName, string[] columnNames,
            int numberRecords) 
            : base(tableName, columnNames, numberRecords) { }
        
        public override void PrintInfo()
        {
            Console.WriteLine($"I'am SQLite table, {_tableName}" +
                $"\nMy columns:");
            foreach(string column in _columnNames)
            {
                Console.Write(column + " | ");
            }
            Console.WriteLine();
            Console.WriteLine($"Number records - {_numberRecords}");
        }
    }
}
