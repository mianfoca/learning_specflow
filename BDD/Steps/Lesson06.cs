using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BDD.Steps
{
    [Binding]
    public sealed class Lesson06
    {
        [Given(@"I have opened the application")]
        public void GivenIHaveOpenedTheApplication()
        {
            Console.WriteLine("Opened Application");
        }

        #region Same Step different implementation
        [Given(@"I login to application")]
        [Scope(Tag = "customer")]
        public void GivenILoginToApplicationAsCustomer()
        {
            Console.WriteLine("I want Login as Customer");
        }

        [Given(@"I login to application")]
        [Scope(Tag ="user")]
        public void GivenILoginToApplicationAsUser()
        {
            Console.WriteLine("I want Login as User");
        }
        #endregion

        [Then(@"I see customer portal")]
        public void ThenISeeCustomerPortal()
        {
            Console.WriteLine("I see customer portal");
        }

        [Then(@"I see user portal")]
        public void ThenISeeUserPortal()
        {
            Console.WriteLine("I see user portal");
        }

    }
}
