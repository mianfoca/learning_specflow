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
    public sealed class Lesson05
    {
        public readonly Employee employee;

        public Lesson05(Employee employee)
        {
            this.employee = employee;
        }

        [When(@"I fill all the mandatory details in form option 3")]
        public void WhenIFillAllTheMandatoryDetailsInFormOption_3(Table table)
        {
            //Work with Context Injection
            var employees = table.CreateDynamicSet();

            foreach (var employee in employees)
            {
                this.employees.Add(new Employee()
                {
                    Name = (string)employee.Name,
                    Age = (int)employee.Age,
                    Email = (string)employee.Email,
                    Phone = (long)employee.Phone
            });
            }
        }

        [Then(@"show mandatory detais added in option 3")]
        public void ThenShowMandatoryDetaisAddedInOption_3()
        {
            //Work with Context Injection
            foreach (var employee in this.employees)
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
