using ExamplesPatterns.AbstractFactory.Queries;
using ExamplesPatterns.AbstractFactory.Tables;
using System.Collections.Generic;

namespace ExamplesPatterns.AbstractFactory.Databases
{
    public class SqlServerDatabase : AbsractDatabase
    {
        public SqlServerDatabase(string connectionString)
            : base(connectionString) { }

        public override List<AbstractQuery> GetQueries()
        {
            List<AbstractQuery> queries = new List<AbstractQuery>();

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

            tables.Add(new SqlServerTable("Animals",
                new string[] { "Id", "Name", "Type" }, 8, "Ivan")
            );

            return tables;
        }
    }
}
