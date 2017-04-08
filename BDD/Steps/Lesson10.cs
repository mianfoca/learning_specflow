using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BDD.Steps
{
    [Binding]
    public sealed class Lesson10
    {
        [Given(@"I have navigate to the application")]
        public void GivenIHaveNavigateToTheApplication()
        {
            Console.WriteLine("Navigate to the application...");
        }

        [Given(@"I click login link")]
        public void GivenIClickLoginLink()
        {
            Console.WriteLine("Click in login link...");
        }

        [When(@"I enter UserName and Password")]
        public void WhenIEnterUserNameAndPassword(Table table)
        {
            Console.WriteLine("Entering user an password");
        }

        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            Console.WriteLine("Click in login button...");
        }

        [Then(@"I should see the username with hello")]
        public void ThenIShouldSeeTheUsernameWithHello()
        {
            Console.WriteLine("Hello");
        }

        [Then(@"I click logout")]
        public void ThenIClickLogout()
        {
            Console.WriteLine("Bye");
        }

    }
}
