namespace ExamplesPatterns.AbstractFactory.Tables
{
    // Абстрактная таблица - ещё один продукт фабрики AbsracDatabaseLoader
    public abstract class AbstractTable
    {
        protected string tableName;
        protected string[] columnNames;
        protected int numberRecords;

        public AbstractTable(string tableName, string[] columnNames, 
            int numberRecords)
        {
            this.tableName = tableName;
            this.columnNames = columnNames;
            this.numberRecords = numberRecords;
        }

        public abstract void PrintInfo();
    }
}
