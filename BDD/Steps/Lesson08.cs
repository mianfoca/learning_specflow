using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BDD.Steps
{
    [Binding]
    public sealed class Lesson08
    {
        [Then(@"I see the menu likes")]
        public void ThenISeeTheMenuLikes(IEnumerable<dynamic> menuList)
        {
            var menu = menuList.First();

            string menu1 = menu.Menu_1;
            string menu2 = menu.Menu_2;

            Console.WriteLine("The value of Menu1 is {0} and " +
                "Menu2 is {1}", menu1, menu2);
        }
    }
}
