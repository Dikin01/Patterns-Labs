﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
  public class Database
  {
    // Список, хранящийся в структуре
    public List<IPerson> people = new List<IPerson>();

    // Методы добавления новых людей и удаления  
    public void Add(IPerson person){
      people.Add(person);
    }
    public void Remove(IPerson person){
      people.Remove(person);
    }

    // "Действие" совершаемое со всем людьми в базе данных
    public void Accept(IVisitor visitor){
      foreach(IPerson person in people){
        person.Accept(visitor);
      }
    }
  }
}
