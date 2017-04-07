using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BDD.Steps
{
    [Binding]
    public sealed class Lesson03
    {
        [When(@"I fill all the mandatory details in form option 0")]
        public void WhenIFillAllTheMandatoryDetailsInFormOption_0(Table table)
        {
            //Only One
            var employee = table.CreateInstance<Employee>();
            Console.WriteLine("The Details of Employee: " + employee.Name);
            Console.WriteLine("*********************");
            Console.WriteLine(employee.Age);
            Console.WriteLine(employee.Email);
            Console.WriteLine(employee.Phone);
        }

        [When(@"I fill all the mandatory details in form option 1")]
        public void WhenIFillAllTheMandatoryDetailsInFormOption_1(Table table)
        {
            var employees = table.CreateSet<Employee>();

            foreach (Employee employee in employees)
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
