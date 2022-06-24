using System;

using ExamplesPatterns.Visitor.Elements;

namespace ExamplesPatterns.Visitor.Visitors
{
    // Класс, реализующий интерфейс IVisitor
    public class ExcelVisitor : IVisitor
    {
        // "Посещение" Студентов, или добавление элемента в таблицу Excel
        public void Visit(Student student)
        {
            string table = "|   Name   |     Subject     |    Mark   |";
            string newValue = student.Name + "\t\t" + student.Subject + "\t\t"
                + student.Mark.ToString();

            Console.WriteLine(table);
            Console.WriteLine(newValue);
            Console.WriteLine("----------------------------------------");
        }

        // Аналогиечное "Посещение" Преподавателей
        public void Visit(Teacher teacher)
        {
            string table = "|   Name   |   Departament   |    Average Mark   |";
            string newValue = teacher.Name + "\t\t" + teacher.Departament + "\t\t"
                + teacher.AverageMark.ToString();

            Console.WriteLine(table);
            Console.WriteLine(newValue);
            Console.WriteLine("----------------------------------------");
        }
    }
}
