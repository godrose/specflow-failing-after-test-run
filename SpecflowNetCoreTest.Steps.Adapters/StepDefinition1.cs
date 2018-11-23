using System;
using TechTalk.SpecFlow;

namespace SpecflowNetCoreTest.Steps.Adapters
{
    [Binding]
    internal sealed class StepDefinition1
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        [Given("I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator(int number)
        {            
            Console.WriteLine("Arrange");
        }

        [When("I press add")]
        public void WhenIPressAdd()
        {            
            Console.WriteLine("Act");
        }

        [Then("the result should be (.*) on the screen")]
        public void ThenTheResultShouldBe(int result)
        {            
            Console.WriteLine("Assert");
        }
    }
}
