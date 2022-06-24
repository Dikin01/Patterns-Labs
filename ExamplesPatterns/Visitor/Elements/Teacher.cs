using ExamplesPatterns.Visitor.Visitors;

namespace ExamplesPatterns.Visitor.Elements
{
    public class Teacher : IPerson
    {
        public string Name { get; set; }
        public string Departament { get; set; }
        public double AverageMark { get; set; }

        public Teacher()
        {
            Name = "Ivan";
            Departament = "Dep of High Math";
            AverageMark = 3.45;
        }

        public Teacher(string name, string dep, int avgMark)
        {
            Name = name;
            Departament = dep;
            AverageMark = avgMark;
        }

        // метод принятия посетителя, которому передается сам объект Преподавателя
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
