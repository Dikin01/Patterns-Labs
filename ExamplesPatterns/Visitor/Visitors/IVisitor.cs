using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
  // Интерфейс посетителя со всеми методами, кого он собирается посещать
  public interface IVisitor
  {
    public void Visit(Student student);
    public void Visit(Teacher teacher);
  }
}
