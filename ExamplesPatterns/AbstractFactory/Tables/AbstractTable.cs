namespace ExamplesPatterns.AbstractFactory.Tables
{
    public abstract class AbstractTable
    {
        protected string _tableName;
        protected string[] _columnNames;
        protected int _numberRecords;

        public AbstractTable(string tableName, string[] columnNames, 
            int numberRecords)
        {
            _tableName = tableName;
            _columnNames = columnNames;
            _numberRecords = numberRecords;
        }

        public abstract void PrintInfo();
    }
}
