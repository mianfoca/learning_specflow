using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace ParallelTest.Steps
{
    [Binding]
    public sealed class Lesson11_1
    {
        [Given(@"I navigate to application")]
        public void GivenINavigateToApplication()
        {
            Console.WriteLine("I navigate to application");
        }

        [Given(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword(Table table)
        {
            Console.WriteLine("Entered user and password");
        }

        [Given(@"I click login")]
        public void GivenIClickLogin()
        {
            Console.WriteLine("Click login");
        }

        [Then(@"I should see user login in to the application")]
        public void ThenIShouldSeeUserLoginInToTheApplication()
        {
            Console.WriteLine("Welcome");
        }
    }
}
