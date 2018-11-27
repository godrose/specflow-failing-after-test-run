using System;
using System.Diagnostics;
using System.IO;
using TechTalk.SpecFlow;

namespace SpecflowNetCoreTest
{
    [Binding]
    public class Hook
    {
        [AfterTestRun]
        public static void AfterAllScenarios()
        {
            File.AppendAllText("hook.log", DateTime.Now.ToString() + typeof(Hook).FullName + Environment.NewLine);
        }
    }
}
