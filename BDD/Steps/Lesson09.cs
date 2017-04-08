using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BDD.Steps
{
    [Binding]
    public sealed class Lesson09 : TechTalk.SpecFlow.Steps
    {
        [Given(@"I login to application")]
        public void GivenILoginToApplication(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            Console.WriteLine("Login as {0}", data.UserName);
        }

        [Given(@"I enter following details")]
        public void GivenIEnterFollowingDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            Console.WriteLine("Enter User Details {0} {1}. {2}", data.Title, data.Initial, data.FirstName);
        }

        [Given(@"I login and enter user details")]
        public void GivenILoginAndEnterUserDetails()
        {
            //Create a column header
            string[] colHeader = { "UserName", "Password" };
            string[] row = { "admin", "admin" };

            //Create table with values
            var table = new Table(colHeader);
            table.AddRow(row);

            Given("I login to application", table);

            /************************************/
            string[] colHeaderForDetails = { "Title", "FirstName", "Initial" };
            string[] rowForDetails = { "Mr", "Karthik", "K" };

            //Create table with values
            var tableForDetails = new Table(colHeaderForDetails);
            tableForDetails.AddRow(rowForDetails);

            Given("I enter following details", tableForDetails);
        }

        [Then(@"I click save button")]
        public void ThenIClickSaveButton()
        {
            Console.WriteLine("Saved");
        }
    }
}
