using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BDD.Steps
{
    [Binding]
    public sealed class Lesson07
    {
        [Given(@"I login to application")]
        [Scope(Tag = "admin")]
        public void GivenILoginToApplicationAsCustomer()
        {
            Console.WriteLine("I want Login as Admin");
        }

        //Before Custom Step Argument Transformation
        //[Then(@"I see last date logged in data is (.*) days from current date")]
        //public void ThenISeeLastDateLoggedInDataIsDaysFromCurrentDate(int p0)
        //{
        //    var correctdate = DateTime.Today.AddDays(p0);
        //    Console.WriteLine(correctdate);
        //}

        //After Custom Step Argument Transformation
        [Then(@"I see last date logged in data is (.* days from current date)")]
        public void ThenISeeLastDateLoggedInDataIsDaysFromCurrentDate(DateTime correctdate)
        {
            Console.WriteLine(correctdate);
        }

    }
}
