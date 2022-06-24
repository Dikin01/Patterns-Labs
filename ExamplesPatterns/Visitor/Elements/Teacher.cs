using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
  public class Teacher : IPerson
  {
    public string Name { get; set; }
    public string Departament { get; set; }
    public double AvgMark { get; set; }

    public Teacher(){
      Name = "Ivan";
      Departament = "Dep of High Math";
      AvgMark = 3.45;
    }

    public Teacher(string name, string dep, int avgMark)
    {
      Name = name;
      Departament = dep;
      AvgMark = avgMark;
    }

    // метод принятия посетителя, которому передается сам объект Преподавателя
    public void Accept(IVisitor visitor)
    {
      visitor.Visit(this);
    }
  }
}
