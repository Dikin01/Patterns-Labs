using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor;

namespace ExamplesPatterns.Visitor
{
  internal class VisitorTest : ITestable
  {
    public void Test()
    {
      // Создадим структруку
      Database database = new Database();
      // А также несколько студентов и преподавателей
      Student student1 = new Student { Name = "Olga", Subject = "Physics", Mark = 4 };
      Student student2 = new Student { Name = "Oleg", Subject = "P.E.", Mark = 5 };
      Teacher teacher = new Teacher { Name = "Petrov", Departament = "History dep", AvgMark = 4.72 };

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
