using ExamplesPatterns.Visitor.Visitors;

namespace ExamplesPatterns.Visitor.Elements
{
    // Интерфейс-Element, содержащий единственный метод "Принятия"
    // принимающий любого посетителя
    public interface IPerson
    {
        public void Accept(IVisitor visitor);
    }
}
