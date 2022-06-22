using ExamplesPatterns.AbstractFactory.Queries;
using ExamplesPatterns.AbstractFactory.Tables;
using System.Collections.Generic;

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
            List<AbstractQuery> queries = new List<AbstractQuery>();

            // Добавим фэйковые функции типа SqliteQuery
            queries.Add(new SqliteQuery("Get users",
                "SELECT * FROM Users"));
            queries.Add(new SqliteQuery("Delete user with Id = 1",
                "DELETE FROM Users" +
                "WHERE Id = 1"));

            return queries;
        }

        // Реализуем метод для получения списка таблиц
        public override List<AbstractTable> GetTables()
        {
            List<AbstractTable> tables = new List<AbstractTable>();

            // Добавим фэйковые таблицы типа SqliteTable
            tables.Add(new SqliteTable("Users",
                new string[] { "Id", "First name", "Last name"}, 15)
            );

            tables.Add(new SqliteTable("Countries",
                new string[] { "Id", "Name", "Сapital" }, 60)
            );

            return tables;
        }
    }
}
