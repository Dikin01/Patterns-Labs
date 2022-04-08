using ExamplesPatterns.AbstractFactory.Queries;
using ExamplesPatterns.AbstractFactory.Tables;
using System.Collections.Generic;

namespace ExamplesPatterns.AbstractFactory.Databases
{
    public class SqliteDatabase : AbsractDatabase
    {
        public SqliteDatabase(string connectionString)
            : base(connectionString) { }

        public override List<AbstractQuery> GetQueries()
        {
            List<AbstractQuery> queries = new List<AbstractQuery>();

            queries.Add(new SqliteQuery("Get users",
                "SELECT * FROM Users"));
            queries.Add(new SqliteQuery("Delete user with Id = 1",
                "DELETE FROM Users" +
                "WHERE Id = 1"));

            return queries;
        }

        public override List<AbstractTable> GetTables()
        {
            List<AbstractTable> tables = new List<AbstractTable>();

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
