using ExamplesPatterns.Visitor.Elements;

namespace ExamplesPatterns.Visitor.Visitors
{
    // Интерфейс посетителя со всеми методами, кого он собирается посещать
    public interface IVisitor
    {
        public void Visit(Student student);
        public void Visit(Teacher teacher);
    }
}
