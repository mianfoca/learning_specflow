using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BDD.Steps
{
    [Binding]
    public sealed class Lesson12
    {
        [Given(@"a blog post named Random with:")]
        public void GivenABlogPostNamedRandomWith(string multilineText)
        {
            Console.WriteLine("Specifying a larger piece of text");
            Console.WriteLine(multilineText);
        }
    }
}
