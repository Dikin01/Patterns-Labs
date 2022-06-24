using System;

namespace ExamplesPatterns.AbstractFactory.Tables
{
    // Таблицы для БД типа SqlServer - конкретный продукт для SqlServerLoader
    // Реализуем и расширим AbstractTable, запоминая владельца таблицы
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
                $" {tableName}," +
                $" and my owner is {Owner}" +
                $"\nMy columns:");
            foreach (string column in columnNames)
            {
                Console.Write(column + " / ");
            }
            Console.WriteLine();
            Console.WriteLine($"Number records - {numberRecords}");
        }
    }
}
