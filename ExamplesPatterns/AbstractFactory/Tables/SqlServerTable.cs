using System;

namespace ExamplesPatterns.AbstractFactory.Tables
{
    public class SqlServerTable : AbstractTable
    {
        public readonly string Owner;
        public SqlServerTable(string tableName, string[] columnNames,
            int numberRecords, string owner)
           : base(tableName, columnNames, numberRecords)
        {
            Owner = owner;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"I'm MS SQL Server table," +
                $" {_tableName}," +
                $" and my owner is {Owner}" +
                $"\nMy columns:");
            foreach (string column in _columnNames)
            {
                Console.Write(column + " / ");
            }
            Console.WriteLine();
            Console.WriteLine($"Number records - {_numberRecords}");
        }
    }
}
