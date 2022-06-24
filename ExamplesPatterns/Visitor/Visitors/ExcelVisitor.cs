using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
  // Класс, наследующий интерфейс IVisitor
  public class ExcelVisitor : IVisitor
  {
    // "Посещение" Студентов, или добавление элемента в таблицу Excel
    public void Visit(Student student)
    {
      string table = "|   Name   |     Subject     |    Mark   |";
      string newValue = student.Name + "\t\t" + student.Subject + "\t\t" + student.Mark.ToString();

      Console.WriteLine(table);
      Console.WriteLine(newValue);
      Console.WriteLine("----------------------------------------");
    }
    // Аналогиечное "Посещение" Преподавателей
    public void Visit(Teacher teacher)
    {
      string table = "|   Name   |   Departament   |    Average Mark   |";
      string newValue = teacher.Name + "\t\t" + teacher.Departament + "\t\t" + teacher.AvgMark.ToString();

      Console.WriteLine(table);
      Console.WriteLine(newValue);
      Console.WriteLine("----------------------------------------");
    }
  }
}
