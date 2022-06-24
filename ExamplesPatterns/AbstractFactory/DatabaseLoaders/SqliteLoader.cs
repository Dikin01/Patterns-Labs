using System.Collections.Generic;

using ExamplesPatterns.AbstractFactory.Queries;
using ExamplesPatterns.AbstractFactory.Tables;

namespace ExamplesPatterns.AbstractFactory.Databases
{
    // Конкретная фабрика для получения данных из Sqlite
    public class SqliteLoader : AbstractDatabaseLoader
    {
        public SqliteLoader(string connectionString)
            : base(connectionString) { }

        // Реализуем метод для получения списка хранимых функций
        public override List<AbstractQuery> GetQueries()
        {
            var queries = new List<AbstractQuery>
            {
                // Получим функции типа SqliteQuery
                new SqliteQuery("Get users",
                "SELECT * FROM Users"),

                new SqliteQuery("Delete user with Id = 1",
                "DELETE FROM Users" +
                "WHERE Id = 1")
            };

            return queries;
        }

        // Реализуем метод для получения списка таблиц
        public override List<AbstractTable> GetTables()
        {
            var tables = new List<AbstractTable>
            {
                // Получим таблицы типа SqliteTable
                new SqliteTable("Users",
                new string[] { "Id", "First name", "Last name" }, 15),

                new SqliteTable("Countries",
                new string[] { "Id", "Name", "Сapital" }, 60)
            };

            return tables;
        }
    }
}
