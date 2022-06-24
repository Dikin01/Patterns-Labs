using ExamplesPatterns.Visitor.Visitors;

namespace ExamplesPatterns.Visitor.Elements
{
    public class Student : IPerson
    {
        // Пояснения полей и конструкторов избыточны
        public string Name { get; set; }
        public string Subject { get; set; }
        public int Mark { get; set; }

        public Student()
        {
            Name = "Ivan";
            Subject = "Math";
            Mark = 5;
        }

        public Student(string name, string subject, int mark)
        {
            Name = name;
            Subject = subject;
            Mark = mark;
        }

        // метод принятия посетителя, которому передается сам объект Студента
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
