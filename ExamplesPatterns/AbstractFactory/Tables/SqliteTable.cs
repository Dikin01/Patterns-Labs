using System;

namespace ExamplesPatterns.AbstractFactory.Tables
{
    // Таблица для БД типа Sqlite - конкретный продукт для SqliteLoader
    public class SqliteTable : AbstractTable
    {        
        public SqliteTable(string tableName, string[] columnNames,
            int numberRecords) 
            : base(tableName, columnNames, numberRecords) { }

        // Реализует метод для вывода информации в консоль        
        public override void PrintInfo()
        {
            Console.WriteLine($"I'm SQLite table, {tableName}" +
                $"\nMy columns:");
            foreach(string column in columnNames)
            {
                Console.Write(column + " | ");
            }
            Console.WriteLine();
            Console.WriteLine($"Number records - {numberRecords}");
        }
    }
}
