using ExamplesPatterns.AbstractFactory;
using System.Collections.Generic;

namespace ExamplesPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<ITestable> testsPatterns = new List<ITestable>()
            {
                new TestAbstractFactory()
            };

            foreach(var test in testsPatterns)
            {
                test.Test();
            }
        }
    }
}
