using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BDD.Hooks
{
    [Binding]
    public sealed class TestFixture
    {
        [BeforeScenario]
        public void BeforeAllScenario()
        {
            Console.WriteLine("Calling before All Scenario");
        }

        [BeforeScenario("myscenario")]
        public void BeforeMyScenario()
        {
            Console.WriteLine("Calling before My Scenario");
        }

        [AfterScenario("myscenario")]
        public void AfterMyScenario()
        {
            Console.WriteLine("Calling after My Scenario");
        }

        [AfterScenario]
        public void AfterAllScenario()
        {
            Console.WriteLine("Calling after All Scenario");
        }
    }
}
