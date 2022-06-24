using ExamplesPatterns.Visitor.Elements;
using ExamplesPatterns.Visitor.ObjectStructure;
using ExamplesPatterns.Visitor.Visitors;

namespace ExamplesPatterns.Visitor
{
    public class VisitorTest : ITestable
    {
        public void Test()
        {
            // Создадим структруку
            Database database = new Database();

            // А также несколько студентов и преподавателей
            var student1 = new Student
            {
                Name = "Olga",
                Subject = "Physics",
                Mark = 4
            };

            var student2 = new Student
            {
                Name = "Oleg",
                Subject = "P.E.",
                Mark = 5
            };

            var teacher = new Teacher
            {
                Name = "Petrov",
                Departament = "History dep",
                AverageMark = 4.72
            };

            // И добавим их в структуру
            database.Add(student1);
            database.Add(student2);
            database.Add(teacher);

            // Вызов одного и того же метода с разными посетителями даст различные результаты
            database.Accept(new ExcelVisitor());
            database.Accept(new SqlVisitor());
        }
    }
}
