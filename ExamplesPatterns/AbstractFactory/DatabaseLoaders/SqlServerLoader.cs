using ExamplesPatterns.AbstractFactory.Queries;
using ExamplesPatterns.AbstractFactory.Tables;
using System.Collections.Generic;

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
            List<AbstractQuery> queries = new List<AbstractQuery>();
            
            // В этой реализации будем добавлять функции типа SqlServerQuery
            queries.Add(new SqlServerQuery("Get animals",
                "SELECT * FROM Animals"));
            queries.Add(new SqlServerQuery("Get animal with Id = 25",
                "SELECT * FROM Animals" +
                "WHERE Id = 1"));
            queries.Add(new SqlServerQuery(@"Get bunnies",
                "SELECT * FROM Animals" +
                "WHERE type = 'bunny'"));

            return queries;
        }

        public override List<AbstractTable> GetTables()
        {
            List<AbstractTable> tables = new List<AbstractTable>();

            // Также добавим таблицу типа SqlServerTable
            tables.Add(new SqlServerTable("Animals",
                new string[] { "Id", "Name", "Type" }, 8, "Ivan")
            );

            return tables;
        }
    }
}
