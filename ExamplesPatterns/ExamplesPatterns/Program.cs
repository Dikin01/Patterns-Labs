using System.Collections.Generic;
using ExamplesPatterns.AbstractFactory;
using ExamplesPatterns.Singleton;
using ExamplesPatterns.State;
using ExamplesPatterns.Visitor;

namespace ExamplesPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<ITestable> testsPatterns = new List<ITestable>()
            {
                new TestAbstractFactory(),
                new TestSingleton(),

                new StateTest(),
                new VisitorTest()
 
            };

            foreach(var test in testsPatterns)
            {
                test.Test();
            }
        }
    }
}
