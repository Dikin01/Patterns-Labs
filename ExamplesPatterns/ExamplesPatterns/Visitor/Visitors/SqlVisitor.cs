using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
  // Класс, наследующий интерфейс IVisitor
  public class SqlVisitor : IVisitor
  {
    // "Посещение" Студентов, или создание SQL запроса
    public void Visit(Student student)
    {
      string newValue = $@"INSERT INTO Students (Name, Subject, Mark) VALUES ('{student.Name}','{student.Subject}',{student.Mark})";
      Console.WriteLine(newValue);
      Console.WriteLine("----------------------------------------");
    }
    // Аналогичное "Посещение" Преподавателей
    public void Visit(Teacher teacher)
    {
      string newValue = $@"INSERT INTO Teachers (Name, Departament, AvgMark) VALUES ('{teacher.Name}','{teacher.Departament}',{teacher.AvgMark})";
      Console.WriteLine(newValue);
      Console.WriteLine("----------------------------------------");
    }
  }
}
