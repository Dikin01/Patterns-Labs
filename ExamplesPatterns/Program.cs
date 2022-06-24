﻿using System.Collections.Generic;

using ExamplesPatterns.AbstractFactory;
using ExamplesPatterns.Singleton;

namespace ExamplesPatterns
{
    public class Program
    {
        static void Main()
        {
            var testsPatterns = new List<ITestable>()
            {
                new TestAbstractFactory(),
                new TestSingleton()
            };

            foreach(var test in testsPatterns)
            {
                test.Test();
            }
        }
    }
}
