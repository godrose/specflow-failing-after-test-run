using System;
using TechTalk.SpecFlow;

namespace SpecflowNetCoreTest.Steps.Adapters
{
    [Binding]
    public class Hook
    {
        [AfterTestRun]
        public static void AfterAllScenarios()
        {
            Console.WriteLine("After test run");
        }
    }
}
