namespace ExamplesPatterns.AbstractFactory.Queries
{
    // Абстрактная хранимая функция - продукт фабрики AbsracDatabaseLoader
    public abstract class AbstractQuery
    {
        protected string _name;
        protected string _query;

        public AbstractQuery(string name, string query)
        {
            _name = name;
            _query = query;
        }

        public abstract void Execute();       
    }
}
