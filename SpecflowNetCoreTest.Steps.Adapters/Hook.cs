using System;
using System.IO;
using TechTalk.SpecFlow;

namespace SpecflowNetCoreTest.Steps.Adapters
{
    [Binding]
    public class Hook
    {
        [AfterTestRun]
        public static void AfterAllScenarios()
        {
            for (int i = 0; i < Math.Pow(2, 30); i = i)
            {
                i++;
            }            
            File.AppendAllText("hook.log", DateTime.Now.ToString() + typeof(Hook).FullName + Environment.NewLine);
        }
    }
}
