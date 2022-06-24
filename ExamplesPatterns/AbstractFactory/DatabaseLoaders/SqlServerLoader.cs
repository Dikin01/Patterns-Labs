using System.Collections.Generic;

using ExamplesPatterns.AbstractFactory.Queries;
using ExamplesPatterns.AbstractFactory.Tables;

namespace ExamplesPatterns.AbstractFactory.Databases
{
    // Конкретная фабрика для получения данных из SqlServer
    // Выполним те же шаги реализации, что и в SqliteLoader
    public class SqlServerLoader : AbstractDatabaseLoader
    {
        public SqlServerLoader(string connectionString)
            : base(connectionString) { }


        public override List<AbstractQuery> GetQueries()
        {
            var queries = new List<AbstractQuery>
            {
                // В этой реализации будем получать функции типа SqlServerQuery
                new SqlServerQuery("Get animals",
                "SELECT * FROM Animals"),

                new SqlServerQuery("Get animal with Id = 25",
                "SELECT * FROM Animals" +
                "WHERE Id = 1"),

                new SqlServerQuery(@"Get bunnies",
                "SELECT * FROM Animals" +
                "WHERE type = 'bunny'")
            };

            return queries;
        }

        public override List<AbstractTable> GetTables()
        {
            var tables = new List<AbstractTable>
            {
                // Также получим таблицу типа SqlServerTable
                new SqlServerTable("Animals",
                new string[] { "Id", "Name", "Type" }, 8, "Ivan")
            };

            return tables;
        }
    }
}
