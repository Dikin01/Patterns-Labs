using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
  // Интерфейс-Element, содержащий единственный метод "Принятия"
  // принимающий любого посетителя
  public interface IPerson
  {
    public void Accept(IVisitor visitor);
  }
}
