using Entities.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BDD.Steps
{
    [Binding]
    public sealed class Lesson01
    {
        private Calculator calculator = new Calculator();

        private int result;

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            calculator.AddNumber(number);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = calculator.Sum();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int resultExpected)
        {
            Assert.AreEqual(resultExpected, result);
        }

    }
}
