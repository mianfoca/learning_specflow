using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace ParallelTest.Steps
{
    [Binding]
    public sealed class Lesson11_2
    {
        [Given(@"I start entering user form details like")]
        public void GivenIStartEnteringUserFormDetailsLike(Table table)
        {
            Console.WriteLine("User details");
        }

        [Given(@"I click submit button")]
        public void GivenIClickSubmitButton()
        {
            Console.WriteLine("Click submit");
        }

    }
}
