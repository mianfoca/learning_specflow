﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BDD.Helper
{
    [Binding]
    class CustomStepArgumentTransformation
    {
        [StepArgumentTransformation(@"(\d+) days from current date")]
        public DateTime DayAdderTransformer(int days)
        {
            return DateTime.Today.AddDays(days);
        }
    }
}
