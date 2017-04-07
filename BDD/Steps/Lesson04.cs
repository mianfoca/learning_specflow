using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BDD.Steps
{
    [Binding]
    public sealed class Lesson04
    {
        [When(@"I fill all the mandatory details in form option 2")]
        public void WhenIFillAllTheMandatoryDetailsInFormOption_2(Table table)
        {
            //Work with Dynamic Assist
            var employees = table.CreateDynamicSet();

            foreach (var employee in employees)
            {
                Console.WriteLine("The Details of Employee: " + employee.Name);
                Console.WriteLine("*********************");
                Console.WriteLine(employee.Age);
                Console.WriteLine(employee.Email);
                Console.WriteLine(employee.Phone);
            }
        }
    }
}
